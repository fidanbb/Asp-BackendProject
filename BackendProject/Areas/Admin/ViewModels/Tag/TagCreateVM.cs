using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Tag
{
	public class TagCreateVM
	{
        [Required]
        public string Name { get; set; }
    }
}

