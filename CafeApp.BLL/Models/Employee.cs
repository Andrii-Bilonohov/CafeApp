namespace CafeApp.BLL.Models
{
    public class Employee : User
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
    }
}
