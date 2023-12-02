using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Tag;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagController : Controller
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _tagService.GetAllAsync());
        }

        [HttpGet]

        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            TagVM dbTag = await _tagService.GetByIdWithoutTrackingAsync((int)id);

            if (dbTag is null) return NotFound();

            return View(dbTag);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(TagCreateVM request)
        {
          

            if (!ModelState.IsValid)
            {
                return View();
            }

            TagVM existTag = await _tagService.GetByNameWithoutTrackingAsync(request.Name);

            if(existTag != null)
            {
                ModelState.AddModelError("Name", "This Tag already exists");
                return View();
            }


            await _tagService.CreateAsync(request);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {


            await _tagService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            TagVM dbTag = await _tagService.GetByIdWithoutTrackingAsync((int)id);

            if (dbTag is null) return NotFound();

            return View(new TagEditVM
            {
                Name=dbTag.Name
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int? id, TagEditVM request)
        {
            if (id is null) return BadRequest();

            TagVM dbTag = await _tagService.GetByIdWithoutTrackingAsync((int)id);

            if (dbTag is null) return NotFound();


            if (!ModelState.IsValid)
            {
                return View();
            }

            TagVM existTag = await _tagService.GetByNameWithoutTrackingAsync(request.Name);

            if (existTag.Id == request.Id)
            {
                await _tagService.EditAsync(request);

                return RedirectToAction(nameof(Index));
            }

            if (existTag != null)
            {
                ModelState.AddModelError("Name", "This Tag already exists");
                return View();
            }

            await _tagService.EditAsync(request);

            return RedirectToAction(nameof(Index));

        }


    }
}

