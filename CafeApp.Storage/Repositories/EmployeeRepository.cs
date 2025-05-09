using CafeApp.Core.Interfaces.Employee;
using CafeApp.Core.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CafeApp.Storage.Repositories
{
    public class EmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee, CancellationToken cancellationToken)
        {
            const string query = @"INSERT INTO Employee (FirstName, LastName, Salary, AdminId) 
                                   OUTPUT INSERTED.* 
                                   VALUES (@FirstName, @LastName, @Salary, @AdminId)";

            using IDbConnection db = new SqlConnection(_connectionString);
            return await db.QuerySingleAsync<Employee>(query, employee);
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee, CancellationToken cancellationToken)
        {
            const string query = @"UPDATE Employee SET 
                                   FirstName = @FirstName, 
                                   LastName = @LastName, 
                                   Salary = @Salary 
                                   WHERE Id = @Id;
                                   SELECT * FROM Employee WHERE Id = @Id";

            using IDbConnection db = new SqlConnection(_connectionString);
            return await db.QuerySingleAsync<Employee>(query, employee);
        }

        public async Task<bool> RemoveEmployeeAsync(int employeeId, CancellationToken cancellationToken)
        {
            const string query = "DELETE FROM Employee WHERE Id = @Id";

            using IDbConnection db = new SqlConnection(_connectionString);
            int affectedRows = await db.ExecuteAsync(query, new { Id = employeeId });
            return affectedRows > 0;
        }

        public async Task<IEnumerable<Employee>> GetAsync(CancellationToken cancellationToken)
        {
            const string query = "SELECT * FROM Employee";

            using IDbConnection db = new SqlConnection(_connectionString);
            return await db.QueryAsync<Employee>(query);
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int employeeId, CancellationToken cancellationToken)
        {
            const string query = "SELECT * FROM Employee WHERE Id = @Id";

            using IDbConnection db = new SqlConnection(_connectionString);
            return await db.QuerySingleOrDefaultAsync<Employee>(query, new { Id = employeeId });
        }
    }
}
