using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Layout;
using BackendProject.Areas.Admin.ViewModels.Social;
using BackendProject.Services.Interfaces;

namespace BackendProject.Services
{
	public class LayoutService:ILayoutService
	{
        private readonly ISettingService _settingService;
        private readonly ISocialService _socialService;

		public LayoutService(ISettingService settingService,
                             ISocialService socialService)
		{
            _settingService = settingService;
            _socialService = socialService;

		}

        public FooterVM GetFooterDatas()
        {
            Dictionary<string, string> settingDatas = _settingService.GetSettings();

            return new FooterVM()
            {
                Logo = settingDatas["FooterLogo"],
                Email = settingDatas["Email"],
                Phone = settingDatas["Phone"],
                Eax = settingDatas["Eax"],
                Address = settingDatas["Address"]

            };
        }

        public HeaderVM GetHeaderDatas()
        {
            Dictionary<string, string> settingDatas = _settingService.GetSettings();

            return new HeaderVM()
            {
                Logo = settingDatas["HeaderLogo"]
            };
        }

        public async Task<List<SocialVM>> GetSocialDatas()
        {
            return await _socialService.GetAllAsync();
        }
    }
}

