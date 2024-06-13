namespace GreenDefined.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public string PostValue { get; set; }
        public string? imageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ApplicationUser User { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public React React { get; set; }


    }
}
