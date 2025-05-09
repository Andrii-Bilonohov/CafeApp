using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IOrderRepository
    {
        Task<Order> PlaceOrderAsync(Order order, CancellationToken cancellationToken);
    }
}
