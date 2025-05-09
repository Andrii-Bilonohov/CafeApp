using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Employee
{
    public interface IEmployeeRepository
    {
        Task<Models.Employee> AddEmployeeAsync(Models.Employee employee, CancellationToken cancellationToken);
        Task<Models.Employee> UpdateEmployeeAsync(Models.Employee employee, CancellationToken cancellationToken);
        Task<bool> RemoveEmployeeAsync(Models.Employee employee, CancellationToken cancellationToken);
        Task<IEnumerable<Models.Employee>> GetAsync(CancellationToken cancellationToken);
    }
}