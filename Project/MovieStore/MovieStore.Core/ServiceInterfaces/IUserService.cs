using MovieStore.Core.Models.Request;
using MovieStore.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieStore.Core.Entities;

namespace MovieStore.Core.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserRegisterReposnseModel> RegisterUser(UserRegisterRequestModel requestModel);

        Task<UserLoginReponseModel> ValidateUser(string email, string password);

        Task Purchase(PurchaseRequestModel purchaseRequestModel);

        Task<IEnumerable<Movie>> PurchasedMovies(int userId);

        Task<IEnumerable<Review>> ReviewListbyUser(int userId);

        Task<Review> SaveReview(Review review);

        Task Favorite(FavoriteRequestModel favoriteRequestModel);

        Task<bool> IsMoviePurchased(int userId, int movieId);

        Task<bool> IsFavorited(int id, int movieId);

        Task RemoveFavorite(FavoriteRequestModel favoriteRequest);
    }
}
