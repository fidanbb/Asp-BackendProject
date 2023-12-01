using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Advert
{
	public class AdvertEditVM
	{
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public int DirectionId { get; set; }
        public IFormFile Photo { get; set; }
    }
}

