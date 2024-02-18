using System.ComponentModel.DataAnnotations;
namespace PixiStash.Application.DTO.Email
{
    public class MailRequest
    {
        public Guid ComId { get; set; }
        public string[] ToEmail { get; set; }
       
        public string Subject { get; set; } 
      
        public string Body { get; set; }
      
       // public List<IFormFile> Attachments { get; set; }
    }
}
