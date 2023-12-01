using System;
using BackendProject.Areas.Admin.ViewModels.Customer;

namespace BackendProject.Services.Interfaces
{
	public interface ICustomerService
	{
        Task<List<CustomerVM>> GetAllAsync();
        Task<CustomerVM> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}

