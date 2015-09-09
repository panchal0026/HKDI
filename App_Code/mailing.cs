using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;
using System.Configuration;

/// <summary>
/// Summary description for mailing
/// </summary>
/// 

    public class mailing
    {
        //public void sendMail(string fsSubject,string fsBody,string  fsToEmail)
        //{
        //    MailMessage mailmsg = new MailMessage();
        //    SmtpClient smtpclient = new SmtpClient();
        //    StringBuilder strBuild = new StringBuilder();

        //    smtpclient.UseDefaultCredentials = false;
        //    smtpclient.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["UserName"],ConfigurationManager.AppSettings["Password"]);
        //    smtpclient.Host = ConfigurationManager.AppSettings["SmtpServer"];
        //    smtpclient.Port = Convert.ToInt32(ConfigurationManager.AppSettings["PortNo"]);


        //    smtpclient.EnableSsl = true;

        //    mailmsg.From = new MailAddress(ConfigurationManager.AppSettings["UserName"],"HKDI");
			
        //    //
        //    // TODO: Add constructor logic here
        //     mailmsg.Subject = fsSubject;
        //    mailmsg.IsBodyHtml = true;
        //    mailmsg.BodyEncoding = System.Text.Encoding.UTF8;
        //    mailmsg.Body = fsBody;
			
        //    smtpclient.Send(mailmsg);

        //    mailmsg.Dispose();
		
        //}


        public string SendEmail(string toAddress, string subject, string body)
        {
            string result = "Message Sent Successfully..!!";
            string senderID = ConfigurationManager.AppSettings["UserName"].ToString();// use sender’s email id here..
            string senderPassword = ConfigurationManager.AppSettings["Password"].ToString(); // sender password here…
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com", // smtp server address here…
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = 30000,
                };
                MailMessage message = new MailMessage(senderID, toAddress, subject, body);
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                result = "Error sending email.!!!";
            }
            return result;
        }
	}
        