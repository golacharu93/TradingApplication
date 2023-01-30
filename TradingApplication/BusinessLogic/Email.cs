using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace TradingApplication.BusinessLogic
{
    public class Email
    {
        public bool SendMail(string Name, string Email)
        {

            try
            {
                var senderEmail = new MailAddress("charutagola9@gmail.com", "Mail From Trading Department");
                var receiverEmail = new MailAddress(Email, "Receiver");
                var password = "kiclmjqgydjgnafj";
                var sub = "Validate your trading Account";
                var   MyURL = "http://localhost:19453/Registration/ValidateEmail?EmailId="+ Email;

                string body = (@"<html>
                     
                      Dear " + Name + ", <p>Click on the below link to validate your account.</p> <p><a href='"+MyURL+"'></br></br><button>Validate Your Account</button></a></p>" +
                          "<p>     </p></br></br> </html>");
           
            var smtp = new SmtpClient
                {

                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password),
                   

            };
           
            using (var mess = new MailMessage(senderEmail, receiverEmail)

                {

                    Subject = sub,
                    Body = body,
                    IsBodyHtml = true

                })
                {
             smtp.UseDefaultCredentials = false;
                    smtp.Send(mess);

                   
                }
           }
            catch (Exception)
            {
              string err = "Error Message: " + "Facing Some Technical Error In Sending Mail";
           }

            return true;
        }
           
        
    }
}
