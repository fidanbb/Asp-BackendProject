using System;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Tag;
using BackendProject.Helpers;

namespace BackendProject.ViewModels
{
	public class BlogPageVM
	{
		public Paginate<BlogVM> PaginatedDatas { get; set; }
		public List<TagVM> Tags { get; set; }
	}
}

