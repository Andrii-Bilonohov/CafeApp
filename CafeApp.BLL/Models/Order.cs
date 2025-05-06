namespace CafeApp.BLL.Models
{
    public class Order
    {
        int Id { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public int TotalPriced { get; set; }
        public int CustomerId { get; set; }
        public ICollection<Product> Products = new List<Product>();
    }
}
