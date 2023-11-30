using System;
using BackendProject.Areas.Admin.ViewModels.About;

namespace BackendProject.Services.Interfaces
{
	public interface IAboutService
	{
		Task<AboutVM> GetDataAsync();
	}
}

