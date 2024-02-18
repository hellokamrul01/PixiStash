namespace PixiStash.Application.DTO.Auth
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }    
    }
}
