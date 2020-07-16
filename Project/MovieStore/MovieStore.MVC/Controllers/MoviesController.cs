using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.ServiceInterfaces;
using MovieStore.MVC.Models;
using MovieStore.Infrastructure.Services;

namespace MovieStore.MVC.Controllers
{
  
    public class MoviesController : Controller
    {
        //interview question
        //IOC, ASP.NET Core has built-in IOC/DI
        //In .NET Framework we need to reply on third-party IOC to do the Dependency Injection
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        //GET localhost/Movies/index
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            //call our Movie Service method, highest grossing method
            var movies = await _movieService.GetTop25HiestRevenueMovies();
            
            //var movies = new List<Movie>
            //{
            //    new Movie {Id = 1, Title = "Avengers: Infinity War", Budget = 1200000},
            //    new Movie {Id = 2, Title = "Avatar", Budget = 1200000},
            //    new Movie {Id = 3, Title = "Star Wars: The Force Awakens", Budget = 1200000},
            //    new Movie {Id = 4, Title = "Titanic", Budget = 1200000},
            //    new Movie {Id = 5, Title = "Inception", Budget = 1200000},
            //    new Movie {Id = 6, Title = "Avengers: Age of Ultron", Budget = 1200000},
            //    new Movie {Id = 7, Title = "Interstellar", Budget = 1200000},
            //    new Movie {Id = 8, Title = "Fight Club", Budget = 1200000},
            //};
            //ViewBag.MoviesCount = movies.Count;
            //ViewData["myname"] = "John Doe";
            //using data strongly type to send data from controller to view
            //compile time check vs run time check;
            //go to the databse and get some list of movies and give it to the view
            //we need to pass data from controller action method to the view
            //usually its preferred to send a strongly typed model or object
            //3 ways to send data from controller to view:
            //1.strongly typed models(preferred way)
            //2.ViewBag-dynamic
            //3.ViewData-key/value
            return View();
        }
        [HttpPost]
        public IActionResult Create(string title, decimal budget, string TITLE, string tite)
        {
            //POST//http:localhost/Movies/create
            //interview question: model binding
            //whatever is post to the server, as long as the parameter name is the same,
            //then it will take the value to the attribute, they are case-insensitive
            //look at the incoming request and maps the input fields name with the paramter 
            //names of the action method, then the paramter will have the value automatically
            //it will also do casting/converting
            //we need to get the data from view and save it in database
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            //http:localhost/Movies/create
            //we need to have this method so that we can show the empty page for user to enter movie 
            //information that need to be created
            return View();
        }
    }
}
