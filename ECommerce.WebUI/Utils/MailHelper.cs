using ECommerce.Core.Entities;
using System.Net;
using System.Net.Mail;

namespace ECommerce.WebUI.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Contact contact)
        {
           using SmtpClient smtpClient = new SmtpClient("elen-kocak@hotmail.com",587);
            smtpClient.Credentials = new NetworkCredential("elen-kocak@hotmail.com", "mailşifresi");
            smtpClient.EnableSsl = false;
            MailMessage message = new();
            message.From = new MailAddress("elen-kocak@hotmail.com");
            message.To.Add("send@siteadi.com");
            message.Subject = "Message came from website";
            message.Body = $"Name:{contact.Name} - Surname{contact.Surname} -Email:{contact.Email} - Phone{contact.Phone} -Message{contact.Message}";
            ;
            message.IsBodyHtml = true;
            await smtpClient.SendMailAsync(message);    
            
        }
    }
}
