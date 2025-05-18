using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture1.Application.DTOs;
using CleanArchitecture1.Application.Interfaces.Repositories;
using CleanArchitecture1.Domain.Products.DTOs;
using CleanArchitecture1.Domain.Products.Entities;
using CleanArchitecture1.Infrastructure.Persistence.Contexts;

namespace CleanArchitecture1.Infrastructure.Persistence.Repositories
{
    public class ProductRepository(ApplicationDbContext dbContext) : GenericRepository<Product>(dbContext), IProductRepository
    {
        public async Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = dbContext.Products.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            return await Paged(
                query.Select(p => new ProductDto(p)),
                pageNumber,
                pageSize);

        }
    }
}
