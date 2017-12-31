using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace EmailSendingDemo.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //HERE IS FUNCTION FOR EMAIL SENDING CODE
        public void SendEmailDemo()
        {
            try
            {
                //Here need to add system.net.Mail library
                MailMessage dEmail = new MailMessage();
                //here are the attributes those are mandatory for email
                dEmail.Subject = "Test Subject";
                dEmail.Body = "This is my demo email , how are u man?";
                //using below line your email also able to read html text
                dEmail.IsBodyHtml = true;

                dEmail.To.Add(new MailAddress("hassanjee9548@gmail.com")); //receiver Name
                dEmail.CC.Add(new MailAddress("tahirbilalnawaz@gmail.com"));

                dEmail.From = new MailAddress("hassan373635@gmail.com", "Hassan Nawaz");
                //here are we are using smtp sever that is used for sending email

                SmtpClient dSmtp = new SmtpClient();
                //mostly these three ports used for this
                dSmtp.Port = 587; //25,465
                dSmtp.EnableSsl = true;
                //here is google smptp sever link that provides almost 250 free email daily
                dSmtp.Host = "smtp.gmail.com";

                dSmtp.Credentials = new System.Net.NetworkCredential("hassan373635@gmail.com", "Hass+373635");
                dSmtp.Send(dEmail);
            }
            catch(Exception ex)
            {

            }
            }
            
    }
}