namespace PixiStash.Core.Models
{
    public class UserProfile
    {
        public Guid UserProfileId { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string OldPassword { get; set; }
        public string ProfilePicture { get; set; } = "/upload/blank-person.png";

        public string? ApplicationUserId { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
