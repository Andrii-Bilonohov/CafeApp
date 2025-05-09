namespace CafeApp.Core.Models
{
    public class Employee : User
    {
        public decimal Salary { get; set; }
        public int AdminId { get; set; }
    }
}