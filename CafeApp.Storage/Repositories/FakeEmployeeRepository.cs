using CafeApp.Core.Interfaces.Employee;
using CafeApp.Core.Models;

namespace CafeApp.Storage.Repositories
{
    public class FakeEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public Task<Employee> AddEmployeeAsync(Employee employee, CancellationToken cancellationToken)
        {
            employee.AdminId = _employees.Count + 1; 
            _employees.Add(employee);
            return Task.FromResult(employee);
        }


        public Task<Employee> UpdateEmployeeAsync(Employee employee, CancellationToken cancellationToken)
        {
            var existingEmployee = _employees.FirstOrDefault(e => e.AdminId == employee.AdminId);
            if (existingEmployee != null)
            {
                existingEmployee.Salary = employee.Salary;
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
            }
            return Task.FromResult(existingEmployee);
        }


        public Task<bool> RemoveEmployeeAsync(Employee employee, CancellationToken cancellationToken)
        {
            return Task.FromResult(_employees.Remove(employee));
        }


        public Task<IEnumerable<Employee>> GetAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_employees.AsEnumerable());
        }
    }
}
