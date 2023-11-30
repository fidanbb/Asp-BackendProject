using System;
using BackendProject.Areas.Admin.ViewModels.About;
using BackendProject.Areas.Admin.ViewModels.Brand;
using BackendProject.Areas.Admin.ViewModels.Team;

namespace BackendProject.ViewModels
{
	public class AboutPageVM
	{
		public AboutVM About { get; set; }
		public List<TeamVM> Teams { get; set; }
		public List<BrandVM> Brands { get; set; }
	}
}

