﻿using System;
namespace BackendProject.Models
{
	public class Tag:BaseEntity
	{
        public string Name { get; set; }
        public List<BlogTag> BlogTags { get; set; }
    }
}

