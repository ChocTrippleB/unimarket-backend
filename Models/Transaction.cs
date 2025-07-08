namespace unimarket_backend.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }
        public User Buyer { get; set; }

        public int SellerId { get; set; }
        public User Seller { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string ConfirmationCode { get; set; } // 6-digit code
        public bool IsCodeConfirmed { get; set; } = false;
        public bool IsPaid { get; set; } = false;
        public bool FundsReleased { get; set; } = false;
    }
}
