using MovieStore.Core.Entities;
using MovieStore.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Infrastructure.Services
{
    public class GenreService : IGenreService
    {
        Task<IEnumerable<Genre>> IGenreService.GetAllGenres()
        {
            throw new NotImplementedException();
        }
    }
}
