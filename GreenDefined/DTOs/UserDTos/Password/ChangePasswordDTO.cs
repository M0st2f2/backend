using System.ComponentModel.DataAnnotations;

namespace GreenDefined.DTOs.UserDTos.Password
{
    public class ChangePasswordDTO
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(4)]
        public string CurrentPassword { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(4)]
        public string NewPassword { get; set; }


    }
}
