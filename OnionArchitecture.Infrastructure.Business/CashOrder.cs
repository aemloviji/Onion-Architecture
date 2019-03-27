using System;
using OnionArchitecture.Domain.Core;
using OnionArchitecture.Services.Interfaces;

namespace OnionArchitecture.Infrastructure.Business
{
    public class CashOrder : IOrderService
    {
        public void Order(Product product)
        {
            Console.WriteLine($"Product:{product.Name} ordered with {nameof(CashOrder)} channel!");
        }
    }
}
