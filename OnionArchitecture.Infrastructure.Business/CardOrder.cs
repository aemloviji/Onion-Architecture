using OnionArchitecture.Domain.Core;
using OnionArchitecture.Services.Interfaces;
using System;

namespace OnionArchitecture.Infrastructure.Business
{
    public class CardOrder : IOrder
    {
        public void Order(Product product)
        {
            Console.WriteLine($"Product:{product.Name} ordered with {nameof(CardOrder)} channel!");
        }
    }
}
