using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Social;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class SocialService:ISocialService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SocialService(AppDbContext context,
                           IMapper mapper)
        {

            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SocialVM>> GetAllAsync()
        {
            return _mapper.Map<List<SocialVM>>(await _context.Socials.ToListAsync());
        }
    }
}

