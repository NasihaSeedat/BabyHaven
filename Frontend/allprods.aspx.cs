using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class allprods : System.Web.UI.Page
    {
        BabyHavenServiceClient sc = new BabyHavenServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) {
                // Call your service function to retrieve all products as an array.
                Product[] allProductsArray = sc.Getallproducts();

                // Convert the array to a List<Product>.
                List<Product> allProductsList = allProductsArray.ToList();

                // Calculate the count of distinct products based on their names using LINQ.
                int productCount = allProductsList.Select(p => p.P_Name).Distinct().Count();

                // Display the count on the web page using a Label control.
                lblProductCount.Text = $"<strong>Total Different Products Sold:</strong> {productCount}";


                // Create a string to store product information.
                string productInfo = "<strong>Product Information:</strong><br />";

                // Loop through the products and add their IDs and names to the string, wrapping them in <span> elements.
                foreach(var product in allProductsList) {
                    productInfo += $"<span class='product-item'><strong>ID:</strong> {product.Product_Id} | <strong>Name:</strong> {product.P_Name}</span><br />";
                }

                // Display the product information in the Label control.
                lblProductInfo.Text = productInfo;

            }
        }
    }
}