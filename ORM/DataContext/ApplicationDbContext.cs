using BookingFlight.Models;
using BookingFlight.Models.BaseModels;
using DataContext.Contracts;
using DataContext.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    public class ApplicationDbContext: DbContext ,IUnitOfWork
    {
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Con { get; set; }
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
            //modelBuilder.Entity<Payroll>().HasOne<Ticket>().WithOne(x=>x.Payroll).OnDelete(DeleteBehavior.Cascade);
            //DataSeed.ExampleSeed(modelBuilder);
            //DECORATORS, Interceptors
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            // TODO: 
            //var entries = ChangeTracker.Entries().Where(x=>x.Entity.GetType() is IBaseModel)
            List<EntityEntry> entries = ChangeTracker.Entries().Where(x => x.Entity.GetType() is IBaseModel).ToList();

            foreach (EntityEntry entry in entries)
            {
                IBaseModel model = (IBaseModel)entry.Entity;
                if (entry.State==EntityState.Added)
                {
                    model.CreatedAt = DateTimeOffset.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    model.UpdatedAt = DateTimeOffset.UtcNow;
                }
                else if(entry.State == EntityState.Detached)
                {
                    model.DeletedAt = DateTimeOffset.UtcNow;
                    entry.State = EntityState.Modified;
                }
            }

            return base.SaveChanges();
        }
    }
}
