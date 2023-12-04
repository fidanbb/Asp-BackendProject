using System;
using AutoMapper;
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels.Wishlist;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BackendProject.Services
{
	public class WishlistService:IWishlistService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IMapper _mapper;
		private readonly AppDbContext _context;

		public WishlistService(IHttpContextAccessor httpContextAccessor,
                               IMapper mapper,
                               AppDbContext context)
		{
			_httpContextAccessor = httpContextAccessor;
			_mapper = mapper;
		}



        public List<WishlistVM> GetDatasFromCookie()
        {
            List<WishlistVM> wishlists;

            if (_httpContextAccessor.HttpContext.Request.Cookies["wishlist"] != null)
            {
                wishlists = JsonConvert.DeserializeObject<List<WishlistVM>>(_httpContextAccessor.HttpContext.Request.Cookies["wishlist"]);
            }
            else
            {
                wishlists = new List<WishlistVM>();
            }
            return wishlists;
        }


        public void SetDatasToCookie(List<WishlistVM> wishlists, Product dbProduct, WishlistVM existProduct)
        {
            if (existProduct == null)
            {
                wishlists.Add(new WishlistVM
                {
                    ProductId = dbProduct.Id,
                });
            }
          
            _httpContextAccessor.HttpContext.Response.Cookies
                .Append("wishlist", JsonConvert.SerializeObject(wishlists));
        }

        public void DeleteData(int? id)
        {
            var wishlists = JsonConvert.DeserializeObject<List<WishlistVM>>(_httpContextAccessor.HttpContext.Request.Cookies["wishlist"]);
            var deletedProduct = wishlists.FirstOrDefault(m => m.ProductId == id);
            wishlists.Remove(deletedProduct);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(wishlists));
        }

        public async Task<List<WishlistProduct>> GetAllByWishlistIdAsync(int? wishlistId)
        {
            return await _context.WishlistProducts.Where(m => m.WishlistId == wishlistId).ToListAsync();
        }

        public async Task<Wishlist> GetByUserIdAsync(string userId)
        {
            Wishlist wishlists = await _context.Wishlists.Include(m => m.WishlistProducts).FirstOrDefaultAsync(m => m.AppUserId == userId);

            return wishlists;

        }


    }
}

