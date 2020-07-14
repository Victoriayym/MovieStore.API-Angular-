using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;

namespace MovieStore.Infrastructure.Data
{
    //install all the EF Core libraries using Nuget package Manager
    //create a class that inherits from dbcontext class
    //dbcontext kinda represnts your databse
    //create a connectionstring which EF is gonna use to create/access the database
    //should include your server name, database name and any credentials.
    //create an entity class, genre table
    //in EF we have Migration we are gonna use Migration to create our Database
    //we need to add Migration commands to create the tables, database etc
    //when running Migration commands, make sure the project selected is the one project which has DbContext
    //make sure you add reference for library that has DbContext to your starup project
    //tell MVC project that we are using Entity framework in startup files
    //add DbContext options as constructor parameter for out DbContext
    //Add-Migration xxxx, make sure your migration names are meaningful, dont use names like abc, xx
    //make sure you have Migration folder created and check the created migration file
    //after its done, verify it we need to use update-database command
    //whenever changing the model/entity, always make sure you add new migration
    //with CF approach, never change the database directly, always change the entities using DataAnnotaion
    //or fluent API and add new Migration then update the database

    //in EF we have 2 ways to create entities and model our database using code-First Approach
    //1. Data Annotations which is nothing but bunch of attributes that we can use
    //2. Fluent API is more syntax and more powerful and usually use lambdas
    //combine both DataAnnotations and Fluent API
    public class MovieStoreDbContext : DbContext
    {
        //multiple dbsets; all the dbsets you create are gonna reside in your Dbcontext class
        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options): base(options)
        {

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(ConfigureMovie);
            modelBuilder.Entity<Trailer>(ConfigureTrailer);
            modelBuilder.Entity<MovieGenre>(ConfigureMovieGenre);
        }
        private void ConfigureMovieGenre(EntityTypeBuilder<MovieGenre> modelBuilder)
        {
            modelBuilder.ToTable("MovieGenre");
            modelBuilder.HasKey(mg => new { mg.MovieId, mg.GenreId });
            modelBuilder.HasOne(mg => mg.Movie).WithMany(g => g.MovieGenres).HasForeignKey(mg => mg.MovieId);
            modelBuilder.HasOne(mg => mg.Genre).WithMany(g => g.MovieGenres).HasForeignKey(mg => mg.GenreId);
        }
        private void ConfigureTrailer(EntityTypeBuilder<Trailer> modelBuilder)
        {
            modelBuilder.ToTable("Trailer");
            modelBuilder.HasKey(t => t.Id);
            modelBuilder.Property(t => t.Name).HasMaxLength(2084);
            modelBuilder.Property(t => t.TrailerUrl).HasMaxLength(2084);
        }

        private void ConfigureMovie(EntityTypeBuilder<Movie> modelBuilder)
        {
            //we can use Fluent API Configuration to model our tables
            modelBuilder.ToTable("Movie");
            modelBuilder.HasKey(m => m.Id);
            modelBuilder.Property(m => m.Title).IsRequired().HasMaxLength(256);
            modelBuilder.Property(m => m.Overview).HasMaxLength(4096);
            modelBuilder.Property(m => m.Tagline).HasMaxLength(512);
            modelBuilder.Property(m => m.ImdbUrl).HasMaxLength(2084);
            modelBuilder.Property(m => m.TmdbUrl).HasMaxLength(2084);
            modelBuilder.Property(m => m.PosterUrl).HasMaxLength(2084);
            modelBuilder.Property(m => m.BackdropUrl).HasMaxLength(2084);
            modelBuilder.Property(m => m.OriginalLanguage).HasMaxLength(64);
            modelBuilder.Property(m => m.Price).HasColumnType("decimal(5, 2)").HasDefaultValue(9.9m);
            modelBuilder.Property(m => m.CreatedDate).HasDefaultValueSql("getdate()");
            //we dont want to create Rating Column but we want C# rating property in our entity
            //so that we can show Movie rating in UI
            modelBuilder.Ignore(m => m.Rating);
        }

        
    }
}

 
