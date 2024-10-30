using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace FashionShop.Areas.Identity
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(IOptions<EmailSettings> emailSettings, ILogger<EmailSender> logger)
        {
            _emailSettings = emailSettings.Value;
            _logger = logger;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_emailSettings.SmtpServer, _emailSettings.SmtpPort)
            {
                Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_emailSettings.SenderEmail, _emailSettings.SenderName),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            mailMessage.To.Add(email);

            try
            {
                await client.SendMailAsync(mailMessage);
            }
            catch (SmtpException ex)
            {
                _logger.LogError(ex, "Error sending email to {Email}", email);
                throw new Exception("Failure sending mail.", ex);
            }
            catch (SocketException ex)
            {
                _logger.LogError(ex, "Socket error while sending email to {Email}", email);
                throw new Exception("Socket error while sending mail.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error while sending email to {Email}", email);
                throw;
            }
        }
    }
}