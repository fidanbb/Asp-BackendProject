using System;
using BackendProject.Areas.Admin.ViewModels.Setting;
using BackendProject.Models;

namespace BackendProject.Services.Interfaces
{
	public interface ISettingService
	{
		Dictionary<string, string> GetSettings();

        Task<List<Setting>> GetAllAsync();

        Task<Setting> GetByIdAsync(int id);
        Task EditAsync(SettingEditVM setting);
    }
}

