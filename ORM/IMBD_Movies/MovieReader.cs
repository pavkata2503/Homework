using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static IMBD_Movies.MovieReader;

namespace IMBD_Movies
{
    internal partial class MovieReader
    {
        List<Movie> movies = new List<Movie>(); // Премахваме заглавния ред
        public void GetData()
        {
            // Използваме директно File.ReadAllLines, за да прочетем CSV файла
            string[] lines = File.ReadAllLines("../../../imdb_top_2000_movies.csv");
            

            // Извеждаме заглавния ред
            Console.WriteLine("Заглавни колони: " + lines[0]);
            
            // Обработваме първите 10 реда от данните като пример
            for (int i = 1; i < Math.Max(11, lines.Length); i++)
            {
                string[] columns = lines[i].Split(',');
                string[] genres = columns[6].Split(", ");
                List<string> genresList = new List<string>(genres);
                

                Movie movie = new Movie
                {
                    Name = columns[0],
                    ReleaseYear = int.Parse(columns[1]),
                    Duration = int.Parse(columns[2]),
                    IMDBRating = double.Parse(columns[3]),
                    Metascore = double.Parse(columns[4]),
                    Votes = columns[5],
                    Genres= genresList,
                    Director = columns[7],
                    Cast = columns[8],
                    Gross = columns[9]
                };

                movies.Add(movie);

            }
            
        }
        public void DisplayMovies()
        {
            Console.WriteLine("Показване на филми:");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{movies[i].Name} | {movies[i].ReleaseYear} | {movies[i].Duration} | {movies[i].IMDBRating} | {movies[i].Metascore} | {movies[i].Votes} | {movies[i].Genres} | {movies[i].Director} | {movies[i].Cast} | {movies[i].Gross}");
            }
        }
    }
}
