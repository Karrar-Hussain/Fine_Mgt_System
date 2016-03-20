using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.IO;
using System.Configuration;
namespace HFMS.Controllers
{
    class SendMail
    {
        private MailMessage mail;
        private SmtpClient SmtpServer;

        private string mailsmtpserver;
        private string mailfrom;
        private string mailpassword;
        private string mailto;
        private string mailsub;
        private string mailbody;
        private int smtpport;
        private bool sendmail;
        public SendMail()
        {

            mailsmtpserver =ConfigurationSettings.AppSettings["mailsmtpserver"];
            smtpport = Convert.ToInt32(ConfigurationSettings.AppSettings["smtpport"]);
            mailfrom = ConfigurationSettings.AppSettings["mailfrom"];
            mailpassword = ConfigurationSettings.AppSettings["mailpassword"];
            mailsub = "Student Fine For Breaking Rules!";
            mailbody = "Thank you for your Contact, We will soon contact you.";

        }
        public void sendMail(String msg,String mailto)
        {

            this.mailto = mailto;
            try
            {
                mail = new MailMessage();
                SmtpServer = new SmtpClient(mailsmtpserver);
                mail.From = new MailAddress(mailfrom);
                mail.To.Add(mailto);
                mail.Subject = mailsub;
                mail.Body = msg;
               
                SmtpServer.Port = smtpport;
                SmtpServer.Credentials = new System.Net.NetworkCredential(mailfrom, mailpassword);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);//Send mail in above conditions are true
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
