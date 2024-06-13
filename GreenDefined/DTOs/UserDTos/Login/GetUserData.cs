namespace GreenDefined.DTOs.UserDTos.Login
{
    public class GetUserData
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string userId { get; set; }
        public string? imageUrl { get; set; }

        public string? Bio { get; set; }
        public string? Country { get; set; }
    }
}
