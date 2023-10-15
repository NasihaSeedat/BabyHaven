using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

                    //if(subtotal >= 2000.00m) {
                    //    lblDelivery.InnerHtml = "<s>R 100.00</s> Free Delivery";
                    //}
                    //else {
                    //    lblDelivery.InnerText = "R 100.00";
                    //}

                    int uid = Convert.ToInt32(Session["LoggedInUserID"]);

                    if (subtotal >= 2000.00m)
                    {
                        lblDelivery.InnerHtml = "<s>R 100.00</s> Free Delivery";
                    }else if (sc.isSafeHavenSock(uid) == true)
                    {
                        lblDelivery.InnerHtml = "<s>R 100.00</s> Free Delivery";
                    }
                    else
                    {
                        lblDelivery.InnerText = "R 100.00";
                    }


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

            // Retrieve the notes from the textarea
            string o_note = txtNotes.Value;

             
            // If notes are not provided, set it to "No note provided"
            if(string.IsNullOrEmpty(o_note)) {
                o_note = "No note provided";
            }

            // Call the Checkout function to create the order
            int orderId = sc.Checkout(userId, total, o_firstName, o_lastName, o_email, o_address, o_city, o_zipCode, o_phoneNumber, o_note);
            Session["OrderId"] = orderId;

            if (orderId > 0) {
                List<int> productIds = GetCartProductIds(userId);
                // Call the ProcessCheckout method to clear the cart and move products to Purchase_History
                ProcessCheckout(userId);

                
                DateTime selectedInvoiceDate = DateTime.Now;
                SendEmail(orderId.ToString(),total.ToString("N2"),selectedInvoiceDate.ToString(),o_email,o_firstName,o_lastName,o_address,o_city,o_zipCode,o_phoneNumber,o_note,"BabyHaven Order #"+orderId.ToString(), productIds);
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
            // Retrieve the list of product IDs in the user's cart 
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
                if(discountCode.Equals("NEWBORN", StringComparison.OrdinalIgnoreCase)) {
                    discountRate = 0.05m; // 10% discount for CODE1
                }
                else if(discountCode.Equals("BABYHAVEN", StringComparison.OrdinalIgnoreCase)) {
                    discountRate = 0.50m; // 20% discount for CODE2
                }
                else if(discountCode.Equals("PROJECTSDAY", StringComparison.OrdinalIgnoreCase)) {
                    discountRate = 0.50m; // 50% discount for CODE3
                }
            }

            return subtotal * discountRate;
        }

        private decimal CalculateTotal(decimal subtotal, decimal discount) {
            decimal deliveryCost = 100.00m; // Default delivery cost

            int uid = Convert.ToInt32(Session["LoggedInUserID"]);

            // Check if the subtotal is greater than or equal to R1000
            if (subtotal >= 2000.00m) {
                // If yes, set the delivery cost to 0.00 (free delivery)
                deliveryCost = 0.00m;
            }else if (sc.isSafeHavenSock(uid) == true)
            {
                deliveryCost = 0.00m;
            }

            // Calculate the total including the discount and delivery cost
            decimal total = subtotal - discount + deliveryCost;

            return total;
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

            // Update the delivery cost label based on the subtotal
            if(subtotal >= 2000.00m) {
                lblDelivery.InnerHtml = "<s>R 100.00</s> Free Delivery";
            }
            else {
                lblDelivery.InnerText = "R 100.00";
            }
        }
        public string GetProductImage(int productId)
        {
            int productID = Convert.ToInt32(productId);
            // Call the backend service to get the product name based on the productID
            return sc.GetProductImage(productID);
        }

        public string GetProductName(int productId)
        {
            int productID = Convert.ToInt32(productId);
            // Call the backend service to get the product name based on the productID
            return sc.GetProductName(productID);
        }
        

        public string GetProductPrice(int productId)
        {
            int productID = Convert.ToInt32(productId);

            // Call the backend service to get the product price based on the productID and quantity
            decimal productPrice = sc.GetProductPrice(productID);

            // Return the total price formatted as currency
            return productPrice.ToString("C");
        }

       
        public string GetQuant(int productId)
        {
            int orderId = (int)Session["OrderId"];
            int quant = sc.GetProductQuantityInCart(orderId, productId);
            return quant.ToString();
        }
        private void SendEmail(string oID,string tot,string date,string recemail,string fname,string lname,string address,string city,string zip,string phoneno, string note,string subb, List<int> productIds)
        {

            // Construct the email body with order summary and product details
            string mailbody = "<p><b>Order ID:</b> " + oID + "<br><b>Total Amount:</b> R " + tot + "<br><b>Date:</b> " + date +
                "<br><b>First Name:</b> " + fname + "<br><b>Last Name:</b> " + lname + "<br><b>Email:</b> " + recemail +
                "<br><b>Address:</b> " + address + "<br><b>City:</b> " + city + "<br><b>Zip Code:</b> " + zip +
                "<br><b>Phone Number:</b> " + phoneno + "<br><b>Note:</b> " + note + "</p><hr />";

            if (productIds.Count > 0)
            {
                mailbody += "<table style='border: 1px solid black; border-collapse: collapse;'><thead><tr><th style='font-weight: bold; padding: 10px; border: 1px solid black;'>Product</th><th style='font-weight: bold; padding: 10px; border: 1px solid black;'>Price</th><th style='font-weight: bold; padding: 10px; border: 1px solid black;'>Quantity</th></tr></thead><tbody>";

                foreach (int productId in productIds)
                {
                    string productName = GetProductName(productId);
                    string productPrice = GetProductPrice(productId);
                    string proquant = GetQuant(productId);
                    // Add a row for each product
                    mailbody += $"<tr><td style='border: 1px solid black; padding: 10px;'>{productName}</td><td style='border: 1px solid black; padding: 10px;'>{productPrice}</td><td style='border: 1px solid black; padding: 10px;'>{proquant}</td></tr>";
                }

                // Close the table
                mailbody += "</tbody></table>";


            }


            string from = "babyhavenproject@gmail.com";

            // Create a MailMessage object
            MailMessage message = new MailMessage(from, recemail);
            message.Subject = subb;

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

    }

}