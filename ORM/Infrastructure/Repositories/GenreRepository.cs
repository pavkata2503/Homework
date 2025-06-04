using IMBD_Movies.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Dictionary<string, double> CalculateTotalGrossPerGenre()
        {
            var genres = GetAllGenres(); 
            Dictionary<string,double> keyValuePairs = new Dictionary<string, double>();
            foreach (var genre in genres)
            {
                var moviesInGenre = genre.MovieGenres.Select(mg => mg.Movie).ToList();
                var totalGross = moviesInGenre.Aggregate(0.0, (sum, movie) => sum + movie.Gross);

                if (keyValuePairs.ContainsKey(genre.Name))
                    keyValuePairs[genre.Name] += totalGross; // Добави към вече съществуващата стойност
                else
                    keyValuePairs.Add(genre.Name, totalGross);
            }
            var sortedDict = keyValuePairs.OrderByDescending(kvp => kvp.Value)
                              .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            return sortedDict;
        }
        public List<Genre> GetAllGenres()
        {
            return _context.Genres
                .Include(g => g.MovieGenres)!
                .ThenInclude(mg => mg.Movie)
                .ToList()!;
        }
        public List<Movie> GetAllMovie()
        {
            return _context.Movies
                .Include(g => g.MovieGenres!)
                .ThenInclude(mg => mg.Genre)
                .ToList();
        }

        //public void GetAllGenresByGross()
        //{
        //    GetAllGenres().ForEach(genre =>
        //    {
        //        Console.WriteLine($"Genre: {genre.Name}");
        //        genre.MovieGenres.ForEach(movieGenre =>
        //        {
        //            Console.WriteLine($"Movie: {movieGenre.Movie.Name}, Gross: {movieGenre.Movie.Gross}");
        //        });
        //    });
        //}
    }
}
