﻿using System;
namespace BackendProject.Areas.Admin.ViewModels.Contact
{
	public class ContactVM
	{
		public string Descriptiom { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

