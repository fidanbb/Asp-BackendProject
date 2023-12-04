using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Account;
using BackendProject.Data;
using BackendProject.Helpers.Enums;
using BackendProject.Models;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels.Account;
using BackendProject.ViewModels.Wishlist;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWishlistService _wishlistService;
        private readonly AppDbContext _context;


        public AccountController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager,
                                 RoleManager<IdentityRole> roleManager,
                                 IWishlistService wishlistService,
                                 AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _wishlistService = wishlistService;
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            //var existUser = await _userManager.FindByEmailAsync(request.Email);

            //if(existUser is not null)
            //{
            //    ModelState.AddModelError(string.Empty, "this email already used");
            //    return View(request);
            //}


            AppUser user = new()
            {
                FullName = request.FullName,
                UserName = request.Username,
                Email = request.Email
            };

            IdentityResult result = await _userManager.CreateAsync(user, request.Passsword);


            if (!result.Succeeded)
            {

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                    return View(request);
                }

            }

            var createdUser = await _userManager.FindByNameAsync(request.Username);

            await _userManager.AddToRoleAsync(createdUser, Roles.Member.ToString());

            return RedirectToAction(nameof(Login));
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(LoginVM request)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }


            var dbUser = await _userManager.FindByEmailAsync(request.EmailOrUsername);

            if (dbUser is null)
            {
                dbUser = await _userManager.FindByNameAsync(request.EmailOrUsername);
            }

            if (dbUser is null)
            {
                ModelState.AddModelError(string.Empty, "Login Informations are wrong");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(dbUser, request.Password, request.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Login Informations are wrong");
                return View();
            }
            List<WishlistVM> wishlists = new();

            Wishlist dbWishlist =await _context.Wishlists.Include(m => m.WishlistProducts).FirstOrDefaultAsync(m => m.AppUserId == dbUser.Id);


            if (dbWishlist is not null)
            {
                List<WishlistProduct> wishlistProducts = await _context.WishlistProducts.Where(m => m.WishlistId == dbWishlist.Id).ToListAsync();
                foreach (var wishlistProduct in wishlistProducts)
                {
                    wishlists.Add(new WishlistVM
                    {
                        ProductId = wishlistProduct.ProductId,
                    });
                }
                Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(wishlists));
            }
            return RedirectToAction("Index", "Home");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(string userId)
        {
            await _signInManager.SignOutAsync();

            List<WishlistVM> wishlists = _wishlistService.GetDatasFromCookie();

            Wishlist dbWishlist = await _context.Wishlists.Include(m => m.WishlistProducts).FirstOrDefaultAsync(m => m.AppUserId == userId);

            if (wishlists.Count() != 0)
            {
                if (dbWishlist == null)
                {
                    dbWishlist = new()
                    {
                        AppUserId = userId,
                        WishlistProducts = new List<WishlistProduct>()
                    };

                    foreach (var item in wishlists)
                    {
                        dbWishlist.WishlistProducts.Add(new WishlistProduct()
                        {
                            ProductId = item.ProductId,
                            WishlistId = dbWishlist.Id
                        });
                    }
                    await _context.Wishlists.AddAsync(dbWishlist);
                    await _context.SaveChangesAsync();
                }

                else
                {
                    List<WishlistProduct> wishlistProducts = new List<WishlistProduct>();
                    foreach (var item in wishlists)
                    {
                        wishlistProducts.Add(new WishlistProduct()
                        {
                            ProductId = item.ProductId,
                            WishlistId = dbWishlist.Id
                        });

                        dbWishlist.WishlistProducts = wishlistProducts;
                        await _context.SaveChangesAsync();


                    }
                }
                Response.Cookies.Delete("wishlist");
            }

            else
            {
                _context.Wishlists.Remove(dbWishlist);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> CreateRoles()
        {
            foreach (var role in Enum.GetValues(typeof(Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(role.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
                }
            }

            return Ok();
        }
    }
}

