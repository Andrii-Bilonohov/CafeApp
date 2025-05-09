using CafeApp.Core.DTOs.Inputs;
using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IOrderService
    {
        Task<Order> PlaceOrderAsync(AddOrderDto orderDto, CancellationToken cancellationToken);
    }
}
