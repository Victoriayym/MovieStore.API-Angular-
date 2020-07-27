using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")] //on top of the controller, everything in the controller
    //will have this attribute
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        //we want to construct a URL for showing top 25 revenue movies
        //[Route("api/[controller]")]
        //http:localhost/api/Movies/toprevenue--GET Request
        //SEO, RESTFul URL's, should be human readable
        [HttpGet]
        [Route("toprevenue")]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _movieService.GetTop25HiestRevenueMovies();
            //in MVC we return Views;
            //return data along with the HTTP Status CODE
            //OK--200
            if (!movies.Any())
            {
                return NotFound("No Movies Found!");
            }
            return Ok(movies);
        }
    }
}
