using System;
using BackendProject.Areas.Admin.ViewModels.Contact;

namespace BackendProject.Services.Interfaces
{
	public interface IContactService
	{
		Task<ContactVM> GetDataAsync();

	}
}

