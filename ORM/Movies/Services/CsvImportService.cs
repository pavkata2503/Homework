using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Movies.Data;
using Movies.Models;

namespace Movies.Services
{
    public class CsvImportService
    {
        private readonly ApplicationDbContext _context;

        public CsvImportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task ImportMoviesFromCsv(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                MissingFieldFound = null
            };

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, config);

            var records = csv.GetRecords<Movie>().ToList();

            foreach (var record in records)
            {
                // Преобразуване на стойностите
                if (decimal.TryParse(record.IMDBRating.ToString(), out decimal imdbRating))
                {
                    record.IMDBRating = imdbRating;
                }

                if (decimal.TryParse(record.Metascore?.ToString(), out decimal metascore))
                {
                    record.Metascore = metascore;
                }

                if (decimal.TryParse(record.Gross?.ToString().Replace("$", "").Replace("M", ""), out decimal gross))
                {
                    record.Gross = gross * 1000000; // Конвертиране в милиони
                }

                // Премахване на кавичките от имената
                record.Name = record.Name?.Trim('"');
                record.Genre = record.Genre?.Trim('"');
                record.Director = record.Director?.Trim('"');
                record.Cast = record.Cast?.Trim('"');
            }

            await _context.Movies.AddRangeAsync(records);
            await _context.SaveChangesAsync();
        }
    }
} 