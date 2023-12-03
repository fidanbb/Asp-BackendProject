using System;
using BackendProject.Models;

namespace BackendProject.Areas.Admin.ViewModels.Product
{
	public class ProductDetailVM
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public List<ProductImage> Images { get; set; }
    }
}

