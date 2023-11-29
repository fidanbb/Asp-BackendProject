using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Slider;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
    public class SliderService : ISliderService
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SliderService(AppDbContext context,
                             IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SliderVM>> GetAllAsync()
        {

            return _mapper.Map<List<SliderVM>>(await _context.Sliders.ToListAsync());
        }
    }
}

