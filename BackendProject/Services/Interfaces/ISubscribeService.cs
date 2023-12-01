using System;
using BackendProject.Areas.Admin.ViewModels.Subscribe;
using BackendProject.Models;

namespace BackendProject.Services.Interfaces
{
	public interface ISubscribeService
    {

        Task<List<SubscribeVM>> GetAllAsync();
        Task DeleteAsync(int id);
        Task CreateAsync(SubscribeCreateVM subscribe);
    }
}

