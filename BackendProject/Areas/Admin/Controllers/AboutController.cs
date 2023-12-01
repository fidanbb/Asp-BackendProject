using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.About;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;
        private readonly IAboutService _aboutService;


        public AboutController(IWebHostEnvironment env,
                               IMapper mapper,
                               IAboutService aboutService)
        {
     
            _env = env;
            _mapper = mapper;
            _aboutService = aboutService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _aboutService.GetDataAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            AboutVM about = await _aboutService.GetByIdWithoutTrackingAsync((int)id);

            if (about is null) return NotFound();

            return View(about);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            AboutVM dbAbout = await _aboutService.GetByIdWithoutTrackingAsync((int)id);

            if (dbAbout is null) return NotFound();

            AboutEditVM about = _mapper.Map<AboutEditVM>(dbAbout);


            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, AboutEditVM request)
        {

            if (id is null) return BadRequest();

            AboutVM dbAbout = await _aboutService.GetByIdWithoutTrackingAsync((int)id);

            if (dbAbout is null) return NotFound();


            request.Image = dbAbout.Image;

            if (!ModelState.IsValid)
            {
                return View(request);
            }
            if (request.Photo is not null)
            {
                if (!request.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "File can be only image format");
                    return View(request);
                }
                if (!request.Photo.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photo", "File size can be max 200 kb");
                    return View(request);
                }
            }
            await _aboutService.EditAsync(request);
            return RedirectToAction(nameof(Index));
        }

    }
}

