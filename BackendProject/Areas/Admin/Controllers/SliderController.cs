using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IWebHostEnvironment _env;


        public SliderController(ISliderService sliderService,
                                IWebHostEnvironment env)
        {
            _sliderService = sliderService;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _sliderService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            SliderVM slider = await _sliderService.GetByIdWithOutTrackingAsync((int)id);

            if (slider is null) return NotFound();

            return View(slider);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderCreateVM slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photos", "File can be only image format");
                return View();
            }

            if (!slider.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photos", "File size can be max 200 kb");
                return View();
            }



            await _sliderService.CreateAsync(slider);


            return RedirectToAction("Index");
        }
    }
}

