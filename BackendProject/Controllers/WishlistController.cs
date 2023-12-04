using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels.Wishlist;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Controllers
{
    public class WishlistController : Controller
    {

        private readonly IProductService _productService;
        private readonly IWishlistService _wishlistService;
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        public WishlistController(IProductService productService,
                                  IWishlistService wishlistService,
                                  UserManager<AppUser> userManager,
                                  AppDbContext context)
        {
            _productService = productService;
            _wishlistService = wishlistService;
            _userManager = userManager;
            _context = context;
       
        }


        public async Task<IActionResult> Index()
        {

            List<WishlistVM> wishlists = _wishlistService.GetDatasFromCookie();
            List<WishlistDetailVM> wishlistDetails = new();

            foreach (var item in wishlists)
            {
                ProductDetailVM dbProduct = await _productService.GetByIdWithIncludesWithoutTrackingAsync(item.ProductId);

                wishlistDetails.Add(new WishlistDetailVM
                {
                    Id=dbProduct.Id,
                    Name=dbProduct.Name,
                    Price=dbProduct.Price,
                    Image= dbProduct.Images.FirstOrDefault(m => m.IsMain).Image
                });
            }


            return View(wishlistDetails);
        }


        [HttpPost]

        public async Task<IActionResult> DeleteDataFromWishlist(int? id)
        {
            if (id is null) return BadRequest();

            _wishlistService.DeleteData((int)id);


            //List<WishlistVM> wishlists = new();

           
                //List<WishlistProduct> wishlistProducts = await _context.WishlistProducts.Where(m => m.WishlistId == wishlist.Id).ToListAsync();
                //foreach (var item in wishlistProducts)
                //{
                //    wishlists.Add(new WishlistVM
                //    {
                //        ProductId = item.ProductId,
                //    });
                //}
                //Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(wishlists));
      


            //wishlists = _wishlistService.GetDatasFromCookie();

            return Ok(_wishlistService.GetDatasFromCookie().Count());



        }

    }
}

