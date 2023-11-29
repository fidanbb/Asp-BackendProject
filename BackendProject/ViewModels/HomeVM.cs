using System;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Areas.Admin.ViewModels.Review;
using BackendProject.Areas.Admin.ViewModels.Slider;

namespace BackendProject.ViewModels
{
	public class HomeVM
	{
		public List<SliderVM> Sliders { get; set; }
		public List<AdvertVM> Adverts { get; set; }
		public List<ReviewVM> Reviews { get; set; }
		public List<ProductVM> Products { get; set; }
	}
}

