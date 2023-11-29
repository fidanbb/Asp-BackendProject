using System;
using BackendProject.Areas.Admin.ViewModels.Layout;

namespace BackendProject.Services.Interfaces
{
	public interface ILayoutService
	{
		HeaderVM GetHeaderDatas();
		FooterVM GetFooterDatas();
	}
}

