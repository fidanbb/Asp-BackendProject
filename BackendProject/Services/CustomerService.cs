using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Areas.Admin.ViewModels.Customer;
using BackendProject.Areas.Admin.ViewModels.Review;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class CustomerService:ICustomerService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public CustomerService(AppDbContext context,
                             IMapper mapper,
                             IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        public async Task DeleteAsync(int id)
        {
            Customer customer = await _context.Customers.Where(m => m.Id == id).Include(m=>m.Reviews).FirstOrDefaultAsync();
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            string path = _env.GetFilePath("img/testimonial", customer.Image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }


        }

        public async Task<List<CustomerVM>> GetAllAsync()
        {
            return _mapper.Map<List<CustomerVM>>(await _context.Customers.ToListAsync());
        }

        public async Task<CustomerVM> GetByIdAsync(int id)
        {
            return _mapper.Map<CustomerVM>(await _context.Customers.FirstOrDefaultAsync(m => m.Id == id));
        }
    }
}

