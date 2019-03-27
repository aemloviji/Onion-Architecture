using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionApp.Infrastructure.Data;
using OnionArchitecture.Domain.Core;
using OnionArchitecture.Domain.Interfaces;

namespace OnionArchitecture.Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnionArchitectureContext _dbContext;

        public ProductRepository(OnionArchitectureContext context)
        {
            _dbContext = context;
        }

        public Task<List<Product>> ListAsync()
        {
            return _dbContext.Products.ToListAsync();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            return _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task AddAsync(Product product)
        {
            _dbContext.Products.Add(product);
            return _dbContext.SaveChangesAsync();
        }

        public Task UpdateAsync(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            return _dbContext.SaveChangesAsync();
        }
    }
}
