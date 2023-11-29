using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class AdvertService:IAdvertService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public AdvertService(AppDbContext context,
			                 IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

        public async Task<List<AdvertVM>> GetAllWithIncludeAsync()
        {
			return _mapper.Map<List<AdvertVM>>(await _context.Adverts.Include(m => m.Direction).ToListAsync());
        }
    }
}

