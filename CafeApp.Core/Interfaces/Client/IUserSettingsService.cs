using CafeApp.Core.DTOs.Inputs;
using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IUserSettingsService
    {
        Task<User> UpdateInfo(UserSettingsDto userSettingsDto, CancellationToken cancellationToken); 
    }
}
