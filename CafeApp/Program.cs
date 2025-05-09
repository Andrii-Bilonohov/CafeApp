using System.Data;
using System.Data.SqlClient;
using Dapper;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ManageEmployee;Integrated Security=True;Connect Timeout=30;";

        using IDbConnection db = new SqlConnection(connectionString);

        var employee = new { FirstName = "Ivan", LastName = "Ivanov", Salary = 50000, AdminId = 1 };
        string insertQuery = "INSERT INTO Employee (FirstName, LastName, Salary, AdminId) VALUES (@FirstName, @LastName, @Salary, @AdminId)";
        db.Execute(insertQuery, employee);

        string selectQuery = "SELECT * FROM Employee";
        var employees = db.Query(selectQuery);

        Console.WriteLine("List Employee:");
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.FirstName}, Last name: {emp.LastName}, Salary: {emp.Salary}");
        }
    }
}
