using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Areas.Admin.ViewModels.Review;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Areas.Admin.ViewModels.Subscribe;
using BackendProject.Models;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BackendProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IAdvertService _advertService;
        private readonly IReviewService _reviewService;
        private readonly IProductService _productService;
        private readonly IBlogService _blogService;
        private readonly ISubscribeService _subscribeService;

        public HomeController(ISliderService sliderService,
                              IAdvertService advertService,
                              IReviewService reviewService,
                              IProductService productservice,
                              IBlogService blogService,
                              ISubscribeService subscribeService)
        {
            _sliderService = sliderService;
            _advertService = advertService;
            _reviewService = reviewService;
            _productService = productservice;
            _blogService = blogService;
            _subscribeService = subscribeService;
        }

        public async Task< IActionResult> Index()
        {
            List<SliderVM> sliders = await _sliderService.GetAllAsync();
            List<AdvertVM> adverts = await _advertService.GetAllWithIncludeByTakeAsync(2);
            List<ReviewVM> reviews = await _reviewService.GetAllWithIncludeAsync();
            List<ProductVM> products = await _productService.GetByTakeWithIncludes(3);
            List<BlogVM> blogs = await _blogService.GetByTakeWithImagesAsync(3);

            HomeVM model = new()
            {
                Sliders = sliders,
                Adverts=adverts,
                Reviews=reviews,
                Products=products,
                Blogs=blogs
            };

            int productCount = await _productService.GetCountAsync();
            ViewBag.count = productCount;

            return View(model);
        }


        public async Task<IActionResult> LoadMore(int skipCount)
        {

            List<ProductVM> products = await _productService.ShowMoreOrLess(3,skipCount);

            return PartialView("_ProductsPartial", products);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSubscribe(SubscribeCreateVM subscribe)
        {

            await _subscribeService.CreateAsync(subscribe);
            return RedirectToAction("Index", "Home");
        }

    }
}