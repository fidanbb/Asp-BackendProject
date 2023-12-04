using System;
using BackendProject.Areas.Admin.ViewModels.Layout;
using BackendProject.Areas.Admin.ViewModels.Social;

namespace BackendProject.Services.Interfaces
{
	public interface ILayoutService
	{
		Task<HeaderVM> GetHeaderDatas();
		FooterVM GetFooterDatas();
		Task<List<SocialVM>> GetSocialDatas();
	}
}

