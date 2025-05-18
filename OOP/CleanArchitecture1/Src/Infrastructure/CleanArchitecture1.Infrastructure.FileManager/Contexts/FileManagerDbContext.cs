using CleanArchitecture1.Infrastructure.FileManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture1.Infrastructure.FileManager.Contexts
{
    public class FileManagerDbContext(DbContextOptions<FileManagerDbContext> options) : DbContext(options)
    {
        public DbSet<FileEntity> Files { get; set; }
    }
}
