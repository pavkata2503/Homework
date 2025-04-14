using DataContext.Contracts;
using DataContext.Seed;
using FlightManager.BaseModels;
using FlightManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    internal class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightStatus> FlightStatuses { get; set; }
        public DbSet<FlightStatusChange> FlightStatusChanges { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-POJ3LVD0;Initial Catalog=AirCompanySystem;Integrated Security=True;TrustServerCertificate=True;Pooling=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //DataSeed.ExampleSeed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            // TODO: 
            var entries = ChangeTracker.Entries().Where(x => x.Entity.GetType() is IBaseModel).ToList();

            foreach (var entry in entries)
            {
                IBaseModel model = (IBaseModel)entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    model.CreatedAt = DateTimeOffset.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    model.UpdatedAt = DateTimeOffset.Now;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    model.DeletedAt = DateTimeOffset.Now;
                    entry.State = EntityState.Modified;
                }
            }


            return base.SaveChanges();
        }

    }
}
