using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture1.Application.Interfaces;
using CleanArchitecture1.Domain.Products.Entities;
using CleanArchitecture1.Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture1.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IAuthenticatedUserService authenticatedUser) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            ChangeTracker.ApplyAuditing(authenticatedUser);

            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            this.ConfigureDecimalProperties(builder);

            base.OnModelCreating(builder);
        }
    }
}