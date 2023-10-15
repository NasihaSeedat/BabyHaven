using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend {
    public partial class AdminNewsletter : System.Web.UI.Page {

        BabyHavenServiceClient sc = new BabyHavenServiceClient();

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void sendButton_Click(object sender, EventArgs e) {
            string subject = subjectTextBox.Value;
            string body = bodyTextBox.Value;

            // Get the list of subscribed users' email addresses from your database
            List<string> subscribedEmails = GetSubscribedEmails();

            foreach(string email in subscribedEmails) {
                SendEmail(email, subject, body);
            }

            confirmationLabel.Text = "Emails sent to subscribed users successfully!";
            confirmationLabel.Visible = true;
        }

        private List<string> GetSubscribedEmails() {
            string[] subscribedEmailsArray = sc.GetSubscribedEmails();

            // Convert the string array to a List<string>
            List<string> subscribedEmails = subscribedEmailsArray.ToList();

            return subscribedEmails;
        }


        private void SendEmail(string recipientEmail, string subject, string body) {
            try {

                string from = "babyhavenproject@gmail.com";

                MailMessage message = new MailMessage(from, recipientEmail);
                message.Subject = subject;
                message.Body = body;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                NetworkCredential basicCredential = new NetworkCredential("babyhavenproject@gmail.com", "njep iabn bkip khgf");

                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential;

                client.Send(message);
            } catch(Exception ex) {
                ex.GetBaseException();
            }
        }


    }
}