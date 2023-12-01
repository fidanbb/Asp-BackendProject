using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Contact;
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

        public async Task CreateAsync(ContactMessageCreateVM contact)
        {
            var data = _mapper.Map<ContactMessage>(contact);


            await _context.ContactMessages.AddAsync(data);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            ContactMessage dbContactMessage = await _context.ContactMessages.FirstOrDefaultAsync(m => m.Id == id);
            _context.ContactMessages.Remove(dbContactMessage);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ContactMessageVM>> GetAllMessagesAsync()
        {
            return _mapper.Map<List<ContactMessageVM>>(await _context.ContactMessages.ToListAsync());
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

