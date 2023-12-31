﻿using System;
using System.ComponentModel.DataAnnotations;
using BackendProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BackendProject.Areas.Admin.ViewModels.Blog
{
	public class BlogCreateVM
	{
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }
        public IList<SelectListItem> Tags { get; set; }
    }
}

