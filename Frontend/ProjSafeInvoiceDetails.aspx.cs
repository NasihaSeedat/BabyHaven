using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;

namespace Frontend
{
    public partial class ProjSafeInvoiceDetails : System.Web.UI.Page
    {
        BabyHavenServiceClient sr = new BabyHavenServiceClient();
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
                string note = (string)Session["Note"];

                // Populate the labels with the retrieved invoice details
                OrderIdLabel.Text = "<b>Order ID:</b> " + selectedInvoiceId.ToString();
                TotalAmountLabel.Text = "<b>Total Amount:</b> R " + selectedInvoiceTotalAmount.ToString("N2");
                DateLabel.Text = "<b>Date:</b> " + selectedInvoiceDate.ToString("yyyy-MM-dd");

                // Populate other labels with additional invoice details
                FirstNameLabel.Text = "<b>First Name:</b> " + firstname;
                LastNameLabel.Text = "<b>Last Name:</b> " + lastname;
                EmailLabel.Text = "<b>Email:</b> " + email;
                AddressLabel.Text = "<b>Address:</b> " + address;
                CityLabel.Text = "<b>City:</b> " + city;
                ZipCodeLabel.Text = "<b>Zip Code:</b> " + zipcode;
                PhoneNumberLabel.Text = "<b>Phone Number:</b> " + phoneno;
                NoteLabel.Text = "<b>Note:</b> " + note;

                BindOrderData();
            }
        }
        public string GetProductImage(object productId)
        {
            int productID = Convert.ToInt32(productId);
            // Call the backend service to get the product name based on the productID
            return sr.GetProductImage(productID);
        }

        public string GetProductName(object productId)
        {
            int productID = Convert.ToInt32(productId);
            // Call the backend service to get the product name based on the productID
            return sr.GetProductName(productID);
        }

        public string GetProductPrice(object productId)
        {
            int productID = Convert.ToInt32(productId);

            // Call the backend service to get the product price based on the productID and quantity
            decimal productPrice = sr.GetProductPrice(productID);

            // Return the total price formatted as currency
            return productPrice.ToString("C");
        }

        public string GetProductTotal(object productId)
        {
            int productID = Convert.ToInt32(productId);

            // Call the backend service to get the product price based on the productID and quantity
            decimal productPrice = sr.GetProductPrice(productID);

            // Return the total price formatted as currency
            return productPrice.ToString("C");
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

        private void BindOrderData()
        {
            // Assuming you have a method to get the cart items, like GetAllCartItemsForClient
            int selectedInvoiceId = (int)Session["SelectedInvoiceId"];
            BackendReference.Order_Item[] orderItems = sr.GetOrderItems(selectedInvoiceId);


            // Bind the cart data to the repeater
            OrderTable.DataSource = orderItems;
            OrderTable.DataBind();

        }
    }
}