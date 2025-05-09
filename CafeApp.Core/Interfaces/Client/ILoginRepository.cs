using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface ILoginRepository
    {
        Task<Customer> Login(Customer customer, CancellationToken cancellationToken);
    }
}
