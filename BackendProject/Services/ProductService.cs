﻿using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class ProductService:IProductService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

		public ProductService(AppDbContext context,
                              IMapper mapper)
		{
            _context = context;
            _mapper = mapper;
		}

        public async Task<List<ProductVM>> GetByTakeWithIncludes(int take)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Category)
                                                                       .Include(m => m.Images)
                                                                       .Take(take).ToListAsync());
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Products.CountAsync();
        }

        public async Task<List<ProductVM>> GetPaginatedDatasAsync(int page, int take)
        {
            List<Product> products = await _context.Products.Include(m => m.Category)
                                                             .Include(m => m.Images)
                                                             .Skip((page * take) - take)
                                                             .Take(take)
                                                             .ToListAsync();
            return _mapper.Map<List<ProductVM>>(products);
        }

        public async Task<List<ProductVM>> SearchAsync(string searchText)
        {
            var dbProducts = await _context.Products.Include(m => m.Images)
                                                  .Include(m => m.Category)?
                                                  .OrderByDescending(m => m.Id)
                                                  .Where(m=> m.Name.ToLower().Trim().Contains(searchText.ToLower().Trim()))
                                                  .Take(6)
                                                  .ToListAsync();

            return _mapper.Map<List<ProductVM>>(dbProducts);
        }

        public async Task<List<ProductVM>> ShowMoreOrLess(int take, int skip)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Category)
                                                                       .Include(m => m.Images)
                                                                       .Skip(skip)
                                                                       .Take(take)
                                                                       .ToListAsync());
        }
    }
}

