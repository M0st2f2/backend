using System.ComponentModel.DataAnnotations;

namespace GreenDefined.DTOs.UserDTos.Password
{
    public class AddNewPasswordDTO
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(4)]

        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [MinLength(4)]

        public string ConfirmPassword { get; set; }
    }
}
