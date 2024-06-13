using System.ComponentModel.DataAnnotations;

namespace GreenDefined.DTOs.Posts
{
    public class AddPostDTO
    {
        public string UserId { get; set; }
        public string PostValue { get; set; }
       
        public IFormFile? PostImage { get; set; }

    }
}
