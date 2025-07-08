namespace unimarket_backend.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public int UserSId { get; set; }
        public int UserBid { get; set; }

        public User UserS { get; set; }
        public User UserB { get; set; }

        public ICollection<Message> Messages { get; set; }

    }
}
