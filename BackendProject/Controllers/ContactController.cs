using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Contact;
using BackendProject.Areas.Admin.ViewModels.Social;
using BackendProject.Services.Interfaces;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly ISocialService _socialService;

        public ContactController(IContactService contactService,
                                 ISocialService socialService)
        {
            _contactService = contactService;
            _socialService = socialService;
        }
       
        public async Task<IActionResult> Index()
        {
            List<SocialVM> socials = await _socialService.GetAllAsync();
            ContactVM contact =await  _contactService.GetDataAsync();
            

            ContactPageVM model = new()
            {
                Contact=contact,
                Socials=socials
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateMessage(ContactMessageCreateVM request)
        {

            await _contactService.CreateAsync(request);

            return RedirectToAction("Index","Contact");

        }

    }
}

