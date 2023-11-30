using System;
using BackendProject.Areas.Admin.ViewModels.Brand;

namespace BackendProject.Services.Interfaces
{
	public interface IBrandService
	{
		Task<List<BrandVM>> GetAllAsync();
	}
}

