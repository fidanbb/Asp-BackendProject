using System;
using BackendProject.Areas.Admin.ViewModels.Social;

namespace BackendProject.Services.Interfaces
{
	public interface ISocialService
	{
		Task<List<SocialVM>> GetAllAsync();
	}
}

