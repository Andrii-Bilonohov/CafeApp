namespace CafeApp.BLL.Models
{
    public class Admin : User
    {
        public ICollection<Employee> Employees = new List<Employee>();
    }
}
