using CarManifacute.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManifacute.Data
{
    internal class DbSeeder
    {
        public static void ExampleSeed(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Car>().HasData
                (new Car
                {
                    Id = 1,
                    Brand = "BMW",
                    ModelId = 1,
                    EngineId = 1,
                    Seats = 5,
                    Height = 1.5,
                    Width = 2.0,
                    Length = 4.5
                },
                new Car
                {
                    Id = 2,
                    Brand = "Audi",
                    ModelId = 2,
                    EngineId = 2,
                    Seats = 5,
                    Height = 1.5,
                    Width = 2.0,
                    Length = 4.5
                }
                );

            modelBuilder.Entity<Engine>().HasData(
                new Engine
                {
                    EngineId = 1,
                    Name = "M50B25",
                    HoursePower = 192,
                    Cylinders = 6,
                    FuelConsumption = 10.5,
                    FuelType = "Petrol",
                    Capacity = 2.5
                },
                new Engine
                {
                    EngineId = 2,
                    Name = "1.8T",
                    HoursePower = 180,
                    Cylinders = 4,
                    FuelConsumption = 8.5,
                    FuelType = "Petrol",
                    Capacity = 1.8
                }
                );

            modelBuilder.Entity<Model>().HasData(
                new Model
                {
                    Id = 1,
                    Name = "E36",
                    Year = 1990
                },
                new Model
                {
                    Id = 2,
                    Name = "A4",
                    Year = 1995
                }
                );
        }
    }
}
