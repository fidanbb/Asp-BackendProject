﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Tag
{
	public class TagEditVM
	{
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

