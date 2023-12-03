using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.About;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Blog;
using BackendProject.Areas.Admin.ViewModels.Brand;
using BackendProject.Areas.Admin.ViewModels.Category;
using BackendProject.Areas.Admin.ViewModels.Contact;
using BackendProject.Areas.Admin.ViewModels.Customer;
using BackendProject.Areas.Admin.ViewModels.Product;
using BackendProject.Areas.Admin.ViewModels.Review;
using BackendProject.Areas.Admin.ViewModels.Setting;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Areas.Admin.ViewModels.Social;
using BackendProject.Areas.Admin.ViewModels.Subscribe;
using BackendProject.Areas.Admin.ViewModels.Tag;
using BackendProject.Areas.Admin.ViewModels.Team;
using BackendProject.Models;
using BackendProject.ViewModels;

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

            CreateMap<Blog, BlogVM>().ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Images.FirstOrDefault(m => m.IsMain).Image))
                                     .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.BlogTags.Select(m => m.Tag).ToList()));

            CreateMap<Tag, TagVM>();
            CreateMap<Blog, BlogDetailVM>().ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.BlogTags.Select(m=>m.Tag).ToList()));

            CreateMap<Brand, BrandVM>();
            CreateMap<About, AboutVM>();
            CreateMap<Team, TeamVM>();
            CreateMap<Social, SocialVM>();
            CreateMap<ContactInfo, ContactVM>();
            CreateMap<Direction, DirectionVM>();
            CreateMap<AdvertCreateVM, Advert>();
            CreateMap<AdvertVM, AdvertEditVM>();
            CreateMap<AdvertEditVM, Advert>();
            CreateMap<SliderCreateVM, Slider>();
            CreateMap<SliderEditVM, Slider>();
            CreateMap<SliderVM, SliderEditVM>();
            CreateMap<TeamCreateVM, Team>();
            CreateMap<TeamEditVM, Team>();
            CreateMap<TeamVM, TeamEditVM>();
            CreateMap<ContactMessage, ContactMessageVM>();
            CreateMap<ContactMessageCreateVM, ContactMessage>();
            CreateMap<Subscribe, SubscribeVM>();
            CreateMap<SubscribeCreateVM, Subscribe>();
            CreateMap<ContactInfo, ContactInfoVM>();
            CreateMap<ContactInfoEditVM, ContactInfo>();
            CreateMap<AboutEditVM, About>();
            CreateMap<AboutVM, AboutEditVM>();
            CreateMap<Customer, CustomerVM>();
            CreateMap<TagCreateVM, Tag>();
            CreateMap<TagEditVM, Tag>();
            CreateMap<Category, CategoryVM>();
            CreateMap<CategoryEditVM, Category>();
            CreateMap<CategoryCreateVM, Category>();
            CreateMap<Product, ProductDetailVM>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                              .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images));

            CreateMap<Product, ProductEditVM>();

            CreateMap<ProductEditVM, Product>();

            CreateMap<Blog, BlogEditVM>().ReverseMap();
            CreateMap<Blog, BlogCreateVM>().ReverseMap();
            CreateMap<Setting, SettingEditVM>().ReverseMap();




        }
    }
}

