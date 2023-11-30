using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Contact;
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class ContactService:IContactService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly ISettingService _settingService;

        public ContactService(AppDbContext context,
                              IMapper mapper,
                              ISettingService settingService)
        {
            _context = context;
            _mapper = mapper;
            _settingService = settingService;
        }

        public async Task<ContactVM> GetDataAsync()
        {

            ContactInfo contact = await _context.ContactInfos.FirstOrDefaultAsync();

            Dictionary<string, string> settingDatas = _settingService.GetSettings();

            ContactVM model = new()
            {
                Description=contact.Descriptiom,
                Email = settingDatas["Email"],
                Phone = settingDatas["Phone"],
                Address = settingDatas["Address"]
            };

            return model;
        }
    }
}

