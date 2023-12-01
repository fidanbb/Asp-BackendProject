using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Contact
{
	public class ContactInfoEditVM
	{
        public int Id { get; set; }
        [Required]
        public string Descriptiom { get; set; }

    }
}

