using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03.OOP.Data
{
    public class Warehouse : DbContext
    {
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server =LAPTOP-POJ3LVD0;Database=Warehousecheck;Integrated Security=True;TrustServerCertificate=True;Pooling=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>()
                .HasOne(b => b.Product)
                .WithMany(p => p.Buyers)
                .HasForeignKey(b => b.ProductId);
        }
    }
}
