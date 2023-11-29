using System;
using BackendProject.Areas.Admin.ViewModels.Slider;

namespace BackendProject.Services.Interfaces
{
	public interface ISliderService
	{
		Task<List<SliderVM>> GetAllAsync();
	}
}

