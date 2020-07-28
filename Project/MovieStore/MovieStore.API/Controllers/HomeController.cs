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
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public HomeController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetTop25RevenueMovies")]
        public async Task<IActionResult> GetTop25RevenueMovies()
        {
            var movies = await _movieService.GetTop25HiestRevenueMovies();
            var movieDTOs = _mapper.Map<List<MovieDTO>>(movies);
            return Ok(movieDTOs);
        }
    }
}

