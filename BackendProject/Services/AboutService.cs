using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.About;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class AboutService:IAboutService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public AboutService(AppDbContext context,
			                IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

        public async Task<AboutVM> GetDataAsync()
        {
			return _mapper.Map<AboutVM>(await _context.Abouts.FirstOrDefaultAsync());
        }
    }
}

