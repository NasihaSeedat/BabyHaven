using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class Checkout : System.Web.UI.Page
    {
        BabyHavenServiceClient sc = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Attach the event handler to the button click event
                btnApplyCoupon.Click += btnApplyCoupon_Click;

                if(Session["TotalCartPriceWithVAT"] != null) {
                    decimal subtotal = (decimal)Session["TotalCartPriceWithVAT"];
                    lblSubtotal.InnerText = string.Format("R {0:N2}", subtotal);

                    decimal discount = CalculateDiscount();
                    decimal total = CalculateTotal(subtotal, discount);

                    lblDelivery.InnerText = ("R 0.00");
                    lblDiscount.InnerText = string.Format("R {0:N2}", discount);
                    lblTotal.InnerText = string.Format("R {0:N2}", total);
                }
                else {
                    Response.Redirect("Cart.aspx");
                }
            }
        }

        // Event handler for the "Place Order" button click event
        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int userId = GetClientId();

            decimal subtotal = (decimal)Session["TotalCartPriceWithVAT"];
            decimal discount = CalculateDiscount();
            decimal total = CalculateTotal(subtotal, discount);

            // Retrieve values from textboxes
            string o_firstName = txtFirstName.Value;
            string o_lastName = txtLastName.Value;
            string o_address = txtStreetAddress.Value;
            string o_city = txtCity.Value;
            string o_zipCode = txtZip.Value;
            string o_phoneNumber = txtPhone.Value;
            string o_email = txtEmail.Value;

            // Call the Checkout function to create the order
            int orderId = sc.Checkout(userId, total, o_firstName, o_lastName, o_email, o_address, o_city, o_zipCode, o_phoneNumber);

            if(orderId > 0) {
                // Call the ProcessCheckout method to clear the cart and move products to Purchase_History
                ProcessCheckout(userId);

                // Optionally, you can redirect to a confirmation page or perform other actions.
                Response.Redirect("ThankYou.aspx");
            }
            else {
                lblConfirmationMessage.Text = "An error occured placing your order";
                lblConfirmationMessage.Visible = true; // Make the label visible
            }
        }

        private int GetClientId() {
            if(Session["LoggedInUserID"] != null) {
                return Convert.ToInt32(Session["LoggedInUserID"]);
            }
            else {
                // Handle the case where the client ID is not found in the session (e.g., redirect to login)
                Response.Redirect("Login.aspx"); // Redirect to your login page
                return 0; // Return a default value or throw an exception
            }
        }

        private void ProcessCheckout(int userId) {
            // Retrieve the list of product IDs in the user's cart (you need to implement this)
            List<int> cartProductIds = GetCartProductIds(userId);

            // Call the ProcessCheckout method with an array parameter
            sc.ProcessCheckout(userId, cartProductIds.ToArray());
        }

        // Add the GetCartProductIds method here to retrieve the list of product IDs from the cart
        private List<int> GetCartProductIds(int userId) {
            int[] productIdsArray = sc.GetCartProductIds(userId);
            List<int> productIdsList = productIdsArray.ToList();
            return productIdsList;
        }

        private decimal CalculateDiscount() {
            decimal subtotal = (decimal)Session["TotalCartPriceWithVAT"];
            string discountCode = txtCouponCode.Value;
            decimal discountRate = 0.00m; // Default discount rate

            // Check the discount code and set the discount rate accordingly
            if(!string.IsNullOrEmpty(discountCode)) {
                // You can define specific discount codes and their corresponding rates here
                if(discountCode.Equals("DELTA", StringComparison.OrdinalIgnoreCase)) {
                    discountRate = 0.05m; // 10% discount for CODE1
                }
                else if(discountCode.Equals("BABYHAVEN", StringComparison.OrdinalIgnoreCase)) {
                    discountRate = 0.20m; // 20% discount for CODE2
                }
                // Add more conditions for other discount codes as needed
            }

            return subtotal * discountRate;
        }

        private decimal CalculateTotal(decimal subtotal, decimal discount)
        {
            return subtotal - discount; // Replace with your logic to calculate total.
        }

        protected void btnApplyCoupon_Click(object sender, EventArgs e) {
            // Get the coupon code from the text box
            string couponCode = txtCouponCode.Value;

            // Call your CalculateDiscount method to calculate the discount based on the coupon code
            decimal discountAmount = CalculateDiscount();

            // Update the UI to display the discount
            lblDiscount.InnerText = string.Format("R {0:N2}", discountAmount);

            // You may need to update other totals (e.g., subtotal, delivery, total) as well based on the discount.

            // Finally, update the UI to reflect the changes
            UpdateUI();
        }

        private void UpdateUI() {
            decimal subtotal = (decimal)Session["TotalCartPriceWithVAT"];
            decimal discount = CalculateDiscount();
            decimal total = CalculateTotal(subtotal, discount);

            // Update the subtotal, discount, and total labels
            lblSubtotal.InnerText = string.Format("R {0:N2}", subtotal);
            lblDiscount.InnerText = string.Format("R {0:N2}", discount);
            lblTotal.InnerText = string.Format("R {0:N2}", total);

            // Optionally, you can also update the delivery cost if applicable
            lblDelivery.InnerText = ("R 0.00");
        }

    }

}