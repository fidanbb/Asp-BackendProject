using System;
using AutoMapper;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class DirectionService:IDirectionService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DirectionService(AppDbContext context,
                              IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<DirectionVM>> GetAllAsync()
        {
            return _mapper.Map<List<DirectionVM>>(await _context.Directions.ToListAsync());
        }
    }
}

