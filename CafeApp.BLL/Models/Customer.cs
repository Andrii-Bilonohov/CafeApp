namespace CafeApp.BLL.Models
{
    public class Customer : User
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Card {  get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Review> Reviews { get; set; }
    }
}
