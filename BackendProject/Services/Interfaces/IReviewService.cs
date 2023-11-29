using System;
using BackendProject.Areas.Admin.ViewModels.Review;

namespace BackendProject.Services.Interfaces
{
	public interface IReviewService
	{
		Task<List<ReviewVM>> GetAllWithIncludeAsync();
	}
}

