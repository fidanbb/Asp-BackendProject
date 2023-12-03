﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Areas.Admin.ViewModels.Setting
{
	public class SettingEditVM
	{
        public int Id { get; set; }
        public string Key { get; set; }
        [Required]
        public string Value { get; set; }
        public IFormFile Photo { get; set; }
    }
}

