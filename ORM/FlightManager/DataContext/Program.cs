using Microsoft.EntityFrameworkCore;

namespace DataContext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context=new ApplicationDbContext();
            context.Database.Migrate();
            
        }
    }
}
