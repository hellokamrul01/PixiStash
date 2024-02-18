namespace PixiStash.Application.DTO.Email
{
    public class ProjectInviteMail
    {
        public Guid? ComId { get; set; }
        public Guid? Pid { get; set; }   
        public string[] ToEmail { get; set; }
       // [ValidateNever]
        public string Subject { get; set; } 
       // [ValidateNever]
        public string Body { get; set; }
       // [ValidateNever]
       // public List<IFormFile> Attachments { get; set; }
    }
}
