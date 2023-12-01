using System;
namespace BackendProject.Areas.Admin.ViewModels.About
{
	public class AboutVM
	{
		public int Id { get; set; }
		public string Image { get; set; }
		public string VideoLink { get; set; }
		public string Description { get; set; }
		public string Title { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}

