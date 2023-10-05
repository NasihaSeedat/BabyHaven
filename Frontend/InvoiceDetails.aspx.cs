using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class InvoiceDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["LoggedInUserID"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                // Retrieve invoice details from session variables
                int selectedInvoiceId = (int)Session["SelectedInvoiceId"];
                decimal selectedInvoiceTotalAmount = (decimal)Session["SelectedInvoiceTotalAmount"];
                DateTime selectedInvoiceDate = (DateTime)Session["SelectedInvoiceDate"];

                // Store other values from the selected invoice as session variables
                String firstname = (string)Session["FirstName"];
                String lastname = (string)Session["LastName"];
                String email = (string)Session["Email"];
                String address = (string)Session["Address"];
                String city = (string)Session["City"];
                String zipcode = (string)Session["ZipCode"];
                String phoneno = (string)Session["PhoneNumber"];

                // Populate the labels with the retrieved invoice details
                OrderIdLabel.Text = "Order ID: " + selectedInvoiceId.ToString();
                TotalAmountLabel.Text = "Total Amount: R " + selectedInvoiceTotalAmount.ToString("N2");
                DateLabel.Text = "Date: " + selectedInvoiceDate.ToString("yyyy-MM-dd");

                // Populate other labels with additional invoice details
                FirstNameLabel.Text = "First Name: " + firstname;
                LastNameLabel.Text = "Last Name: " + lastname;
                EmailLabel.Text = "Email: " + email;
                AddressLabel.Text = "Address: " + address;
                CityLabel.Text = "City: " + city;
                ZipCodeLabel.Text = "Zip Code: " + zipcode;
                PhoneNumberLabel.Text = "Phone Number: " + phoneno;
            }
        }
    }
}