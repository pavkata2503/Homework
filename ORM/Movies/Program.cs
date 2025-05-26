using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movies.Data;
using Movies.Services;

var services = new ServiceCollection();

// Конфигуриране на DbContext
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("Server=LAPTOP-POJ3LVD0;Initial Catalog=LearningContent;Integrated Security=True;TrustServerCertificate=True;Pooling=False"));

// Добавяне на CsvImportService
services.AddScoped<CsvImportService>();

var serviceProvider = services.BuildServiceProvider();

using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();

    if (!context.Movies.Any())
    {
        var csvService = scope.ServiceProvider.GetRequiredService<CsvImportService>();
        csvService.ImportMoviesFromCsv("imdb_top_2000_movies.csv").Wait();
        Console.WriteLine("Данните са импортирани успешно!");
    }
    else
    {
        Console.WriteLine("Базата данни вече съдържа филми.");
    }
}
