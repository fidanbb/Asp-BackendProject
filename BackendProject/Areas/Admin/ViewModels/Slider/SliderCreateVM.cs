using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Slider
{
	public class SliderCreateVM
	{
        [Required]
        public IFormFile Photo { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}

