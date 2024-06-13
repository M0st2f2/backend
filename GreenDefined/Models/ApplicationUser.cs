using Microsoft.AspNetCore.Identity;

namespace GreenDefined.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        public string? imageUrl { get; set; }


        public string? Country { get; set; }

        public string? ValidationCode { get; set; }

        public int ForgetPasswordOTP { get; set; }

        public string? Bio { get; set; }

        public ICollection<Post> Posts { get; set; }

    }
}
