using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Team;
using BackendProject.Data;
using BackendProject.Helpers.Extentions;
using BackendProject.Models;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
    public class TeamService : ITeamService
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public TeamService(AppDbContext context,
                            IMapper mapper,
                            IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        public async Task CreateAsync(TeamCreateVM team)
        {
            string fileName = $"{Guid.NewGuid()}-{team.Photo.FileName}";

            string path = _env.GetFilePath("img/team", fileName);

            var data = _mapper.Map<Team>(team);

            data.Image = fileName;

            await _context.AddAsync(data);

            await _context.SaveChangesAsync();

            await team.Photo.SaveFileAsync(path);
        }

        public async Task DeleteAsync(int id)
        {
            Team team = await _context.Teams.Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();

            string path = _env.GetFilePath("img/team/", team.Image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public Task EditAsync(TeamEditVM team)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TeamVM>> GetAllAsync()
        {
            return _mapper.Map<List<TeamVM>>(await _context.Teams.ToListAsync());
        }

        public async Task<TeamVM> GetByIdWithoutTracking(int id)
        {
            return _mapper.Map<TeamVM>(await _context.Teams.AsNoTracking().FirstOrDefaultAsync(m=>m.Id==id));
        }
    }
}

