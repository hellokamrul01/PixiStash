using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using PixiStash.Shared.Models;
namespace PixiStash.Shared
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSenderOptions _emailSenderOptions;

        public EmailSender(IOptions<EmailSenderOptions> emailSenderOptions)
        {
            _emailSenderOptions = emailSenderOptions.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Implement email sending logic here
            // For example, using SMTP or a third-party email service
            // Return a Task to comply with the IEmailSender interface
            return Task.CompletedTask;
        }
        //public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        //{
        //    var smtpClient = new SmtpClient(_emailSenderOptions.SmtpServer)
        //    {
        //        Port = _emailSenderOptions.SmtpPort,
        //        Credentials = new NetworkCredential(_emailSenderOptions.UserName, _emailSenderOptions.Password),
        //        EnableSsl = true,
        //    };

        //    var mailMessage = new MailMessage
        //    {
        //        From = new MailAddress(_emailSenderOptions.FromEmail),
        //        Subject = subject,
        //        Body = htmlMessage,
        //        IsBodyHtml = true,
        //    };

        //    mailMessage.To.Add(email);

        //    await smtpClient.SendMailAsync(mailMessage);
        //}
    }

}



