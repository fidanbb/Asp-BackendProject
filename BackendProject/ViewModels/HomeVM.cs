﻿using System;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Areas.Admin.ViewModels.Review;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Areas.Admin.ViewModels.Subscribe;

namespace BackendProject.ViewModels
{
	public class HomeVM
	{
		public List<SliderVM> Sliders { get; set; }
		public List<AdvertVM> Adverts { get; set; }
		public List<ReviewVM> Reviews { get; set; }
		public List<ProductVM> Products { get; set; }
		public List<BlogVM> Blogs { get; set; }
        public SubscribeCreateVM Subscribe { get; set; }
    }
}

