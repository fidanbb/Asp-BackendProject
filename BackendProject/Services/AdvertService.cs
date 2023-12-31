﻿using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Advert;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class AdvertService:IAdvertService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

		public AdvertService(AppDbContext context,
			                 IMapper mapper,
                             IWebHostEnvironment env)
		{
			_context = context;
			_mapper = mapper;
            _env = env;
		}

        public async Task CreateAsync(AdvertCreateVM advert)
        {
            string fileName = $"{Guid.NewGuid()}-{advert.Photo.FileName}";

            string path = _env.GetFilePath("img/banner", fileName);

            var data = _mapper.Map<Advert>(advert);

            data.Image = fileName;

            await _context.Adverts.AddAsync(data);
            await _context.SaveChangesAsync();

            await advert.Photo.SaveFileAsync(path);
        }

        public async Task DeleteAsync(int id)
        {
            Advert advert = await _context.Adverts.Where(m => m.Id == id).FirstOrDefaultAsync();

            _context.Adverts.Remove(advert);
            await _context.SaveChangesAsync();

            string path = _env.GetFilePath("img/banner", advert.Image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task EditAsync(AdvertEditVM advert)
        {
            string fileName;

            if (advert.Photo is not null)
            {
                string oldPath = _env.GetFilePath("img/banner", advert.Image);
                fileName = $"{Guid.NewGuid()}-{advert.Photo.FileName}";
                string newPath = _env.GetFilePath("img/banner", fileName);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }

                await advert.Photo.SaveFileAsync(newPath);

            }
            else
            {
                fileName = advert.Image;
            }



            Advert dbAdvert = await _context.Adverts.AsNoTracking().FirstOrDefaultAsync(m => m.Id == advert.Id);


            _mapper.Map(advert, dbAdvert);

            dbAdvert.Image = fileName;


            _context.Adverts.Update(dbAdvert);

            await _context.SaveChangesAsync();
        }

        public async Task<List<AdvertVM>> GetAllWithIncludeAsync()
        {
			return _mapper.Map<List<AdvertVM>>(await _context.Adverts.Include(m => m.Direction).ToListAsync());
        }

        public async Task<List<AdvertVM>> GetAllWithIncludeByTakeAsync(int take)
        {
            return _mapper.Map<List<AdvertVM>>(await _context.Adverts.Take(take)
                                                                     .Include(m => m.Direction)
                                                                     .ToListAsync());
        }

        public async Task<AdvertVM> GetByIdWithIncludeAsync(int id)
        {
			return _mapper.Map<AdvertVM>(await _context.Adverts.Where(m=>m.Id==id)
				                                               .Include(m=>m.Direction)
															   .FirstOrDefaultAsync());
        }

        public async Task<AdvertVM> GetByIdWithoutTracking(int id)
        {
            return _mapper.Map<AdvertVM>(await _context.Adverts.AsNoTracking().FirstOrDefaultAsync(m=>m.Id==id));


        }
    }
}

