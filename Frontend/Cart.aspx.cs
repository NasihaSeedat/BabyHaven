using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Frontend
{
    public partial class Cart : System.Web.UI.Page
    {
        BackendReference.BabyHavenServiceClient sr = new BackendReference.BabyHavenServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Assuming you have a method in your service reference to get the total cart price
                // Replace 'GetTotalCartPrice' with the actual method name in your service reference
                int clientId = GetClientId(); // Implement GetClientId method to get the client ID
                decimal totalCartPrice = sr.GetTotalCartPrice(clientId);

                // Format the total cart price as currency (e.g., "R 123.45")
                string formattedTotalPrice = string.Format("R {0:N2}", totalCartPrice);

                // Set the formatted total cart price to the TotalLabel
                TotalLabel.Text = formattedTotalPrice;
            }
        }

        private int GetClientId()
        {
            if (Session["ClientId"] != null)
            {
                return (int)Session["ClientId"];
            }
            else
            {
                // Handle the case where the client ID is not found in the session (e.g., redirect to login)
                Response.Redirect("Login.aspx"); // Redirect to your login page
                return 0; // Return a default value or throw an exception
            }
        }


        protected void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            //have to create function in backend for this
        }



        // Method to bind the cart items to the table
        //private void BindCart()
        //{
        //    CartTable.DataSource = cartItems;
        //    CartTable.DataBind();
        //}


    }
}