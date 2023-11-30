using System;
using BackendProject.Areas.Admin.ViewModels.Tag;

namespace BackendProject.Services.Interfaces
{
	public interface ITagService
	{

		Task<List<TagVM>> GetAllAsync();
	}
}

