using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
    public class SliderService : ISliderService
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public SliderService(AppDbContext context,
                             IMapper mapper,
                             IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        public async Task CreateAsync(SliderCreateVM slider)
        {
            string fileName = $"{Guid.NewGuid()}-{slider.Photo.FileName}";

            string path = _env.GetFilePath("img/hero", fileName);

            var data = _mapper.Map<Slider>(slider);

            data.Image = fileName;

            await _context.AddAsync(data);

            await _context.SaveChangesAsync();

            await slider.Photo.SaveFileAsync(path);
        }

        public  async Task DeleteAsync(int id)
        {
            Slider slider = await _context.Sliders.Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();

            string path = _env.GetFilePath("img/hero/", slider.Image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public Task EditAsync(SliderEditVM slider)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SliderVM>> GetAllAsync()
        {

            return _mapper.Map<List<SliderVM>>(await _context.Sliders.ToListAsync());
        }

        public async Task<SliderVM> GetByIdWithOutTrackingAsync(int id)
        {
            return _mapper.Map<SliderVM>(await _context.Sliders.AsNoTracking().FirstOrDefaultAsync(m=>m.Id==id));
        }
    }
}

