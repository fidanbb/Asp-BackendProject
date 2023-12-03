using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Setting;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly ISettingService _settingService;
        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {

            return View(await _settingService.GetAllAsync());
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Setting setting = await _settingService.GetByIdAsync((int)id);

            if (setting is null) return NotFound();

            SettingEditVM model = new()
            {
                Key = setting.Key,
                Value = setting.Value
            };

            return View(model);


        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, SettingEditVM setting)
        {
            if (id is null) return BadRequest();

            Setting dbSetting = await _settingService.GetByIdAsync((int)id);

            if (dbSetting is null) return NotFound();

            if (dbSetting.Value.Contains("png") || dbSetting.Value.Contains("jpeg") || dbSetting.Value.Contains("jpg"))
            {

                setting.Value = dbSetting.Value;
                setting.Key = dbSetting.Key;


                if (setting.Photo is null)
                {
                    return RedirectToAction(nameof(Index));
                }
                if (!setting.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "File can be only image format");
                    return View(setting);
                }

                if (!setting.Photo.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photo", "File size can be max 200 kb");
                    return View(setting);
                }

            }
            else
            {
                if (id is null) return BadRequest();

                Setting dbsetting = await _settingService.GetByIdAsync((int)id);

                if (dbSetting is null) return NotFound();

                setting.Key = dbSetting.Key;


                if (!ModelState.IsValid)
                {
                    return View(setting);
                }

            }


            await _settingService.EditAsync(setting);

            return RedirectToAction(nameof(Index));
        }


    }
}

