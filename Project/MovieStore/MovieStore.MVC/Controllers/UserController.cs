using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Models.Request;
using MovieStore.Core.ServiceInterfaces;
using MovieStore.Core.Entities;
using MovieStore.Core.RepositoryInterfaces;
using Microsoft.AspNetCore.Authorization;

namespace MovieStore.MVC.Controllers
{
    // 1.  Purchase a Movie, HttpPost, store that info in the Purchase table
    // http:localhost:12112/User/Purchase -- HttpPost
    //purchase action result
    // first check whether the user already bought that movie
    // BUY Buuton in the Movie Details Page will call the above method
    // if user already bought that movie, then replace Buy button with Watch Movie button
    // 2. Get all the Movies Purchased by user, loged in User, take userid from HttpContext and get all the movies
    // and give them to Movie Card partial view
    // http:localhost:12112/User/Purchases -- HttpGet
    // 3. Create a Review for a Movie for Loged In user , take userid from HttpContext and save info in Review Table
    // http:localhost:12112/User/review -- HttpPost
    // Review Button will open a popup and ask user to enter a small review in textarea and have him enter
    // movie rating between 1 and 10 and then save
    // 4. Get all the Reviews done my loged in User,
    // http:localhost:12112/User/reviews -- HttpGet
    // 5. Add a Favorite Movie for Loged In User
    // http:localhost:12112/User/Favorite -- HttpPost
    // add another button called favorite, same conecpt as Purchase
    // FontAweomse libbary and use buttons from there
    // 6.Check if a particular Movie has been added as Favorite by logedin user
    // http:localhost:12112/User/{123}/movie/{12}/favorite  HttpGet
    // 7. Remove favorite
    // http:localhost:12112/User/Favorite -- Httpdelete
    [Authorize]
    public class UserController : Controller
    { 
        
        private readonly IMovieService _movieService;
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;

        public UserController(IUserService userService, IMovieService movieService, IUserRepository userRepository)
        {
            _userService = userService;
            _movieService = movieService;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Purchase(PurchaseRequestModel purchaseRequestModel)
        {
            purchaseRequestModel.UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            await _userService.Purchase(purchaseRequestModel);
           
            return LocalRedirect("~/");
        }

        [HttpGet]
        public async Task<IActionResult> Purchases()
        {
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var movies = await _userService.PurchasedMovies(userId);
            return View(movies);
        }
        
        [HttpPost]
        public async Task<ActionResult> Review(Review review)
        {
            review.UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            
            await _userService.SaveReview(review);

            return LocalRedirect("~/");
        }

       [HttpGet]
        public async Task<ActionResult> Reviews()
        {
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var reviews = await _userService.ReviewListbyUser(userId);
            return View(reviews);
        }

        [HttpPost]
        public async Task<IActionResult> Favorite(FavoriteRequestModel favoriteRequestModel)
        {
            favoriteRequestModel.UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            await _userService.Favorite(favoriteRequestModel);

            return LocalRedirect("~/");
        }
        //Filters in ASP.NET
        //Some piece of code that runs either before a controller or action method executes or when some event happens
        //that runs before or after specific stages in the http pipeline
        //1.Authorization
        //2.Action Filter
        //3.Result Filter
        //4.Exception filter, but in real world we used Exception middleware to cach exception
        //5.Resource filter
        [HttpGet]
        public async Task<IActionResult> CheckFavorite(FavoriteRequestModel favoriteRequestModel)
        {
            var movie = await _movieService.GetMovieById(favoriteRequestModel.MovieId);
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            ViewBag.Favorited = false;
            if (user != null && !string.IsNullOrWhiteSpace(user.Value))
            {
                ViewBag.Favorited = await _userService.IsFavorited(int.Parse(user.Value), movie.Id);
            }
            return View();

            //favoriteRequestModel.UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            //bool result= await _userService.IsFavorited(favoriteRequestModel.UserId, favoriteRequestModel.MovieId);
            //if (result == true)
            //{
            //    return View();
            //}
            //else
            //{
            //    return LocalRedirect("~/");
            //}
            
        }

    }
}
