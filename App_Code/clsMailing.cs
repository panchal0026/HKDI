using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;
using System.Configuration;

/// <summary>
/// Summary description for clsMailing
/// </summary>
public class clsMailing
{
	public clsMailing()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void sendMail(string fsSubject,string fsBody,string  fsToEmail)
        {
            MailMessage mailmsg = new MailMessage();
            SmtpClient smtpclient = new SmtpClient();
            StringBuilder strBuild = new StringBuilder();

            smtpclient.UseDefaultCredentials = false;
            smtpclient.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["Admin"],
				ConfigurationManager.AppSettings["Password"]);
            smtpclient.Host = ConfigurationManager.AppSettings["SmtpServer"];
            smtpclient.Port = Convert.ToInt32(ConfigurationManager.AppSettings["PortNo"]);


            smtpclient.EnableSsl = false;

            mailmsg.From = new MailAddress("pooja@gmail.com", "callms");
			
            //
            // TODO: Add constructor logic here
             mailmsg.Subject = fsSubject;
			mailmsg.IsBodyHtml = true;
			mailmsg.BodyEncoding = System.Text.Encoding.UTF8;
			mailmsg.Body = fsBody;
			smtpclient.Send(mailmsg);

			mailmsg.Dispose();
		}
	}
