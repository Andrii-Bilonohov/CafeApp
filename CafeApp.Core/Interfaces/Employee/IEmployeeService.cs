using CafeApp.Core.DTOs.Inputs;
using CafeApp.Core.DTOs.Outputs;
using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Employee
{
    public interface IEmployeeService
    {
        Task<Models.Employee> AddAsync(DTOs.Inputs.EmployeeDto employeeDto, CancellationToken cancellationToken);
        Task<Models.Employee> UpdateAsync(DTOs.Inputs.EmployeeDto employeeDto, CancellationToken cancellationToken);
        Task<bool> RemoveAsync(Models.Employee employee, CancellationToken cancellationToken);
        Task<IEnumerable<Models.Employee>> GetAsync(CancellationToken cancellatioToken);
    }
}