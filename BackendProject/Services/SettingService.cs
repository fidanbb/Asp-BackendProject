using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Setting;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class SettingService:ISettingService
	{
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;

        public SettingService(AppDbContext context,
                              IMapper mapper,
                              IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        public Dictionary<string, string> GetSettings()
        {
            return  _context.Settings.AsEnumerable().ToDictionary(m => m.Key, m => m.Value);
        }



        public async Task<List<Setting>> GetAllAsync()
        {
            return await _context.Settings.ToListAsync();
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
            return await _context.Settings.FirstOrDefaultAsync(m => m.Id == id);
        }



        public async Task EditAsync(SettingEditVM setting)
        {
            if (setting.Value.Contains("jpg") || setting.Value.Contains("png") || setting.Value.Contains("jpeg"))
            {
                string oldPath = _env.GetFilePath("img", setting.Value);

                string fileName = $"{Guid.NewGuid()}-{setting.Photo.FileName}";

                string newPath = _env.GetFilePath("img", fileName);

                Setting dbSetting = await _context.Settings.FirstOrDefaultAsync(m => m.Id == setting.Id);

                dbSetting.Value = fileName;

                await _context.SaveChangesAsync();

                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }

                await setting.Photo.SaveFileAsync(newPath);
            }
            else
            {
                Setting dbSetting = await _context.Settings.FirstOrDefaultAsync(m => m.Id == setting.Id);

                _mapper.Map(setting, dbSetting);

                _context.Settings.Update(dbSetting);

                await _context.SaveChangesAsync();
            }

        }

    }
}

