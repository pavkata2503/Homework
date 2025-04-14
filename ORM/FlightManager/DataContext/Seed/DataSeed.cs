using FlightManager.Models;
using Microsoft.EntityFrameworkCore;
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
            new Continent()
            {
                Id = 1,
                ContinentName = "Europe",
                CreatedAt = DateTimeOffset.UtcNow,
            },
            new Continent()
            {
                Id = 2,
                ContinentName = "Asia",
                CreatedAt = DateTimeOffset.UtcNow,
            }
        };
        #endregion

        #region Countries
        private static List<Country> countryList = new List<Country>()
        {
            new Country()
            {
                Id = 1,
                CountryName = "Bulgaria",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = 1
            },
            new Country()
            {
                Id = 2,
                CountryName = "France",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = 1
            },
            new Country()
            {
                Id = 3,
                CountryName = "Spain",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = 1
            },
            new Country()
            {
                Id = 4,
                CountryName = "Italy",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = 1
            },
            new Country()
            {
                Id = 5,
                CountryName = "Romania",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = 1
            },
            new Country()
            {
                Id = 6,
                CountryName = "Japan",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = 2
            },
            new Country()
            {
                Id = 7,
                CountryName = "China",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = 2
            },
            new Country()
            {
                Id = 8,
                CountryName = "India",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = 2
            }
        };
        #endregion

        #region Cities
        private static List<City> cityList = new List<City>()
        {
            new City() { Id = 1, Name = "Sofia", CountryId = 1, CreatedAt = DateTimeOffset.UtcNow },
            new City() { Id = 2, Name = "Paris", CountryId = 2, CreatedAt = DateTimeOffset.UtcNow },
            new City() { Id = 3, Name = "Madrid", CountryId = 3, CreatedAt = DateTimeOffset.UtcNow },
            new City() { Id = 4, Name = "Rome", CountryId = 4, CreatedAt = DateTimeOffset.UtcNow },
            new City() { Id = 5, Name = "Bucharest", CountryId = 5, CreatedAt = DateTimeOffset.UtcNow },
            new City() { Id = 6, Name = "Tokyo", CountryId = 6, CreatedAt = DateTimeOffset.UtcNow },
            new City() { Id = 7, Name = "Beijing", CountryId = 7, CreatedAt = DateTimeOffset.UtcNow },
            new City() { Id = 8, Name = "New Delhi", CountryId = 8, CreatedAt = DateTimeOffset.UtcNow }
        };
        #endregion

        #region Airports
        private static List<Airport> airportList = new List<Airport>()
        {
            new Airport() { Id = 1, AirportName = "Sofia International Airport", CityId = 1, CreatedAt = DateTimeOffset.UtcNow },
            new Airport() { Id = 2, AirportName = "Charles de Gaulle Airport", CityId = 2, CreatedAt = DateTimeOffset.UtcNow },
            new Airport() { Id = 3, AirportName = "Adolfo Suárez Madrid–Barajas Airport", CityId = 3, CreatedAt = DateTimeOffset.UtcNow },
            new Airport() { Id = 4, AirportName = "Leonardo da Vinci International Airport", CityId = 4, CreatedAt = DateTimeOffset.UtcNow },
            new Airport() { Id = 5, AirportName = "Henri Coandă International Airport", CityId = 5, CreatedAt = DateTimeOffset.UtcNow },
            new Airport() { Id = 6, AirportName = "Haneda Airport", CityId = 6, CreatedAt = DateTimeOffset.UtcNow },
            new Airport() { Id = 7, AirportName = "Beijing Capital International Airport", CityId = 7, CreatedAt = DateTimeOffset.UtcNow },
            new Airport() { Id = 8, AirportName = "Indira Gandhi International Airport", CityId = 8, CreatedAt = DateTimeOffset.UtcNow }
        };
        #endregion

        #region Roles
        private static List<Role> roleList = new List<Role>()
        {
            new Role() { Id = 1, RoleName = "Pilot", CreatedAt = DateTimeOffset.UtcNow },
            new Role() { Id = 2, RoleName = "Co-Pilot", CreatedAt = DateTimeOffset.UtcNow },
            new Role() { Id = 3, RoleName = "Flight Attendant", CreatedAt = DateTimeOffset.UtcNow },
            new Role() { Id = 4, RoleName = "Engineer", CreatedAt = DateTimeOffset.UtcNow }
        };
        #endregion

        #region Crew
        private static List<Crew> crewList = new List<Crew>()
        {
            new Crew() { Id = 1, Name = "John Smith", RoleId = 1, CreatedAt = DateTimeOffset.UtcNow },
            new Crew() { Id = 2, Name = "Maria Garcia", RoleId = 2, CreatedAt = DateTimeOffset.UtcNow },
            new Crew() { Id = 3, Name = "James Wilson", RoleId = 3, CreatedAt = DateTimeOffset.UtcNow },
            new Crew() { Id = 4, Name = "Sarah Johnson", RoleId = 3, CreatedAt = DateTimeOffset.UtcNow }
        };
        #endregion

        #region Airplanes
        private static List<Airplane> airplaneList = new List<Airplane>()
        {
            new Airplane() { Id = 1, SeatsCount = 180, CreatedAt = DateTimeOffset.UtcNow },
            new Airplane() { Id = 2, SeatsCount = 220, CreatedAt = DateTimeOffset.UtcNow },
            new Airplane() { Id = 3, SeatsCount = 150, CreatedAt = DateTimeOffset.UtcNow }
        };
        #endregion

        #region FlightStatuses
        private static List<FlightStatus> flightStatusList = new List<FlightStatus>()
        {
            new FlightStatus() { Id = 1, Status = "Scheduled", CreatedAt = DateTimeOffset.UtcNow },
            new FlightStatus() { Id = 2, Status = "Boarding", CreatedAt = DateTimeOffset.UtcNow },
            new FlightStatus() { Id = 3, Status = "In Flight", CreatedAt = DateTimeOffset.UtcNow },
            new FlightStatus() { Id = 4, Status = "Landed", CreatedAt = DateTimeOffset.UtcNow },
            new FlightStatus() { Id = 5, Status = "Delayed", CreatedAt = DateTimeOffset.UtcNow },
            new FlightStatus() { Id = 6, Status = "Cancelled", CreatedAt = DateTimeOffset.UtcNow }
        };
        #endregion

        #region Flights
        private static List<Flight> flightList = new List<Flight>()
        {
            new Flight()
            {
                Id = 1,
                FlightDuration = 120,
                FlightDate = DateTimeOffset.UtcNow.AddDays(1),
                PassengerCount = 150,
                AirplaneId = 1,
                CreatedAt = DateTimeOffset.UtcNow,
                Airplane = null
            },
            new Flight()
            {
                Id = 2,
                FlightDuration = 180,
                FlightDate = DateTimeOffset.UtcNow.AddDays(2),
                PassengerCount = 200,
                AirplaneId = 2,
                CreatedAt = DateTimeOffset.UtcNow,
                Airplane = null
            }
        };
        #endregion

        #region FlightStatusChanges
        private static List<FlightStatusChange> flightStatusChangeList = new List<FlightStatusChange>()
        {
            new FlightStatusChange()
            {
                Id = 1,
                FlightId = 1,
                FlightStatusId = 1,
                ChangeAt = DateTime.UtcNow,
                CreatedAt = DateTimeOffset.UtcNow
            },
            new FlightStatusChange()
            {
                Id = 2,
                FlightId = 2,
                FlightStatusId = 1,
                ChangeAt = DateTime.UtcNow,
                CreatedAt = DateTimeOffset.UtcNow
            }
        };
        #endregion

        #region Passengers
        private static List<Passenger> passengerList = new List<Passenger>()
        {
            new Passenger() { Id = 1, Name = "Alex Brown", CreatedAt = DateTimeOffset.UtcNow },
            new Passenger() { Id = 2, Name = "Emma Wilson", CreatedAt = DateTimeOffset.UtcNow },
            new Passenger() { Id = 3, Name = "Michael Chen", CreatedAt = DateTimeOffset.UtcNow }
        };
        #endregion

        #region Tickets
        private static List<Ticket> ticketList = new List<Ticket>()
        {
            new Ticket()
            {
                Id = 1,
                TicketPrice = 299.99M,
                Type = "Economy",
                SeatNumber = 15,
                FlightId = 1,

                CreatedAt = DateTimeOffset.UtcNow
            },
            new Ticket()
            {
                Id = 2,
                TicketPrice = 499.99M,
                Type = "Business",
                SeatNumber = 3,
                FlightId = 1,

                CreatedAt = DateTimeOffset.UtcNow
            }
        };
        #endregion

        #region Payrolls
        private static List<Payroll> payrollList = new List<Payroll>()
        {
            new Payroll()
            {
                Id = 1,
                PassengerId = 1,
                TicketId = 1,
                Total = 299.99,
                CreatedAt = DateTimeOffset.UtcNow
            },
            new Payroll()
            {
                Id = 2,
                PassengerId = 2,
                TicketId = 2,
                Total = 499.99,
                CreatedAt = DateTimeOffset.UtcNow
            }
        };
        #endregion

        public static void ExampleSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>().HasData(continentList);
            modelBuilder.Entity<Country>().HasData(countryList);
            modelBuilder.Entity<City>().HasData(cityList);
            modelBuilder.Entity<Airport>().HasData(airportList);
            modelBuilder.Entity<Role>().HasData(roleList);
            modelBuilder.Entity<Crew>().HasData(crewList);
            modelBuilder.Entity<Airplane>().HasData(airplaneList);
            modelBuilder.Entity<FlightStatus>().HasData(flightStatusList);
            modelBuilder.Entity<Flight>().HasData(flightList);
            modelBuilder.Entity<FlightStatusChange>().HasData(flightStatusChangeList);
            modelBuilder.Entity<Passenger>().HasData(passengerList);
            modelBuilder.Entity<Ticket>().HasData(ticketList);
            modelBuilder.Entity<Payroll>().HasData(payrollList);
        }
    }
}
