namespace unimarket_backend.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Itemid { get; set; }
        public Item Item { get; set; }

        public decimal PriceAtPurchase { get; set; }
    }
}
