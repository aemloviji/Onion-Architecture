using OnionArchitecture.Domain.Core;

namespace OnionArchitecture.Services.Interfaces
{
    public interface IOrderService
    {
        void Order(Product product);
    }
}
