using System;
using System.Security.Claims;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Layout;
using BackendProject.Areas.Admin.ViewModels.Social;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BackendProject.Services
{
	public class LayoutService:ILayoutService
	{
        private readonly ISettingService _settingService;
        private readonly ISocialService _socialService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(ISettingService settingService,
                             ISocialService socialService,
                             IHttpContextAccessor httpContextAccessor,
                             UserManager<AppUser> userManager)
		{
            _settingService = settingService;
            _socialService = socialService;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

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

        public async Task<HeaderVM> GetHeaderDatas()
        {
            Dictionary<string, string> settingDatas = _settingService.GetSettings();

            HeaderVM model = new HeaderVM();

            model.Logo = settingDatas["HeaderLogo"];

            string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId is not null)
            {
                AppUser currentUser = await _userManager.FindByIdAsync(userId);
                model.UserFullName = currentUser.FullName;
            }



            return model;
        }

        public async Task<List<SocialVM>> GetSocialDatas()
        {
            return await _socialService.GetAllAsync();
        }
    }
}

