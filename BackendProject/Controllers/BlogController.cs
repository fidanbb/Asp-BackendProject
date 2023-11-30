﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Tag;
using BackendProject.Helpers;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ITagService _tagService;

        public BlogController(IBlogService blogService,
                              ITagService tagService)
        {
            _blogService = blogService;
            _tagService = tagService;
        }


        // GET: /<controller>/
        public async Task<IActionResult> Index(int page=1,int take=6)
        {
            List<BlogVM> dbPaginatedDatas = await _blogService.GetPaginatedDatasAsync(page, take);
            List<TagVM> tags = await _tagService.GetAllAsync();

            int pageCount = await GetPageCountAsync(take);

            Paginate<BlogVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);

            BlogPageVM model = new()
            {
                PaginatedDatas = paginatedDatas,
                Tags=tags
            };

            return View(model);
        }

        private async Task<int> GetPageCountAsync(int take)
        {
            int blogCount = await _blogService.GetCountAsync();
            return (int)Math.Ceiling((decimal)(blogCount) / take);
        }

        public async Task<IActionResult> Detail(int id)
        {
            BlogDetailVM blog = await _blogService.GetByIdAsync(id);

            return View(blog);
        }
    } 
}

