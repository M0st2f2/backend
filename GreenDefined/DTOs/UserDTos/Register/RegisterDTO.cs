using System.ComponentModel.DataAnnotations;

namespace GreenDefined.DTOs.UserDTos.Register
{
    public class RegisterDTO
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(4)]

        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
