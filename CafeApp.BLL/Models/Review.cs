namespace CafeApp.BLL.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int grade { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
