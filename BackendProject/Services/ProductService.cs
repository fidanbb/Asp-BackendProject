using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class ProductService:IProductService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

		public ProductService(AppDbContext context,
                              IMapper mapper,
                              IWebHostEnvironment env)
		{
            _context = context;
            _mapper = mapper;
            _env = env;
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


       

        public async Task<ProductDetailVM> GetByIdWithIncludesWithoutTrackingAsync(int id)
        {
            Product dbProduct = await _context.Products.AsNoTracking()
                                                      .Where(m => m.Id == id)
                                                      .Include(m => m.Images)
                                                      .Include(m => m.Category)
                                                      .FirstOrDefaultAsync();

            return _mapper.Map<ProductDetailVM>(dbProduct);
        }

        public async Task CreateAsync(ProductCreateVM product)
        {
            List<ProductImage> newImages = new();

            foreach (var photo in product.Photos)
            {
                string fileName = $"{Guid.NewGuid()}-{photo.FileName}";

                string path = _env.GetFilePath("img/product", fileName);

                await photo.SaveFileAsync(path);

                newImages.Add(new ProductImage { Image = fileName });
            }

            newImages.FirstOrDefault().IsMain = true;

            await _context.ProductImages.AddRangeAsync(newImages);

            await _context.Products.AddAsync(new Product
            {
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
                Images = newImages
            });

            await _context.SaveChangesAsync();
        }

        public async Task<ProductVM> GetByNameWithoutTrackingAsync(string name)
        {
            Product dbProduct = await _context.Products.AsNoTracking().
                                                        FirstOrDefaultAsync(m => m.Name.Trim() == name.Trim());

            return _mapper.Map<ProductVM>(dbProduct);
        }

        public async Task EditAsync(ProductEditVM product)
        {
            List<ProductImage> newImages = new();

            if (product.Photos != null)
            {
                foreach (var photo in product.Photos)
                {
                    string fileName = $"{Guid.NewGuid()} - {photo.FileName}";

                    string path = _env.GetFilePath("img/product", fileName);

                    await photo.SaveFileAsync(path);

                    newImages.Add(new ProductImage { Image = fileName });
                }

                await _context.ProductImages.AddRangeAsync(newImages);
            }

            newImages.AddRange(product.Images);


            Product dbProduct = await _context.Products.AsNoTracking().FirstOrDefaultAsync(m => m.Id == product.Id);

            product.Images = newImages;

            _mapper.Map(product, dbProduct);

            _context.Products.Update(dbProduct);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductImageAsync(int id)
        {
            ProductImage productImage = await _context.ProductImages.Where(m => m.Id == id).FirstOrDefaultAsync();

            _context.Remove(productImage);

            await _context.SaveChangesAsync();

            string path = _env.GetFilePath("img/product", productImage.Image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task DeleteAsync(int id)
        {
            Product dbProduct = await _context.Products.Include(m => m.Images).FirstOrDefaultAsync(m => m.Id == id);

            _context.Products.Remove(dbProduct);

            await _context.SaveChangesAsync();

            foreach (var item in dbProduct.Images)
            {
                string path = _env.GetFilePath("img/product", item.Image);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

            }
        }
    }
}

