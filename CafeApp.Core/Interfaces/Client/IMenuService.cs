using CafeApp.Core.DTOs.Inputs;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IMenuService
    {
        Task ViewMenu<Products>(ViewMenuDto viewMenuDto, CancellationToken cancellationToken);
    }
}
