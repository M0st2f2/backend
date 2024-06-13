using System.ComponentModel.DataAnnotations;

namespace GreenDefined.Models
{
    public class React
    {
        [Key]
        public int id { get; set; }

        public string userId { get; set; }


        public int PostId { get; set; }

        public bool UpOrDown { get; set; }

        public DateTime CreatedAt { get; set; }

        public Post Post { get; set; }



    }
}
