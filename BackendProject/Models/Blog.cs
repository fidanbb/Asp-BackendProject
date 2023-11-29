﻿using System;
namespace BackendProject.Models
{
	public class Blog:BaseEntity
	{
        public string Title { get; set; }
        public string Description { get; set; }
        public List<BlogImage> Images { get; set; }
        public List<BlogTag> BlogTags { get; set; }
    }
}

