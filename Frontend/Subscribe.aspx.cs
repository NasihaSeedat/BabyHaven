using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using Frontend.BackendReference;
namespace Frontend
{
    public partial class Subscribe : System.Web.UI.Page
    {
        //reference to server
        BabyHavenServiceClient sr = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSUB_Click(object sender, EventArgs e)
        {
            
            // Get the email address entered in the text box
            string em = txtEMAIL.Text;
            if (em != null)
            {

                /*
                 * Dear valued customer,

     We would like to express our sincere gratitude for your decision to subscribe to our newsletter. In light of your support, we are thrilled to offer you an exclusive opportunity to enjoy a discount of 10% on your upcoming order. Simply utilize the provided code, "NEWBORN," during the checkout process.

     Thank you once again for your continued patronage.

     Best regards,

     The BabyHaven Team
                 * */
                string mailbody = "<p>Dear valued customer, <br/><br/>  We would like to express our sincere gratitude for your decision to subscribe to our newsletter. <br/>In light of your support, we are thrilled to offer you an exclusive opportunity to enjoy a discount of 10% on your upcoming order." +
                    " <br/>Simply utilize the provided code, '<b>NEWBORN</b>', during the checkout process.<br/>" +
                        " <br/>Thank you once again for your continued patronage.<br/> <br/>Best regards, <br/> <br/>The BabyHaven Team </p><br/><br/>";

         

            string from = "babyhavenproject@gmail.com";

            // Create a MailMessage object
            MailMessage message = new MailMessage(from,em);
            message.Subject = "THANK YOU!";

            message.Body = mailbody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            NetworkCredential basicCredential1 = new NetworkCredential("babyhavenproject@gmail.com", "njep iabn bkip khgf");


            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;

                try
                {
                    client.Send(message);
                    
                }

                catch (Exception ex)
                {
                    
                    throw ex;
                }
            }
            else
            {

            }
        }
    }
}