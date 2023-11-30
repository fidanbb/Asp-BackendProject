using System;
using BackendProject.Areas.Admin.ViewModels.Advert;

namespace BackendProject.Services.Interfaces
{
	public interface IAdvertService
	{
		Task<List<AdvertVM>> GetAllWithIncludeAsync();
        Task<List<AdvertVM>> GetAllWithIncludeByTakeAsync(int take);
        Task<AdvertVM> GetByIdWithIncludeAsync(int id);
		Task CreateAsync(AdvertCreateVM advert);
		Task DeleteAsync(int id);
	}
}

