using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Subscribe;
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class SubscribeService:ISubscribeService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SubscribeService(AppDbContext context,
                             IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(SubscribeCreateVM subscribe)
        {
            var data = _mapper.Map<Subscribe>(subscribe);

            await _context.Subscribes.AddAsync(data);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Subscribe subscribe = await _context.Subscribes.Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.Subscribes.Remove(subscribe);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SubscribeVM>> GetAllAsync()
        {
            List<Subscribe> subscribes = await _context.Subscribes.ToListAsync();

            return _mapper.Map<List<SubscribeVM>>(subscribes);
        }
    }
}

