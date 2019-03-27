using OnionArchitecture.Domain.Core;

namespace OnionArchitecture.Services.Interfaces
{
    public interface IOrder
    {
        void Order(Product product);
    }
}
