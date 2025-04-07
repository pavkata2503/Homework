using CarManifacute.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text;


namespace CarManifacute
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CarDbContext context = new CarDbContext();
            context.DemonstrateCarComparison(1,2);
        }
    }
}
