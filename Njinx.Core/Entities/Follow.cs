namespace Njinx.Core.Entities
{
    public class Follow
    {
        public int Id { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual UserProfile FollowedUser { get; set; }
    }
}