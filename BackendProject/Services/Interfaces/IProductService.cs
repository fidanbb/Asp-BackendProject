using System;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Product;

namespace BackendProject.Services.Interfaces
{
	public interface IProductService
	{
		Task<List<ProductVM>> GetByTakeWithIncludes(int take);
		Task<List<ProductVM>> ShowMoreOrLess(int take,int skip);
		Task<int> GetCountAsync();
		Task<List<ProductVM>> GetPaginatedDatasAsync(int page,int take);
		Task<List<ProductVM>> SearchAsync(string searchText);

    }
}

