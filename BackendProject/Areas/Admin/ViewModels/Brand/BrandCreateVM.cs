using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Brand
{
	public class BrandCreateVM
	{
        [Required]
        public List<IFormFile> Photos { get; set; }
    }
}


