using MovieStore.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MovieStore.Infrastructure;
using MovieStore.Core.Entities;
using System.Threading.Tasks;
using MovieStore.Infrastructure.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MovieStore.Infrastructure.Repositories
{
    public class MovieRepository : ERepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieStoreDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<IEnumerable<Movie>> GetHighestRevenueMovies()
        {
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(25).ToListAsync();
            // select top 25 from Movies order by Revenue desc;
            return movies;
        }
    }
}
