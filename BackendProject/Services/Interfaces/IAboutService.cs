using System;
using BackendProject.Areas.Admin.ViewModels.About;

namespace BackendProject.Services.Interfaces
{
	public interface IAboutService
	{
		Task<AboutVM> GetDataAsync();
        Task<AboutVM> GetByIdWithoutTrackingAsync(int id);
        Task EditAsync(AboutEditVM about);
    }
}

