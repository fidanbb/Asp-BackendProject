using System;
using BackendProject.Areas.Admin.ViewModels.Advert;

namespace BackendProject.Services.Interfaces
{
	public interface IAdvertService
	{
		Task<List<AdvertVM>> GetAllWithIncludeAsync();
	}
}

