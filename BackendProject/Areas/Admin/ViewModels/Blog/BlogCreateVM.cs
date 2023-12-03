using System;
using System.ComponentModel.DataAnnotations;
using BackendProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BackendProject.Areas.Admin.ViewModels.Blog
{
	public class BlogCreateVM
	{
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }

        //public List<Models.Tag> Tags { get; set; }
        //public List<int> TagIds { get; set; }

        //public int TagId { get; set; }
        //public string TagName { get; set; }

        public IList<SelectListItem> Tags { get; set; }
    }
}

