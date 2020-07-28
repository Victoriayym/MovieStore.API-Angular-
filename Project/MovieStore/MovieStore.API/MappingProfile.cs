using AutoMapper;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.API
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<MovieGenre, MovieGenreDTO>().ReverseMap();
            CreateMap<MovieCast, MovieCastDTO>().ReverseMap();
            CreateMap<Cast, CastDTO>().ReverseMap();
            CreateMap<Genre, GenreDTO>().ReverseMap();
            CreateMap<Review, ReviewDTO>().ReverseMap();
            CreateMap<Movie, MovieDTO>().ReverseMap();
           
            
        }
    }
}
