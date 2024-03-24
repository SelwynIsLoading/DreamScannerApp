using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace DreamScannerApp.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmail(EmailDTO email)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Sender", email.SenderEmail));
                message.To.Add(new MailboxAddress("Recipient", email.RecipientEmail));
                message.Subject = email.Subject;

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Please find attached the student log Excel file.";

                var attachment = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(new MemoryStream(email.AttachmentData), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = email.AttachmentFileName
                };

                bodyBuilder.Attachments.Add(attachment);
                message.Body = bodyBuilder.ToMessageBody();

                using (var smtpClient = new SmtpClient())
                {
                    await smtpClient.ConnectAsync("smtp.gmail.com", 587, false);
                    await smtpClient.AuthenticateAsync(email.SenderEmail, email.SenderPassword);
                    await smtpClient.SendAsync(message);
                    await smtpClient.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to send email.", ex);
            }
        }
    }
}
