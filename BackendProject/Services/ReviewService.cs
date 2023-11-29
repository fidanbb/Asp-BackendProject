using System;
using AutoMapper;
using BackendProject.Areas.Admin.ViewModels.Review;
using BackendProject.Data;
using BackendProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Services
{
	public class ReviewService:IReviewService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

		public ReviewService(AppDbContext context,
                             IMapper mapper)
		{
            _context = context;
            _mapper = mapper;
		}

        public async Task<List<ReviewVM>> GetAllWithIncludeAsync()
        {
            return _mapper.Map<List<ReviewVM>>(await _context.Reviews.Include(m=>m.Customer).ToListAsync());
        }
    }
}

