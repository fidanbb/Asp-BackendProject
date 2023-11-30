using System;
using BackendProject.Models;

namespace BackendProject.Areas.Admin.ViewModels.Blog
{
	public class BlogDetailVM
	{
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public List<BlogImage> Images { get; set; }
        //public List<Tag> Tags { get; set; }
    }
}

