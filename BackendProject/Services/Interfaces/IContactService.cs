using System;
using BackendProject.Areas.Admin.ViewModels.Contact;

namespace BackendProject.Services.Interfaces
{
	public interface IContactService
	{
		Task<ContactVM> GetDataAsync();
		Task<List<ContactMessageVM>> GetAllMessagesAsync();
		Task CreateAsync(ContactMessageCreateVM contact);
		Task DeleteAsync(int id);
		Task<ContactMessageVM> GetMessageByIdWithoutTracking(int id);
		Task<ContactInfoVM> GetInfoAsync();
		Task EditInfoAsync(ContactInfoEditVM contactInfo);
		Task<ContactInfoVM> GetInfoByIdWithoutTracking(int id);

	}
}

