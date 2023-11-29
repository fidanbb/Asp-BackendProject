using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Areas.Admin.ViewModels.Review;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Models;
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

        public HomeController(ISliderService sliderService,
                              IAdvertService advertService,
                              IReviewService reviewService,
                              IProductService productservice)
        {
            _sliderService = sliderService;
            _advertService = advertService;
            _reviewService = reviewService;
            _productService = productservice;
        }

        public async Task< IActionResult> Index()
        {
            List<SliderVM> sliders = await _sliderService.GetAllAsync();
            List<AdvertVM> adverts = await _advertService.GetAllWithIncludeAsync();
            List<ReviewVM> reviews = await _reviewService.GetAllWithIncludeAsync();
            List<ProductVM> products = await _productService.GetByTakeWithIncludes(3);

            HomeVM model = new()
            {
                Sliders = sliders,
                Adverts=adverts,
                Reviews=reviews,
                Products=products
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


    }
}