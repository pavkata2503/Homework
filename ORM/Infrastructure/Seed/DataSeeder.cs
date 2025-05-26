using IMBD_Movies;
using IMBD_Movies.CsvRead;
using IMBD_Movies.Models;
using Infrastructure.Data;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Seed
{
    internal class DataSeeder
    {
        private readonly ApplicationDbContext _context;


        private List<Model> moviesList = CsvFileReader.GetData();
        public void Seed()
        {
            //Seed the database with movies
            foreach (var item in moviesList)
            {
                var dorectorList = new Director
                {
                    Name = item.Director,
                    Movies = new List<Movie>()
                };
                var genreList = new Genre
                {
                    Name = item.Genre.FirstOrDefault().ToString(),
                    MovieGenres = new List<MovieGenre>()
                };
                var actorList = new Cast
                {
                    Name = item.Cast.FirstOrDefault().ToString(),
                    MovieActors = new List<MovieActor>()
                };
                var movieGenre = new MovieGenre
                {
                    Genre = genreList,
                    Movie = new Movie()
                };
                var movieActor = new MovieActor
                {
                    Cast = actorList,
                    Movie = new Movie()
                };
                var movieActorList = new MovieActor
                {
                    Movie = new Movie(),
                    Cast = new Cast()
                };
                var movieGenreList = new MovieGenre
                {
                    Movie = new Movie(),
                    Genre = new Genre()
                };
                var movie = new Movie
                {
                    Name = item.MovieName,
                    ReleaseYear = item.ReleaseYear,
                    Duration = item.Duration,
                    ImdbRating = item.IMDBRating,
                    Metascore = item.Metascore,
                    Votes = item.Votes,
                    Gross = item.Gross,
                    DirectorId = dorectorList.Id,
                    MovieGenres = new List<MovieGenre>(),
                    MovieActors = new List<MovieActor>()
                };


                _context.Movies.Add(movie);
                _context.Directors.Add(dorectorList);
                _context.Genres.Add(genreList);
                _context.Casts.Add(actorList);
                _context.MovieActors.Add(movieActor);
                _context.MovieGenres.Add(movieGenreList);

            }
            _context.SaveChanges();

        }
    }
}
