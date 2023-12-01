using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.About
{
	public class AboutEditVM
	{
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
        [Required]
        public string VideoLink { get; set; }
        public string Image { get; set; }
    }
}

