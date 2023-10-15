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

                if(Request.QueryString["Category"] == null) {
                    // Call your service function to retrieve all products as an array.
                    Product[] allProductsArray = sc.Getallproducts();

                    // Convert the array to a List<Product>.
                    List<Product> allProductsList = allProductsArray.ToList();
                    displaymethod(allProductsList);
                }
                else if(Request.QueryString["Category"] != null) {
                    string cat = Request.QueryString["Category"];
                    Product[] allProductsArray;

                    // Convert the array to a List<Product>.
                    List<Product> allProductsList;

                    if(cat.Equals("Nursery Items")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Nursery Items");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }
                    else if(cat.Equals("Baby Gear")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Baby Gear");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }
                    else if(cat.Equals("Baby Clothes")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Baby Clothes");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }
                    else if(cat.Equals("Feeding Essentials")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Feeding Essentials");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }
                    else if(cat.Equals("Health Products")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Health Products");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }
                    else if(cat.Equals("Baby Bedding")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Baby Bedding");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }
                    else if(cat.Equals("Diapering Must-Haves")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Diapering Must-Haves");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }
                    else if(cat.Equals("Bath Items")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Bath Items");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }
                    else if(cat.Equals("Project SafeHaven")) {
                        //create variable with prodcuts from specific catoegory 
                        allProductsArray = sc.getProductCat("Project SafeHaven");
                        allProductsList = allProductsArray.ToList();
                        displaymethod(allProductsList);
                    }

                }

            }
        }

        private void displaymethod(List<Product> allProductsList) {
            // Calculate the count of distinct products based on their names using LINQ.
            int productCount = allProductsList.Select(p => p.P_Name).Distinct().Count();

            // Display the count on the web page using a Label control.
            lblProductCount.Text = $"<strong>Total Different Products Sold:</strong> {productCount}";


            // Bind the list of products to the Repeater control.
            ProductsRepeater.DataSource = allProductsList;
            ProductsRepeater.DataBind();
        }
    }
}