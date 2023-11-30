using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.About;
using BackendProject.Areas.Admin.ViewModels.Brand;
using BackendProject.Areas.Admin.ViewModels.Team;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly ITeamService _teamService;
        private readonly IBrandService _brandService;

        public AboutController(IAboutService aboutService,
                               ITeamService teamService,
                               IBrandService brandService)
        {
            _aboutService = aboutService;
            _brandService = brandService;
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            AboutVM about = await _aboutService.GetDataAsync();
            List<TeamVM> teams = await _teamService.GetAllAsync();
            List<BrandVM> brands = await _brandService.GetAllAsync();

            AboutPageVM model = new()
            {
                About=about,
                Teams=teams,
                Brands=brands
            };

            return View(model);
        }
    }
}

