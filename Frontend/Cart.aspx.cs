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

            if (Session["LoggedInUserID"] == null)
            {
                // If the user is not logged in, redirect them to the login page
                Response.Redirect("Login.aspx");
            }
            else
            {
                // Assuming you have a method in your service reference to get the total cart price
                // Replace 'GetTotalCartPrice' with the actual method name in your service reference
                int clientId = GetClientId();

                decimal totalCartPrice = sr.GetTotalCartPrice(clientId);

                // Format the total cart price as currency (e.g., "R 123.45")
                string formattedTotalPrice = string.Format("R {0:N2}", totalCartPrice);

                // Set the formatted total cart price to the TotalLabel
                TotalLabel.Text = formattedTotalPrice;

                ProceedToCheckoutLink.NavigateUrl = "Checkout.aspx";

                BindCartData();
            }
        }

        protected void CartTable_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart" || e.CommandName == "RemoveFromCart")
            {
                // Get the product ID from the CommandArgument
                int productId = Convert.ToInt32(e.CommandArgument);

                // Determine the action and amount (1 for add, -1 for remove)
                string action = e.CommandName == "AddToCart" ? "ADD" : "REMOVE";
                int amount = e.CommandName == "AddToCart" ? 1 : -1;

                // Get the user ID (you might have your own method to do this)
                int userId = GetClientId();

                // Call the AddRemoveProductFromCart method with the appropriate parameters
                sr.AddRemoveProductFromCart(productId, userId, action, amount);

                // Refresh the cart or update the UI as needed
                // For example, you can rebind the cart data to the repeater here
                BindCartData(); // Implement this method to rebind cart data
            }
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


        protected void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            // Get the product ID from the sender button's CommandArgument
            Button btnRemove = (Button)sender;
            int productId = Convert.ToInt32(btnRemove.CommandArgument);

            // Specify the user ID (you might have your own method to do this)
            int userId = GetClientId();

            // Specify the quantity to remove (e.g., 1)
            int quantityToRemove = 1; // You can adjust this based on your UI

            // Call the backend service method to remove the product from the cart
            sr.RemoveProductFromCart(productId, userId, quantityToRemove);

            // Refresh the cart or update the UI as needed
            BindCartData(); // Implement this method to rebind cart data
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




        // Method to bind the cart items to the table
        private void BindCartData()
        {
            // Assuming you have a method to get the cart items, like GetAllCartItemsForClient
            int clientId = GetClientId(); // Get the client ID (you might have your own method for this)
            BackendReference.Cart[] cartItems = sr.GetAllCartItemsForClient(clientId);


            // Bind the cart data to the repeater
            CartTable.DataSource = cartItems;
            CartTable.DataBind();

            // Calculate and display the total cart price
            decimal totalCartPrice = sr.GetTotalCartPrice(clientId);
            TotalLabel.Text = string.Format("R {0:F2}", totalCartPrice); // Format the total price as needed
        }



    }
}