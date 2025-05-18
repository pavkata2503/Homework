using System;
using System.Text;
using System.Linq;

namespace IMBD_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Регистриране на доставчика за кодиране
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            
            MovieReader reader = new MovieReader();
            reader.GetData();
            reader.DisplayMovies();

        }
    }
}
