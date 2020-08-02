using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;
using MovieStore.Core.ServiceInterfaces;


namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")] //on top of the controller, everything in the controller
    //will have this attribute
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        public MoviesController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
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
        [HttpGet]
        [Route("genre/{genreId:int}")]
        public async Task<IActionResult> GetMoviesByGenre(int genreId)
        {
            var movies = await _movieService.GetMovieByGenre(genreId);
            var movieDTOs = _mapper.Map<List<MovieDTO>>(movies);
            return Ok(movieDTOs);
        }
        [HttpGet]
        [Route("movie/{movieId:int}")]
        public async Task<IActionResult> GetMovieById(int movieId)
        {
            var movie = await _movieService.GetMovieById(movieId);
            var movieDTO = _mapper.Map<MovieDTO>(movie);
            var genres = movie.MovieGenres.Select(g=>g.Genre).ToList();
            var casts = movie.MovieCasts.Select(c => c.Cast).ToList();
            movieDTO.Genres = _mapper.Map<List<GenreDTO>>(genres);
            movieDTO.Casts = _mapper.Map<List<CastDTO>>(casts);
            if (movie.Reviews.Any())
            {
                movieDTO.Rating = movie.Reviews.Average(r => r.Rating);
            }
            return Ok(movieDTO);
        }

        [HttpGet]
        [Route("toprated")]
        public async Task<IActionResult> TopRated()
        {
            var movies = await _movieService.GetTop25RatedMovies();
            return Ok(movies);
        }
    }
}
