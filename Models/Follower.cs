namespace unimarket_backend.Models
{
    public class Follower
    {
        public int Id { get; set; }
        public int FollowerId { get; set; } //Who follows
        public int FollowedId { get; set; } //Who is being followed, i hate commenting though

        public User FollowerUser { get; set; }
        public User FollowedUser { get; set; }
    }
}
