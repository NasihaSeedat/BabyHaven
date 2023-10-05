using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend {
    public partial class ProductDetails : System.Web.UI.Page {

        BabyHavenServiceClient sc = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack)
            {
                loaddetails();
                if (Request.QueryString["P_ID"] != null)
                {
                    // Get the product ID from the query string
                    int productID;
                    if (int.TryParse(Request.QueryString["P_ID"], out productID))
                    {
                        // Use the GetProductCategory and GetProductName functions to fetch category and name
                        string category = sc.GetProductCategory(productID);
                        string name = sc.GetProductName(productID);
                        string productImageURL = sc.GetProductImage(productID);
                        decimal productPrice = sc.GetProductPrice(productID);
                        string description = sc.GetProductDescription(productID);
                        string availability = sc.GetProductAvailability(productID);

                        nameLabel2.Text = name;
                        priceLabel.Text = String.Format("{0:0.00}", productPrice);
                        categoryLabel.Text = category;
                        categoryLabel2.Text = category;
                        nameLabel.Text = name;
                        availabilityLabel.Text = availability;
                        productImage.ImageUrl = productImageURL;
                        descriptionLabel.Text = description;

                    }
                    else
                    {
                        Response.Redirect("Shop.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Shop.aspx");
                }
            }


        }
        protected void loaddetails()
        {
           
            int ID = Convert.ToInt32(Session["LoggedInUserID"]);
            var user = sc.GetUser(ID);

            if (Session["LoggedInUserID"] != null)
            {
                if (user.UserType.Equals(1))
                {
                    removeprods.Visible = false;
                    editprods.Visible = false;


                }
                else if (user.UserType.Equals(0))
                {
                    addtocart.Visible = false;
                    removeprods.Visible = true;
                    editprods.Visible = true;

                }
            }
        }
        protected string getUserName(int clientId) {
            return sc.GetUserName(clientId);
        }

        private int GetClientId() {
            if(Session["LoggedInUserID"] != null) {
                return Convert.ToInt32(Session["LoggedInUserID"]);
            }
            else {
                return -1; // Return a default value or throw an exception
            }
        }

        protected void AddToCart_Click(object sender, EventArgs e) {

            int userID = GetClientId();

            if(userID == -1) {
                Response.Redirect("Login.aspx");
            }

            int productID = int.Parse(Request.QueryString["P_ID"]);

            // Call the AddToCart method with the user ID and product ID
            bool addToCartSuccess = sc.AddToCart(userID, productID);

        }




        protected void editprods_Click(object sender, EventArgs e)
        {
            //getting the user ifm
            int ID = Convert.ToInt32(Session["LoggedInUserID"]);

            //getting the product
            var itemid = Request.QueryString["P_ID"];
            Response.Redirect("EditProduct.aspx?P_ID=" + itemid);
        }

        protected void removeprods_Click(object sender, EventArgs e)
        {
            int proID =Convert.ToInt32( Request.QueryString["P_ID"]);
            
                bool removed=sc.RemoveProds(proID);
            if (removed)
            {
                string script = "<script>alert('Successfully removed product');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
                Response.Redirect("Shop.aspx");
            }
            else
            {
                string script = "<script>alert('Could not remove product');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
                Response.Redirect("Shop.aspx");
            }
            
            
        }
    }
}