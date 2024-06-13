namespace GreenDefined.DTOs.UserDTos.Login
{
    public class LoginResponseDTO
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string userId { get; set; }
        public string Token { get; set; }
        public string? imageUrl { get; set; }
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }

        public string? Bio {  get; set; }
        public string? Country { get; set; }
        public DateTime Expier { get; set; }

    }
}
