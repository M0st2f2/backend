namespace GreenDefined.DTOs.UserDTos.Edit
{
    public class EditProfileDTO
    {
        public string id { get; set; }

        public string FullName { get; set; }

        public string? Bio { get; set; }

        public string? Country { get; set; }

        public IFormFile? ProfileImage { get; set; }

    }
}
