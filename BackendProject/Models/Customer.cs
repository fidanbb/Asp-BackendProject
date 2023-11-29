using System;
namespace BackendProject.Models
{
	public class Customer:BaseEntity
	{
		public string Image { get; set; }
		public string FullName { get; set; }
		public List<Review> Reviews { get; set; }
	}
}

