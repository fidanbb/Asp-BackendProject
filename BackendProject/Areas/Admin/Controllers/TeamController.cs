using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Areas.Admin.ViewModels.Team;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {

        private readonly ITeamService _teamService;
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;
        public TeamController(ITeamService teamService,
                              IWebHostEnvironment env,
                              IMapper mapper,
                              AppDbContext context)
        {
            _teamService = teamService;
            _env = env;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            return View(await _teamService.GetAllAsync());
        }

        public  async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            TeamVM dbTeam = await _teamService.GetByIdWithoutTrackingAsync((int)id);

            if (dbTeam is null) return NotFound();

            return View(dbTeam);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            if (!request.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photos", "File can be only image format");
                return View();
            }

            if (!request.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photos", "File size can be max 200 kb");
                return View();
            }



            await _teamService.CreateAsync(request);


            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _teamService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            TeamVM dbTeam = await _teamService.GetByIdWithoutTrackingAsync((int)id);

            if (dbTeam is null) return NotFound();

            TeamEditVM team = _mapper.Map<TeamEditVM>(dbTeam);


            return View(team);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, TeamEditVM request)
        {
            if (id is null) return BadRequest();

            TeamVM dbTeam = await _teamService.GetByIdWithoutTrackingAsync((int)id);

            if (dbTeam is null) return NotFound();

            request.Image = dbTeam.Image;

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
            await _teamService.EditAsync(request);
            return RedirectToAction(nameof(Index));
        }
    }
}

