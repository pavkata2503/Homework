using System;
using System.Text;
using System.Linq;
using IMBD_Movies.CsvRead;

namespace IMBD_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CsvFileReader reader = new CsvFileReader();
            var list = reader.GetData();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Cast}    {item.MovieName}");
            }

        }
    }
}
