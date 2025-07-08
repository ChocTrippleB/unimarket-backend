namespace unimarket_backend.Models
{
    public class ItemImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
