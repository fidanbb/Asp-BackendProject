﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Brand;
using BackendProject.Helpers.Extentions;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdvertController : Controller
    {
        private readonly IAdvertService _advertService;
        private readonly IDirectionService _directionService;
        private readonly IMapper _mapper;

        public AdvertController(IAdvertService advertService,
                                IDirectionService directionService,
                                IMapper mapper)
        {
            _advertService = advertService;
            _directionService = directionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _advertService.GetAllWithIncludeAsync());
        }

        [HttpGet]

        public async Task<IActionResult> Detail(int id)
        {
            return View(await _advertService.GetByIdWithIncludeAsync(id));
        }

        [HttpGet]

        public async Task<IActionResult> Create()
        {
            ViewBag.directions = await GetDirectionsAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(AdvertCreateVM request)
        {
            ViewBag.directions = await GetDirectionsAsync();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

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

            await _advertService.CreateAsync(request);

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            await _advertService.DeleteAsync((int)id);

            return RedirectToAction(nameof(Index));

        }

        [HttpGet]

        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.directions = await GetDirectionsAsync();

            if (id is null) return BadRequest();

            AdvertVM dbAdvert = await _advertService.GetByIdWithIncludeAsync((int)id);

            if (dbAdvert is null) return NotFound();

            AdvertEditVM advert = _mapper.Map<AdvertEditVM>(dbAdvert);

            return View(advert);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int? id,AdvertEditVM request)
        {
            ViewBag.directions = await GetDirectionsAsync();

            if (id is null) return BadRequest();

            AdvertVM dbAdvert = await _advertService.GetByIdWithoutTracking((int)id);

            if (dbAdvert is null) return NotFound();

            request.Image = dbAdvert.Image;

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            if (request.Photo is null)
            {
                await _advertService.EditAsync(request);
                return RedirectToAction(nameof(Index));
            }


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


            await _advertService.EditAsync(request);

            return RedirectToAction(nameof(Index));

        }



        private async Task<SelectList> GetDirectionsAsync()
        {
            return new SelectList(await _directionService.GetAllAsync(), "Id", "Name");
        }
    }
}

