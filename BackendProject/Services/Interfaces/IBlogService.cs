using System;
using BackendProject.Areas.Admin.ViewModels.Blog;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackendProject.Services.Interfaces
{
    public interface IBlogService
    {
        Task<List<BlogVM>> GetPaginatedDatasAsync(int page, int take);
        Task<int> GetCountAsync();
        Task<List<BlogVM>> GetByTakeWithImagesAsync(int take);
        Task<BlogDetailVM> GetByIdAsync(int id);
        Task<BlogDetailVM> GetByIdWithoutTracking(int id);
        Task CreateAsync(BlogCreateVM blog);
        Task<BlogVM> GetByNameWithoutTrackingAsync(string name);
    }
}

