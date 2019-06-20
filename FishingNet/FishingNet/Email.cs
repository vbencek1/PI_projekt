using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace FishingNet
{
    class Email
    {
        public void PosaljiEmail(string primatelj, string natjecanje)
        {
            string posiljatelj = "fishnet.projekt@gmail.com";
            MailMessage message = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            message.From = new MailAddress(posiljatelj);
            message.To.Add(primatelj);
            message.Subject = "Obavijest o proglašenju pobjednika";
            message.Body = "Čestitamo, pobjednik ste natjecanja " + natjecanje + ".";
            SmtpServer.Port = 587;
            string lozinka = "1234fish";
            SmtpServer.Credentials = new System.Net.NetworkCredential(posiljatelj, lozinka);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(message);
        }
    }
}
