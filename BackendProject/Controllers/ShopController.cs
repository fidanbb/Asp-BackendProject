using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Data;
using BackendProject.Helpers;
using BackendProject.Models;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels.Wishlist;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Controllers
{
    public class ShopController : Controller
    {

        private readonly IProductService _productService;
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IWishlistService _wishlistService;


        public ShopController(IProductService productService,
                              AppDbContext context,
                              UserManager<AppUser> userManager,
                              IWishlistService wishlistService)
        {
            _productService = productService;
            _context = context;
            _userManager = userManager;
            _wishlistService = wishlistService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page=1,int take=3)
        {
            List<ProductVM> dbPaginatedDatas = await _productService.GetPaginatedDatasAsync(page, take);

            int pageCount = await GetPageCountAsync(take);

            Paginate<ProductVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);

            return View(paginatedDatas);
        }

        [HttpGet]
        private async Task<int> GetPageCountAsync(int take)
        {
            int productCount = await _productService.GetCountAsync();
            return (int)Math.Ceiling((decimal)(productCount) / take);
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchText)
        {
            if(searchText is null)
            {
               return RedirectToAction("Index","Home");
            }
            return View(await _productService.SearchAsync(searchText));
        }


        [HttpPost]
        public async Task<IActionResult> AddToWishlist(WishlistDetailVM wishlistAdd)
        {
            if (!ModelState.IsValid) return BadRequest(wishlistAdd);

            var user = await _userManager.GetUserAsync(User);

            if (user == null) return Unauthorized();

            var product = await _context.Products.FindAsync(wishlistAdd.Id);
            if (product == null) return NotFound();

            var wishlist = await _context.Wishlists.Include(m => m.WishlistProducts).FirstOrDefaultAsync(m => m.AppUserId == user.Id);

            if (wishlist == null)
            {
                wishlist = new Wishlist
                {
                    AppUserId = user.Id
                };

                await _context.Wishlists.AddAsync(wishlist);
                await _context.SaveChangesAsync();
            }

            var wishlistProduct = await _context.WishlistProducts
                .FirstOrDefaultAsync(bp => bp.ProductId == product.Id && bp.WishlistId == wishlist.Id);

            List<WishlistProduct> wishlistProducts = await _context.WishlistProducts.Where(m => m.WishlistId == wishlist.Id).ToListAsync();

            foreach (var item in wishlistProducts)
            {
                if (item.ProductId!=product.Id)
                {
                    wishlistProduct = new WishlistProduct
                    {
                        WishlistId = wishlist.Id,
                        ProductId = product.Id,

                    };
                }
            }

          

            await _context.WishlistProducts.AddAsync(wishlistProduct);


            //if (wishlistProduct != null)
            //{
            //    wishlistAdd.Count++;
            //}

            //else
            //{
            //    wishlistProduct = new WishlistProduct
            //    {
            //        WishlistId = wishlist.Id,
            //        ProductId = product.Id,
                    
            //    };

            //    await _context.WishlistProducts.AddAsync(wishlistProduct);
            //}

            await _context.SaveChangesAsync();


            List<WishlistVM> wishlists = new();

            if (wishlist is not null)
            {
                wishlistProducts = await _context.WishlistProducts.Where(m => m.WishlistId == wishlist.Id).ToListAsync();
                foreach (var item in wishlistProducts)
                {
                    wishlists.Add(new WishlistVM
                    {
                        ProductId = item.ProductId,
                    });
                }
                Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(wishlists));
            }

            return Ok(_wishlistService.GetDatasFromCookie().Count());
        }

    }
}

