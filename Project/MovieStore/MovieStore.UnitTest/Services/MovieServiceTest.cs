using System;
using System.Collections.Generic;
using NUnit.Framework;
using MovieStore.Infrastructure.Services;
using System.Threading.Tasks;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Core.Entities;
using System.Linq;
using Moq;

namespace MovieStore.UnitTest.Services
{
    [TestFixture] //Its a test class now
    public class MovieServiceTest
    {
        //sut: system under test
        private MovieService _sut;
        private Mock<IMovieRepository> _mockMovieRepository;
        private List<Movie> _movies;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _movies = new List<Movie> {
            new Movie {Id = 1, Title = "Avengers: Infinity War", Budget = 1200000},
            new Movie {Id = 2, Title = "Avatar", Budget = 1200000},
            new Movie {Id = 3, Title = "Star Wars: The Force Awakens", Budget = 1200000},
            new Movie {Id = 4, Title = "Titanic", Budget = 1200000},
            new Movie {Id = 5, Title = "Inception", Budget = 1200000},
            new Movie {Id = 6, Title = "Avengers: Age of Ultron", Budget = 1200000},
            new Movie {Id = 7, Title = "Interstellar", Budget = 1200000},
            new Movie {Id = 8, Title = "Fight Club", Budget = 1200000},
            new Movie{
                       Id = 9, Title = "The Lord of the Rings: The Fellowship of the Ring", Budget = 1200000
                          },
            new Movie {Id = 10, Title = "The Dark Knight", Budget = 1200000},
            new Movie {Id = 11, Title = "The Hunger Games", Budget = 1200000},
            new Movie {Id = 12, Title = "Django Unchained", Budget = 1200000},
            new Movie{
                       Id = 13, Title = "The Lord of the Rings: The Return of the King", Budget = 1200000},
                          new Movie {Id = 14, Title = "Harry Potter and the Philosopher's Stone", Budget = 1200000},
                          new Movie {Id = 15, Title = "Iron Man", Budget = 1200000},
                          new Movie {Id = 16, Title = "Furious 7", Budget = 1200000}
            };
        }
        [SetUp]
        public void SetUp()
        {
            _mockMovieRepository = new Mock<IMovieRepository>();
            _mockMovieRepository.Setup(m => m.GetHighestRevenueMovies()).ReturnsAsync(_movies);
            _mockMovieRepository.Setup(m => m.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((int m) => _movies.First(x => x.Id == m));
        }

        [Test]
        public async Task Test_Movie_Name_By_GivenMovie_Id()
        {
            _sut = new MovieService(_mockMovieRepository.Object);
            var movie = await _sut.GetMovieById(10);
            Assert.AreEqual("The Dark Knight", movie.Title);
        }

        [Test]
        public async Task Test_MovieId_FromFakeData_That_does_not_exist()
        {
            _sut = new MovieService(_mockMovieRepository.Object);
            //we can even check for any known and unknown exception
            var movie = await _sut.GetMovieById(20);
            Assert.ThrowsAsync<InvalidOperationException>(async () => await _sut.GetMovieById(20));
        }
        //test MovieService getTop25Hi
        //always make sure your method names are decriptive...
        [Test]
        public async Task Test_Top_25_Highest_RevenueMovies_FromFakedata()
        {
            //unit testing should ideally not touch any external databases or resources
            //they should be isolated and tested independently
            //bc in your application, you will have hundreds of methods you need to test
            //if every method calls the dataabse, to run all those unit
            //the purpose of unit test is to run as many unit tests as possible very fast
            //you might have 500 unit tests methods...
            //we always do our unit test with in-memory fake data
            //arrange Initializes objects, creates mocks with arguments that are passed to the method under test and adds expectations.    
            _sut = new MovieService(_mockMovieRepository.Object);
            //Act: Invokes the method or property under test with the arranged parameters.  
            var movies = await _sut.GetTop25HiestRevenueMovies();
            //Assert: Verifies that the action of the method under test behaves as expected.
            Assert.NotNull(movies);
            Assert.AreEqual(16, movies.Count());
            CollectionAssert.AllItemsAreInstancesOfType(movies, typeof(Movie));
        }
    }
}
  
