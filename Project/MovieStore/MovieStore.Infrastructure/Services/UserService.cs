using Microsoft.EntityFrameworkCore;
using MovieStore.Core.Entities;
using MovieStore.Core.Models.Request;
using MovieStore.Core.Models.Response;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Core.ServiceInterfaces;
using MovieStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MovieStore.Infrastructure.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICryptoService _cryptoService;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IMovieService _movieService;
        private readonly MovieStoreDbContext _dbContext;
        private readonly IFavoriteRepository _favoriteRepository;


        public UserService(IUserRepository userRepository, ICryptoService cryptoService, 
            IPurchaseRepository purchaseRepository, IMovieService movieService,
            MovieStoreDbContext dbContext, IFavoriteRepository favoriteRepository)
        {
            _userRepository = userRepository;
            _cryptoService = cryptoService;
            _purchaseRepository = purchaseRepository;
            _movieService = movieService;
            _dbContext = dbContext;
            _favoriteRepository = favoriteRepository;
        }
        public async Task<UserRegisterReposnseModel> RegisterUser(UserRegisterRequestModel requestModel)
        {
            //1.Step 1: Check whether this user already existed in the database;
            var dbUser = await _userRepository.GetUserByEmail(requestModel.Email);
            if (dbUser != null)
            {
                throw new Exception("User already registered, please login in");
            }
            // Step 2 : lets Generate a random unique Salt
            var salt = _cryptoService.GenerateSalt();
            // Never ever craete your own Hashing Algorithm, always use Industry tested/tried Hashing Algorithm
            // Step 3: we hash the password with the salt created in the above step
            var hashedPassword = _cryptoService.HashPassword(requestModel.Password, salt);
            // create User object so that we can save it to User Table
            var user = new User
            {
                Email = requestModel.Email,
                Salt = salt,
                HashedPassword = hashedPassword,
                FirstName = requestModel.FirstName,
                LastName = requestModel.LastName
            };
            // Step 4: Save it to Database
            var createdUser = await _userRepository.AddAsync(user);
            var response = new UserRegisterReposnseModel
            {
                Id = createdUser.Id,
                Email = createdUser.Email,
                FirstName = createdUser.FirstName,
                LastName = createdUser.LastName
            };
            return response;
        }

        public async Task<UserLoginReponseModel> ValidateUser(string email, string password)
        {
            //1.Get user record from the database by email;
            var user = await _userRepository.GetUserByEmail(email);
            if (user == null)
            {
                //user does not even exists
                throw new Exception("Register first, user does not exisit");
            }
            //2. we need to hash the password that user entered in the page with Salt from the database
            var hashedPassword = _cryptoService.HashPassword(password, user.Salt);
            //3. compare the database hashed password with Hashed password generated in step 2

            if (hashedPassword == user.HashedPassword)
            {
                //user entered right password
                //send some user details
                var response = new UserLoginReponseModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DateOfBirth = user.DateOfBirth,
                    Email = user.Email
                };
                return response;
            }
            return null;
        }

        public async Task Purchase(PurchaseRequestModel purchaseRequestModel)
        {
            var movie = await _movieService.GetMovieById(purchaseRequestModel.MovieId);
            var purchase = new Purchase
            {
                UserId= purchaseRequestModel.UserId,
                MovieId = movie.Id,
                TotalPrice = movie.Price.Value,
                PurchaseNumber=purchaseRequestModel.PurchaseNumber,
                PurchaseDateTime=purchaseRequestModel.PurchaseDateTime.Value
            };
            await _purchaseRepository.AddAsync(purchase); 
        }

        public async Task<IEnumerable<Movie>> PurchasedMovies(int userId)
        {
            var movies = await _dbContext.Purchases.Include(p=>p.Movie).Where(p=>p.UserId==userId).Select(p=>p.Movie).ToListAsync();
            return movies;
        }

        public async Task<bool> IsMoviePurchased(int userId, int movieId)
        {
            return await _purchaseRepository.GetExistsAsync(p =>
                p.UserId == userId && p.MovieId == movieId);
        }
        public async Task<Review> SaveReview(Review review)
        {
            var movie= await _movieService.GetMovieById(review.MovieId);
            var reviewContent = new Review
            {
                MovieId = movie.Id,
                UserId = review.UserId,
                Rating = review.Rating,
                ReviewText=review.ReviewText
            };
            await _dbContext.Reviews.AddAsync(reviewContent);
            return review;
        }
        public async Task<IEnumerable<Review>> ReviewListbyUser(int userId)
        {
            var reviews = await _dbContext.Reviews.Where(r => r.UserId == userId).ToListAsync();
 
            return reviews;
        }

        public async Task Favorite(FavoriteRequestModel favoriteRequestModel)
        {
            var movie = await _movieService.GetMovieById(favoriteRequestModel.MovieId);
            var favoriteMovie = new Favorite
            {
                MovieId = movie.Id,
                UserId = favoriteRequestModel.UserId
            };

            await _favoriteRepository.AddAsync(favoriteMovie);
            
        }

        public async Task<bool> IsFavorited(int id, int movieId)
        {
            return await _favoriteRepository.GetExistsAsync(f => f.MovieId == movieId &&
                                                                 f.UserId == id);
        }

        public async Task RemoveFavorite(FavoriteRequestModel favoriteRequest)
        {
            var favoriteMovie =
                await _favoriteRepository.ListAsync(r => r.UserId == favoriteRequest.UserId &&
                                                         r.MovieId == favoriteRequest.MovieId);
            await _favoriteRepository.DeleteAsync(favoriteMovie.First());
        }
    }
}



















