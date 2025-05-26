using System;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore.Migrations;
using Infrastructure.Data;
using IMBD_Movies.CsvRead;
using IMBD_Movies.Models;
using Infrastructure.Seed;

namespace IMBD_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ApplicationDbContext();
            var seeder = new DataSeeder(context);
            seeder.SeedDatabase();
        }
    }

}

