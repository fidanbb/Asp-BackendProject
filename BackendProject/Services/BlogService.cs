using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class BlogService:IBlogService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

		public BlogService(AppDbContext context,
			               IMapper mapper,
                           IWebHostEnvironment env)
		{

			_context = context;
			_mapper = mapper;
            _env = env;
		}

        public async Task CreateAsync(BlogCreateVM blog)
        {
            List<BlogImage> newImages = new();

            foreach (var photo in blog.Photos)
            {
                string fileName = $"{Guid.NewGuid()}-{photo.FileName}";

                string path = _env.GetFilePath("img/blog", fileName);

                await photo.SaveFileAsync(path);

                newImages.Add(new BlogImage { Image = fileName });
            }

            newImages.FirstOrDefault().IsMain = true;

            var selectedTags = blog.Tags.Where(m => m.Selected).Select(m => m.Value).ToList();

            


            var dbBlog = new Blog()
            {
                Title = blog.Title,
                Description = blog.Description,
                Images = newImages,
            };

            foreach (var item in selectedTags)
            {
                dbBlog.BlogTags.Add(new BlogTag()
                {
                    TagId=int.Parse(item)
                });
            }

            await _context.BlogImages.AddRangeAsync(newImages);

            await _context.Blogs.AddAsync(dbBlog);

            //await _context.Blogs.AddAsync(new Blog
            //{
            //    Title=blog.Title,
            //    Description=blog.Description,
            //    Images = newImages,

            //});


            await _context.SaveChangesAsync();
        }

        public async Task<BlogDetailVM> GetByIdAsync(int id)
        {
            Blog blog = await _context.Blogs.Where(m => m.Id == id)
                                            .Include(m => m.Images)
                                            .Include(m => m.BlogTags)
                                            .ThenInclude(m => m.Tag)
                                            .FirstOrDefaultAsync();

            return _mapper.Map<BlogDetailVM>(blog);
        }

        public async Task<BlogDetailVM> GetByIdWithoutTracking(int id)
        {
            Blog blog = await _context.Blogs.Where(m => m.Id == id).FirstOrDefaultAsync();

            return _mapper.Map<BlogDetailVM>(blog);
        }

        public async Task<BlogVM> GetByNameWithoutTrackingAsync(string name)
        {
            Blog blog = await _context.Blogs.Where(m => m.Title.Trim().ToLower()==name.Trim().ToLower()).FirstOrDefaultAsync();

            return _mapper.Map<BlogVM>(blog);
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

