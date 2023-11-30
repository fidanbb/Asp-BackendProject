using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Areas.Admin.ViewModels.Review;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Areas.Admin.ViewModels.Tag;
using BackendProject.Models;

namespace BackendProject.Helpers.Mappings
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<Slider, SliderVM>();
            CreateMap<Advert, AdvertVM>().ForMember(dest => dest.Direction, opt => opt.MapFrom(src => src.Direction.Name));

			CreateMap<Review, ReviewVM>().ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Customer.FullName))
										 .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Customer.Image));

            CreateMap<Product, ProductVM>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                                           .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Images.FirstOrDefault(m => m.IsMain).Image));

            CreateMap<Blog, BlogVM>().ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Images.FirstOrDefault(m => m.IsMain).Image));

            CreateMap<Tag, TagVM>();
            CreateMap<Blog, BlogDetailVM>().ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.BlogTags.Select(m=>m.Tag).ToList()));

        }
    }
}

