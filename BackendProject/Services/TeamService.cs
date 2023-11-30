using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Team;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
    public class TeamService : ITeamService
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TeamService(AppDbContext context,
                            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<TeamVM>> GetAllAsync()
        {
            return _mapper.Map<List<TeamVM>>(await _context.Teams.ToListAsync());
        }
    }
}

