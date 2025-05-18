using System.Threading.Tasks;
using CleanArchitecture1.Application.DTOs;
using CleanArchitecture1.Domain.Products.DTOs;
using CleanArchitecture1.Domain.Products.Entities;

namespace CleanArchitecture1.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
