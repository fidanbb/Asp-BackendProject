using System;
using BackendProject.Models;
using BackendProject.ViewModels.Wishlist;

namespace BackendProject.Services.Interfaces
{
	public interface IWishlistService
	{
        void SetDatasToCookie(List<WishlistVM> wishlists, Product dbProduct, WishlistVM existProduct);
        void DeleteData(int? id);
        Task<List<WishlistProduct>> GetAllByWishlistIdAsync(int? wishlistId);
        Task<Wishlist> GetByUserIdAsync(string userId);
        List<WishlistVM> GetDatasFromCookie();

    }
}

