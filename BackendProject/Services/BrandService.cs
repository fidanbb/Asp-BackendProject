using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Brand;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class BrandService:IBrandService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public BrandService(AppDbContext context,
                              IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<BrandVM>> GetAllAsync()
        {
            return _mapper.Map<List<BrandVM>>(await _context.Brands.ToListAsync());
        }
    }
}

