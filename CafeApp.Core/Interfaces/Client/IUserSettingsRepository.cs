using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IUserSettingsRepository
    {
        Task<User> UpdateInfo(User user, CancellationToken cancellationToken);
    }
}
