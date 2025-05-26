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
            var moviesList = CsvFileReader.GetData();
            var movieList = new List<Movie>();
            foreach (var movie in moviesList)
            {
                var newmovie =new Movie
                {
                    Name = movie.MovieName,
                    ReleaseYear = movie.ReleaseYear,
                    Duration = movie.Duration,
                    ImdbRating = movie.IMDBRating,
                    Metascore = movie.Metascore,
                    Votes = movie.Votes,
                    Gross = movie.Gross
                };
                movieList.Add(newmovie);
            }
            _context.Movies.AddRange(movieList);
            _context.SaveChanges();
        }
    }
}
