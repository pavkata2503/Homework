using Microsoft.EntityFrameworkCore;
using Movies.Services;

namespace Movies.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            
            // Прилагане на миграциите
            await context.Database.MigrateAsync();

            // Проверка дали базата данни е празна
            if (!context.Movies.Any())
            {
                var csvService = scope.ServiceProvider.GetRequiredService<CsvImportService>();
                await csvService.ImportMoviesFromCsv("imdb_top_2000_movies.csv");
            }
        }
    }
} 