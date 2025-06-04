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
    public class DataSeeder
    {
        private readonly ApplicationDbContext _context;

        public DataSeeder(ApplicationDbContext context)
        {
            _context = context;
        }



        public void SeedDatabase()
        {
            var moviesCSV = CsvFileReader.GetData();
            var movieList = new List<Movie>();

            var genreDict = new Dictionary<string, Genre>();
            var directorDict = new Dictionary<string, Director>();
            var actorDict = new Dictionary<string, Cast>();

            foreach (var row in moviesCSV)
            {
                // Example keys: row["Title"], row["Genres"], etc.
                var title = row.MovieName;
                var year = row.ReleaseYear;
                var duration = row.Duration;
                var imdb = row.IMDBRating;
                var metascore = row.Metascore;
                var votes = row.Votes;
                var gross = row.Gross;
                var directorName = row.Director;
                var genres = row.Genre.Split(",").Select(g => g.Trim());
                var actors = row.Cast.Split(",").Select(a => a.Trim());

                if (!directorDict.TryGetValue(directorName, out var director))
                {
                    director = new Director { Name = directorName };
                    directorDict[directorName] = director;
                    _context.Directors.Add(director);
                }

                var movie = new Movie
                {
                    Name = title,
                    ReleaseYear = year,
                    Duration = duration,
                    ImdbRating = imdb,
                    Metascore = metascore,
                    Votes = votes,
                    Gross = gross,
                    Director = director,
                    MovieGenres = new List<MovieGenre>(),
                    MovieActors = new List<MovieActor>()
                };

                foreach (var genreName in genres)
                {
                    if (!genreDict.TryGetValue(genreName, out var genre))
                    {
                        genre = new Genre { Name = genreName };
                        genreDict[genreName] = genre;
                        _context.Genres.Add(genre);
                    }

                    movie.MovieGenres.Add(new MovieGenre { Movie = movie, Genre = genre });
                }

                foreach (var actorName in actors)
                {
                    if (!actorDict.TryGetValue(actorName, out var actor))
                    {
                        actor = new Cast { Name = actorName };
                        actorDict[actorName] = actor;
                        _context.Casts.Add(actor);
                    }

                    movie.MovieActors.Add(new MovieActor { Movie = movie, Cast = actor });
                }

                movieList.Add(movie);
            }

            _context.Movies.AddRange(movieList);
            _context.SaveChanges();
        }
    }
}
