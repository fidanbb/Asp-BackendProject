using System;
using BackendProject.Areas.Admin.ViewModels.Slider;

namespace BackendProject.Services.Interfaces
{
	public interface ISliderService
	{
		Task<List<SliderVM>> GetAllAsync();
		Task<SliderVM> GetByIdWithOutTrackingAsync(int id);
		Task CreateAsync(SliderCreateVM slider);
		Task EditAsync(SliderEditVM slider);
		Task DeleteAsync(int id);
	}
}

