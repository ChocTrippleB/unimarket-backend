namespace unimarket_backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string ProfilePictureUrl { get; set; }

        public ICollection<Item> LitedItems { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Follower> Followers { get; set; }
        public ICollection<Follower> Following {  get; set; }
    }
}
