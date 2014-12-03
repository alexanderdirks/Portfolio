using System.Configuration;
using System.Net.Mail;


namespace Portfolio.Library
{
    public class Email
    {
        public void Send(Contact contact)
        {
            MailMessage mail = new MailMessage(
                contact.From,
                //ConfigurationManager.AppSettings[Keys.ContactToEmail],
                "alexanderdirks@hotmail.com",
                contact.Subject,
                contact.Message);
            new SmtpClient("jhdc01.phibred.com").Send(mail);
        }
    }

    public class Contact
    {
        public string From { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }

}