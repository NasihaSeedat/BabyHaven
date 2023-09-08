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
            //if (!IsPostBack)
            //{
            //    // Bind the cart items to the table
            //    BindCart();
            //}
        }

        protected void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            //// Get the product ID to remove
            //string productIdToRemove = ((Button)sender).CommandArgument;

            //// Remove the item from the cart based on the product ID
            //cartItems.RemoveAll(item => item.ProductId == productIdToRemove);

            //// Update the cart table
            //BindCart();
        }



        // Method to bind the cart items to the table
        //private void BindCart()
        //{
        //    CartTable.DataSource = cartItems;
        //    CartTable.DataBind();
        //}


    }
}