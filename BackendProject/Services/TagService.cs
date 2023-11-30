using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Tag;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class TagService:ITagService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TagService(AppDbContext context,
                             IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<TagVM>> GetAllAsync()
        {
            return _mapper.Map<List<TagVM>>(await _context.Tags.ToListAsync());
        }
    }
}

