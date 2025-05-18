using System.Threading.Tasks;
using CleanArchitecture1.Application.Interfaces;

namespace CleanArchitecture1.Infrastructure.Persistence.Contexts
{
    public class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
    {
        public async Task<bool> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync() > 0;
        }
        public bool SaveChanges()
        {
            return dbContext.SaveChanges() > 0;
        }
    }
}
