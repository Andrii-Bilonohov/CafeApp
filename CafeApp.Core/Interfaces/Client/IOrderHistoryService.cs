using CafeApp.Core.DTOs.Inputs;
using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IOrderHistoryService
    {
        Task<Order> HistoryOrderAsync(Order order, CancellationToken cancellationToken);
    }
}
