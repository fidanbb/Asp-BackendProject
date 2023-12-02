using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Category
{
	public class CategoryCreateVM
	{
        [Required]
        public string Name { get; set; }
    }
}

