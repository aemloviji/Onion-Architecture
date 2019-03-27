using OnionArchitecture.Domain.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> ListAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
    }
}
