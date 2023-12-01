using System;
using BackendProject.Areas.Admin.ViewModels.Team;

namespace BackendProject.Services.Interfaces
{
	public interface ITeamService
	{
		Task<List<TeamVM>> GetAllAsync();
		Task<TeamVM> GetByIdWithoutTrackingAsync(int id);
		Task DeleteAsync(int id);
		Task CreateAsync(TeamCreateVM team);
		Task EditAsync(TeamEditVM team);
	}
}

