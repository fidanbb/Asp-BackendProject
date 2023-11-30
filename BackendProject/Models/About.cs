using System;
namespace BackendProject.Models
{
	public class About:BaseEntity
	{
		public string Image { get; set; }
		public string VideoLink { get; set; }
		public string Description { get; set; }
		public string Title { get; set; }
	}
}

