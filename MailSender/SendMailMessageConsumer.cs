using Entities.Exceptions.MailSend;
using Entities.Messages;
using MassTransit;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace MailSender
{
    public class SendMailMessageConsumer : IConsumer<SendMailMessage>
    {
        private readonly IConfiguration _configuration;

        public SendMailMessageConsumer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Consume(ConsumeContext<SendMailMessage> context)
        {
            var maillAdress = _configuration["MailSettings:mailFrom"];
            var mailPassword = _configuration["MailSettings:password"];
            var message = context.Message;
            var htmlBody = File.ReadAllText("emailTemplate.html");
            try
            {
                var smtpClient = new SmtpClient("smtp.office365.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(maillAdress, mailPassword),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(maillAdress),
                    Subject = message.Subject,
                    Body = htmlBody.Replace("{UserName}", message.UserName),
                    IsBodyHtml = true,
                };

                mailMessage.To.Add(message.Email);

                await smtpClient.SendMailAsync(mailMessage);

                Console.WriteLine($"Mail sent to {message.Email}");
            }
            catch (Exception ex)
            {
                throw new MailSendException($"Error while sending mail to {message.Email}: {ex.Message}");
            }
        }
    }
}