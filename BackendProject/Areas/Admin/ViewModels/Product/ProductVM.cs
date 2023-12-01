using System;
using BackendProject.Models;

namespace BackendProject.Areas.Admin.ViewModels.Product
{
	public class ProductVM
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}


