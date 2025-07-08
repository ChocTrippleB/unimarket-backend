namespace unimarket_backend.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BillingAddress { get; set; }
        public DateTime PlacedAt { get; set; } = DateTime.UtcNow;

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
