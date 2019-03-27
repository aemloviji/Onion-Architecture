using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Core;

namespace OnionApp.Infrastructure.Data
{
    public class OnionArchitectureContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
