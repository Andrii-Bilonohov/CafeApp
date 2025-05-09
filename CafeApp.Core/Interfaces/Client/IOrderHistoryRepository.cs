using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IOrderHistoryRepository
    {
        Task<Order> HistoryOrderAsync(Order order, CancellationToken cancellationToken);
    }
}
