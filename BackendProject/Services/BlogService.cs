using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class BlogService:IBlogService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public BlogService(AppDbContext context,
			               IMapper mapper)
		{

			_context = context;
			_mapper = mapper;
		}

        public async Task<List<BlogVM>> GetByTakeWithImagesAsync(int take)
        {
            List<Blog> blogs = await _context.Blogs.OrderByDescending(m => m.CreatedDate)
                                                   .Take(take)
                                                   .Include(m => m.Images)
                                                   .ToListAsync();

            return _mapper.Map<List<BlogVM>>(blogs);
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Blogs.CountAsync();
        }

        public async Task<List<BlogVM>> GetPaginatedDatasAsync(int page, int take)
        {
            List<Blog> blogs = await _context.Blogs.OrderByDescending(m=>m.CreatedDate)
                                                   .Include(m => m.Images)
                                                   .Skip((page * take) - take)
                                                   .Take(take)
                                                   .ToListAsync();
            return _mapper.Map<List<BlogVM>>(blogs);
        }
    }
}

