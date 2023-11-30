using System;
using BackendProject.ViewModels;

namespace BackendProject.Services.Interfaces
{
	public interface IDirectionService
	{
		Task<List<DirectionVM>> GetAllAsync();
	}
}

