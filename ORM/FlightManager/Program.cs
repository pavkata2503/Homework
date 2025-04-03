using Fluent.Infrastructure.FluentModel;

namespace FlightManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            dbContext.Database.Migrate();
        }
    }
}
