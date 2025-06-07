using Microsoft.EntityFrameworkCore;
using Service.BaseModels;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<ShipMode> ShipModes { get; set; }
        public DbSet<OrderPriority> OrderPriorities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-POJ3LVD0;Initial Catalog=IMDB_Movie;Integrated Security=True;TrustServerCertificate=True;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(p => new { p.ProductCategoryName, p.ProductSubCategoryName });

            modelBuilder.Entity<Region>()
                .HasKey(r => new { r.RegionName, r.State, r.City, r.PostalCode });

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries<BaseModel>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }
    }
}
