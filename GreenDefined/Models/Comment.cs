using System.ComponentModel.DataAnnotations;

namespace GreenDefined.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public string userId { get; set; }
        public int PostID { get; set; }
        public string CommentValue { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Post Post { get; set; }


    }
}
