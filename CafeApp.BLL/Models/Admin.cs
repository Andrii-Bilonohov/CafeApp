namespace CafeApp.BLL.Models
{
    public class Admin : User
    {
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
