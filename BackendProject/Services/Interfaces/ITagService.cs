using System;
using BackendProject.Areas.Admin.ViewModels.Tag;

namespace BackendProject.Services.Interfaces
{
	public interface ITagService
	{
		Task<List<TagVM>> GetAllAsync();
		Task<TagVM> GetByIdWithoutTrackingAsync(int id);
		Task DeleteAsync(int id);
		Task CreateAsync(TagCreateVM tag);
		Task EditAsync(TagEditVM tag);
	}
}

