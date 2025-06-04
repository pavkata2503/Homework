using System;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore.Migrations;
using Infrastructure.Data;
using IMBD_Movies.CsvRead;
using IMBD_Movies.Models;
using Infrastructure.Seed;
using Infrastructure.Repositories;

namespace IMBD_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ApplicationDbContext();
            //var seeder = new DataSeeder(context);
            //seeder.SeedDatabase();
            //Console.WriteLine("Database seeded successfully!");



            MovieRepository movieRepository = new MovieRepository(context);
            GenreRepository genreRepository = new GenreRepository(context);
            var list=movieRepository.GetMoviesWithTitleContaining("Dog");
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
            var n = genreRepository.CalculateTotalGrossPerGenre();
            //foreach (var pair in n.Take(5))
            //{
            //    Console.WriteLine($"{pair.Key} ---- {pair.Value}");
            //}

        }
    }

}

