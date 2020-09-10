using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace SendEmail
{
    class InforSMTPServer
    {
        public string strHost;
        public bool EnableSsl;
        public int port;
    }
    class clsEmail
    {
        public static InforSMTPServer getInforSMTP()
        {
            InforSMTPServer obj = new InforSMTPServer();
            obj.strHost = SendEmail.Properties.Settings.Default.strHost;
            obj.EnableSsl = SendEmail.Properties.Settings.Default.EnableSsl;
            obj.port = SendEmail.Properties.Settings.Default.port;
            return obj;
        }
        public static bool SaveInforSMTP(InforSMTPServer obj)
        {
          bool kq=false;
            try
            {
                SendEmail.Properties.Settings.Default.strHost = obj.strHost;
                SendEmail.Properties.Settings.Default.EnableSsl=obj.EnableSsl;
                SendEmail.Properties.Settings.Default.port=obj.port;
                SendEmail.Properties.Settings.Default.Save();
                kq=true;
            }
            catch(Exception e)
            {
                kq=false;
            }
          return kq;
        }
        public static int GoiMailSMTP(InforSMTPServer objSMTP, string diaChiEmailGui, string matKhauEmailGui, string diachiNhanEmail, string tieudeEmail, string strHeader, string noidungEmail, string strFooter)
        {
            SmtpClient MyServer = new SmtpClient(); //created object of SmtpClient details and provides server details
            MyServer.Host = objSMTP.strHost;
            MyServer.EnableSsl = objSMTP.EnableSsl;
            MyServer.Port = objSMTP.port;
            NetworkCredential NC = new NetworkCredential(); //Server Credentials
            NC.UserName = diaChiEmailGui;
            NC.Password = matKhauEmailGui;
            MyServer.Credentials = NC; //assigned credetial details to server
            MailAddress from = new MailAddress(diaChiEmailGui, "Thông tin");//create sender address
            MailAddress receiver = new MailAddress(diachiNhanEmail, diachiNhanEmail);
            MailMessage Mymessage = new MailMessage(from, receiver);
            Mymessage.BodyEncoding = UTF8Encoding.UTF8;
            Mymessage.IsBodyHtml = true;
            Mymessage.Subject = tieudeEmail;
            Mymessage.Body = strHeader + "<br>" + noidungEmail + strFooter;
            MyServer.Send(Mymessage);   //sends the email
            return (1);
        }



    }
}
