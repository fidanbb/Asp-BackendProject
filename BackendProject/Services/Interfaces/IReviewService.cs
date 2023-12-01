using System;
using BackendProject.Areas.Admin.ViewModels.Review;

namespace BackendProject.Services.Interfaces
{
	public interface IReviewService
	{
		Task<List<ReviewVM>> GetAllWithIncludeAsync();
		Task<ReviewVM> GetByIdWithIncludeAsync(int id);
		Task DeleteAsync(int id);
	}
}

