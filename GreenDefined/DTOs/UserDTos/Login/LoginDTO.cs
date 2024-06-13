using System.ComponentModel.DataAnnotations;

namespace GreenDefined.DTOs.UserDTos.Login
{
    public class LoginDTO
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(4)]
        public string Password { get; set; }
    }
}
