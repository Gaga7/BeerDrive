using BeerDrive.DAL.Commons;
using BeerDrive.DAL.Cryptography;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace BeerDrive.DAL.Implementations.Services
{
    public class EmailService
    {
        public static bool Send(string mailTo, string message)
        {
            using (MailMessage mail = new MailMessage())
            {
                var mailFrom = ConfigurationManager.AppSettings["EmailFrom"];
                var password = StringCipher.Decrypt(ConfigurationManager.AppSettings["Password"]);
                //var mailTo = ConfigurationManager.AppSettings["EmailTo"];

                //var code = RandomCodeGenerator.GetNumber(4);

                if (string.IsNullOrEmpty(mailFrom) ||
                    string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(mailTo) /*||*/
                    /*string.IsNullOrEmpty(code)*/)
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

                    smtp.Send(mail);
                }

                return true;
            }
        }
    }
}
