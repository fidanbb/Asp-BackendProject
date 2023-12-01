using System;
namespace BackendProject.Areas.Admin.ViewModels.Customer
{
	public class CustomerVM
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Image { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}

