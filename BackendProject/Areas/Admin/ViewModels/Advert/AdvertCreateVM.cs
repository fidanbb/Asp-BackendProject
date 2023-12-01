using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Advert
{
	public class AdvertCreateVM
	{
        [Required]
        public IFormFile Photo { get; set; }
        [Required]
        public string Description { get; set; }
        public int DirectionId { get; set; }
    }
}

