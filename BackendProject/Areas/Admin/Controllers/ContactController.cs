using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.Admin.ViewModels.Brand;
using BackendProject.Areas.Admin.ViewModels.Contact;
using BackendProject.Services;
using BackendProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> MessageIndex()
        {
            return View(await _contactService.GetAllMessagesAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _contactService.DeleteAsync(id);
            return RedirectToAction(nameof(MessageIndex));
        }


        [HttpGet]
        public async Task<IActionResult> MessageDetail(int? id)
        {
            if (id is null) return BadRequest();

            ContactMessageVM dbMessage = await _contactService.GetByIdWithoutTracking((int)id);

            if (dbMessage is null) return NotFound();

            return View(dbMessage);
        }


    }
}

