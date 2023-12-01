using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.About;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class AboutService:IAboutService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

		public AboutService(AppDbContext context,
			                IMapper mapper,
                            IWebHostEnvironment env)
		{
			_context = context;
			_mapper = mapper;
            _env = env;
		}

        public async Task<AboutVM> GetDataAsync()
        {
			return _mapper.Map<AboutVM>(await _context.Abouts.FirstOrDefaultAsync());
        }


        public async Task EditAsync(AboutEditVM about)
        {
            string fileName;

            if (about.Photo is not null)
            {
                string oldPath = _env.GetFilePath("img", about.Image);
                fileName = $"{Guid.NewGuid()}-{about.Photo.FileName}";
                string newPath = _env.GetFilePath("img", fileName);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }

                await about.Photo.SaveFileAsync(newPath);

            }
            else
            {
                fileName = about.Image;
            }



            About dbAbout = await _context.Abouts.AsNoTracking().FirstOrDefaultAsync(m => m.Id == about.Id);


            _mapper.Map(about, dbAbout);

            dbAbout.Image = fileName;


            _context.Abouts.Update(dbAbout);

            await _context.SaveChangesAsync();
        }

        public async Task<AboutVM> GetByIdWithoutTrackingAsync(int id)
        {

            return _mapper.Map<AboutVM>(await _context.Abouts.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));
        }

    }
}

