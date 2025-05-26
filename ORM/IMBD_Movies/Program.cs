using System;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore.Migrations;
using Infrastructure.Data;
using IMBD_Movies.CsvRead;
using IMBD_Movies.Models;

namespace IMBD_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movies = CsvFileReader.GetData();
            foreach (var movie in movies)
            {
                Console.WriteLine($"Movie Name: {movie.MovieName}");
                Console.WriteLine($"Director: {movie.Director}");
                Console.WriteLine($"Genre: {movie.Genre}");
                Console.WriteLine($"Release Year: {movie.ReleaseYear}");
                Console.WriteLine($"Rating: {movie.IMDBRating}");
                Console.WriteLine();
            }
        }
    }

}

