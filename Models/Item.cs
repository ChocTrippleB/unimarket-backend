namespace unimarket_backend.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int SellerID { get; set; }
        public User Seller { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        public ICollection<ItemImage> Images { get; set; }
        public ICollection<Review> Reviews { get; set; }
        
    }
}
