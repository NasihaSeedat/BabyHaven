using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;
namespace Frontend
{
    public partial class Invoices : System.Web.UI.Page
    {
        BabyHavenServiceClient sr = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindInvoiceData();
            }
        }

        private void BindInvoiceData()
        {
            int userId = GetClientId();

            // Call the service method to retrieve user's purchase history
            Order_Table[] invoices = sr.GetAllInvoices(userId);

            // Bind the data to the Repeater control
            InvoicesRepeater.DataSource = invoices;
            InvoicesRepeater.DataBind();
        }

        private int GetClientId()
        {
            if (Session["LoggedInUserID"] != null)
            {
                return Convert.ToInt32(Session["LoggedInUserID"]);
            }
            else
            {
                // Handle the case where the client ID is not found in the session (e.g., redirect to login)
                Response.Redirect("Login.aspx"); // Redirect to your login page
                return 0; // Return a default value or throw an exception
            }
        }

        protected void DownloadPdfButton_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(((Button)sender).CommandArgument);

            // Retrieve the selected invoice details
            Order_Table selectedInvoice = sr.GetInvoiceDetails(orderId);

            // Store the selected invoice details in session variables
            Session["SelectedInvoiceId"] = selectedInvoice.O_Id;
            Session["SelectedInvoiceTotalAmount"] = selectedInvoice.O_Total;
            Session["SelectedInvoiceDate"] = selectedInvoice.O_Date;


            // Store other values from the selected invoice as session variables
            Session["FirstName"] = selectedInvoice.First_Name;
            Session["LastName"] = selectedInvoice.Last_Name;
            Session["Email"] = selectedInvoice.O_Email;
            Session["Address"] = selectedInvoice.O_Address;
            Session["City"] = selectedInvoice.O_City;
            Session["ZipCode"] = selectedInvoice.O_ZipCode;
            Session["PhoneNumber"] = selectedInvoice.O_Phone_Number;


            // Redirect to the InvoiceDetails.aspx page
            Response.Redirect("InvoiceDetails.aspx");
        }
    }
}