using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the cart items, subtotal, tax, discount, and total here.
                // For demonstration purposes, we'll use sample data.
                rptCartItems.DataSource = GetSampleCartItems();
                rptCartItems.DataBind();

                decimal subtotal = CalculateSubtotal();
                decimal tax = CalculateTax(subtotal);
                decimal discount = CalculateDiscount(subtotal);
                decimal total = CalculateTotal(subtotal, tax, discount);

                // Set the text for the labels
                lblSubtotal.InnerText = subtotal.ToString("C");
                lblTax.InnerText = tax.ToString("C");
                lblDiscount.InnerText = discount.ToString("C");
                lblTotal.InnerText = total.ToString("C");
            }
        }

        // Event handler for the "Place Order" button click event
        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Perform order processing logic here (e.g., store the order in the database, send confirmation email, etc.)
            // For this simplified example, we'll display a confirmation message.
            lblConfirmationMessage.Text = "Your order has been placed successfully!";
            lblConfirmationMessage.Visible = true; // Make the label visible
        }

        // Sample method to get cart items (replace with your actual data source)
        private CartItem[] GetSampleCartItems()
        {
            return new CartItem[]
            {
            new CartItem("Product 1", 100.0),
            new CartItem("Product 2", 50.0),
            new CartItem("Product 3", 30.0)
            };
        }

        // Sample methods for calculation (replace with your logic)
        private decimal CalculateSubtotal()
        {
            return 180.0m; // Use 'm' to specify a decimal literal
        }

        private decimal CalculateTax(decimal subtotal)
        {
            decimal taxRate = 0.15m; // Use 'm' to specify a decimal literal for the tax rate (15%)
            return subtotal * taxRate;
        }

        private decimal CalculateDiscount(decimal subtotal)
        {
            decimal discountRate = 0.05m; // Use 'm' to specify a decimal literal for the discount rate (5%)
            return subtotal * discountRate;
        }


        private decimal CalculateTotal(decimal subtotal, decimal tax, decimal discount)
        {
            return subtotal + tax - discount; // Replace with your logic to calculate total.
        }
    }

}