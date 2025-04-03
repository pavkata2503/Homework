using BookingFlight.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Seed
{
    public class DataSeed
    {
        #region Continents
        private static List<Continent> continentList = new List<Continent>()
        {
                new Continent {Id=1,ContinentName = "Europe",CreatedAt=DateTimeOffset.UtcNow},
                new Continent {Id=2,ContinentName = "Asia", CreatedAt=DateTimeOffset.UtcNow },
                new Continent {Id=3,ContinentName = "Africa", CreatedAt=DateTimeOffset.UtcNow },
                new Continent {Id=4,ContinentName = "North America", CreatedAt=DateTimeOffset.UtcNow },
                new Continent {Id=5,ContinentName = "South America", CreatedAt=DateTimeOffset.UtcNow },
                new Continent {Id=6,ContinentName = "Australia", CreatedAt=DateTimeOffset.UtcNow },
                new Continent {Id=7,ContinentName = "Antarctica", CreatedAt=DateTimeOffset.UtcNow }
        };
        #endregion

        #region Countries
        private static List<Country> countryList = new List<Country>()
        {
            new Country {Id=1,CountryName = "Turkey", ContinentId=continentList[1].Id, CreatedAt=DateTimeOffset.UtcNow},
            new Country {Id=2,CountryName = "Germany", ContinentId=continentList[1].Id,CreatedAt=DateTimeOffset.UtcNow},
            new Country {Id=3,CountryName = "France", ContinentId=continentList[2].Id, CreatedAt=DateTimeOffset.UtcNow},
            new Country {Id=4,CountryName = "Italy", ContinentId=continentList[3].Id, CreatedAt=DateTimeOffset.UtcNow},
            new Country {Id=5,CountryName = "Spain", ContinentId=continentList[4].Id, CreatedAt=DateTimeOffset.UtcNow},
            new Country {CountryName = "United Kingdom",ContinentId=continentList[4].Id ,CreatedAt=DateTimeOffset.UtcNow},
            new Country {Id=6,CountryName = "Russia", ContinentId=continentList[6].Id,CreatedAt=DateTimeOffset.UtcNow},
            new Country {Id=7,CountryName = "China", ContinentId=continentList[1].Id,CreatedAt=DateTimeOffset.UtcNow},
            new Country {Id=8,CountryName = "Bulgaria",ContinentId=continentList[3].Id ,CreatedAt=DateTimeOffset.UtcNow},
        };
        #endregion

        #region Cities
        private static List<City> citiesList= new List<City>()
        {
            new City {Id=1,Name = "Istanbul", CountryId=countryList[2].Id, CreatedAt=DateTimeOffset.UtcNow},
            new City {Id=2,Name = "Berlin", CountryId=countryList[1].Id, CreatedAt=DateTimeOffset.UtcNow},
            new City {Id=3,Name = "Paris", CountryId=countryList[2].Id, CreatedAt=DateTimeOffset.UtcNow},
            new City {Id=4,Name = "Rome", CountryId=countryList[3].Id, CreatedAt=DateTimeOffset.UtcNow},
            new City {Id=5,Name = "Madrid", CountryId=countryList[4].Id, CreatedAt=DateTimeOffset.UtcNow},
        };
        #endregion

        #region Airports
        private static List<Airport> airportsList = new List<Airport>() 
        { 
            new Airport {Id=1,AirportName = "Ataturk Airport", CityId=citiesList[1].Id, CreatedAt=DateTimeOffset.UtcNow},
            new Airport {Id=2,AirportName = "Sabiha Gokcen Airport", CityId=citiesList[1].Id, CreatedAt=DateTimeOffset.UtcNow},
            new Airport {Id=3,AirportName = "Tegel Airport", CityId=citiesList[1].Id, CreatedAt=DateTimeOffset.UtcNow},
            new Airport {Id=4,AirportName = "Charles de Gaulle Airport", CityId=citiesList[2].Id, CreatedAt=DateTimeOffset.UtcNow},
            new Airport {Id=5,AirportName = "Fiumicino Airport", CityId=citiesList[3].Id, CreatedAt=DateTimeOffset.UtcNow},
        };
        #endregion
        public static void ExampleSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>().HasData(continentList);
            modelBuilder.Entity<Country>().HasData(countryList);
            modelBuilder.Entity<City>().HasData(citiesList);
            modelBuilder.Entity<Airport>().HasData(airportsList);
        }
    }
}
