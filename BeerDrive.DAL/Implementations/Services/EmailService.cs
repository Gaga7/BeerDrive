using BeerDrive.DAL.Commons;
using BeerDrive.DAL.Cryptography;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BeerDrive.DAL.Implementations.Services
{
    public class EmailService
    {
        public static bool Send(string mailTo, string message)
        {
            return SendAsync(mailTo, message).GetAwaiter().GetResult();
        }

        public static async Task<bool> SendAsync(string mailTo, string message)
        {
            using (MailMessage mail = new MailMessage())
            {
                var mailFrom = ConfigurationManager.AppSettings["EmailFrom"];
                var password = StringCipher.Decrypt(ConfigurationManager.AppSettings["Password"]);

                if (string.IsNullOrEmpty(mailFrom) ||
                    string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(mailTo))
                    return false;

                mail.From = new MailAddress(mailFrom);
                mail.To.Add(mailTo);
                mail.Subject = "One Time Code";
                mail.Body = message;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(mailFrom, password);
                    smtp.EnableSsl = true;

                    await smtp.SendMailAsync(mail);
                }

                return true;
            }
        }
    }
}
