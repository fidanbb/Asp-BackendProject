using System;
namespace BackendProject.Services.Interfaces
{
	public interface ISettingService
	{
		Dictionary<string, string> GetSettings();
	}
}

