using CafeApp.Core.DTOs.Inputs;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IMenuRepository
    {
        Task ViewMenu<Products>(Products products, CancellationToken cancellationToken);
    }
}
