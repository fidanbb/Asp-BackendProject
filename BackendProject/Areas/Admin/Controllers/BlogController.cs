using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Areas.Admin.ViewModels.Tag;
using BackendProject.Data;
using BackendProject.Helpers;
using BackendProject.Helpers.Extentions;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ITagService _tagService;
        private readonly AppDbContext _context;
      

        public BlogController(IBlogService blogService,
                              ITagService tagService,
                              AppDbContext context)
        {
            _blogService = blogService;
            _tagService = tagService;
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 3)
        {
            List<BlogVM> dbPaginatedDatas = await _blogService.GetPaginatedDatasAsync(page, take);

            int pageCount = await GetPageCountAsync(take);

            Paginate<BlogVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
            return View(paginatedDatas);
        }



        public async Task<int> GetPageCountAsync(int take)
        {
            int blogCount = await _blogService.GetCountAsync();

            return (int)Math.Ceiling((decimal)(blogCount) / take);
        }


        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            BlogDetailVM blog = await _blogService.GetByIdAsync((int)id);

            if (blog is null) return NotFound();

            return View(blog);
        }



        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.tags = await GetAllTags();


            //var tags = _context.Tags.Select(m => new SelectListItem()
            //{
            //    Text=m.Name,
            //    Value=m.Id.ToString(),

            //}).ToList();

            var tags = _tagService.GetAllSelectedAsync();

            BlogCreateVM viewModel = new BlogCreateVM
            {
                Tags = tags
            };

            return View(viewModel);
        }

        private async Task<List<TagVM>> GetAllTags()
        {
            return await _tagService.GetAllAsync();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(BlogCreateVM request)
        {
            ViewBag.tags = await GetAllTags();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            BlogVM existBlog = await _blogService.GetByNameWithoutTrackingAsync(request.Title);

            if (existBlog is not null)
            {
                ModelState.AddModelError("Title", "This title already exists");

                return View(request);
            }

            foreach (var photo in request.Photos)
            {

                if (!photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photos", "File can be only image format");
                    return View(request);
                }

                if (!photo.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photos", "File size can be max 200 kb");
                    return View(request);
                }
            }


            await _blogService.CreateAsync(request);
            return RedirectToAction(nameof(Index));
        }

    }
}

