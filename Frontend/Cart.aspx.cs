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
        // List to store cart items
        private List<CartItem> cartItems = new List<CartItem>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Bind the cart items to the table
                BindCart();
            }
        }

        // Method to add a product to the shopping cart
        protected void AddToCartButton_Click(object sender, EventArgs e)
        {
            // Get the product details from your database or wherever you have them
            string productId = "123"; // Replace with the actual product ID
            string productName = "Sample Product";
            decimal productPrice = 10.00M; // Replace with the actual product price

            // Create a cart item and add it to the list
            CartItem cartItem = new CartItem(productId, productName, productPrice, 1);
            cartItems.Add(cartItem);

            // Update the cart table
            BindCart();
        }

        protected void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            // Get the product ID to remove
            string productIdToRemove = ((Button)sender).CommandArgument;

            // Remove the item from the cart based on the product ID
            cartItems.RemoveAll(item => item.ProductId == productIdToRemove);

            // Update the cart table
            BindCart();
        }



        // Method to bind the cart items to the table
        private void BindCart()
        {
            CartTable.DataSource = cartItems;
            CartTable.DataBind();
        }

        protected void UpdateCartButton_Click(object sender, EventArgs e)
        {
            // Get the product ID to update
            string productIdToUpdate = ((Button)sender).CommandArgument;

            // Find the cart item based on the product ID
            CartItem cartItemToUpdate = cartItems.Find(item => item.ProductId == productIdToUpdate);

            // Find the TextBox for quantity using the sender's parent control
            TextBox quantityTextBox = (TextBox)((Button)sender).NamingContainer.FindControl("QuantityTextBox");

            // Update the quantity from the TextBox
            int newQuantity;
            if (int.TryParse(quantityTextBox.Text, out newQuantity))
            {
                cartItemToUpdate.Quantity = newQuantity;
            }

            // Update the cart table
            BindCart();
        }


    }
}