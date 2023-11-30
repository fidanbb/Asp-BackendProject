using System;
using BackendProject.Areas.Admin.ViewModels.Team;

namespace BackendProject.Services.Interfaces
{
	public interface ITeamService
	{
		Task<List<TeamVM>> GetAllAsync();
	}
}

