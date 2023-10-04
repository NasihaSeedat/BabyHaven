using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;

namespace Frontend {
    public partial class Shop : System.Web.UI.Page {

        BabyHavenServiceClient client = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e) {


            if(Request.QueryString["Category"] == null) {
                dynamic prods = client.Getallproducts();
                displaymethod(prods);
            }
            else if(Request.QueryString["Category"] != null) {
                string cat = Request.QueryString["Category"];
                dynamic prods;
                if(cat.Equals("Nursery Items")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Nursery Items");
                    displaymethod(prods);
                }
                else if(cat.Equals("Baby Gear")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Baby Gear");
                    displaymethod(prods);
                }
                else if(cat.Equals("Baby Clothes")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Baby Clothes");
                    displaymethod(prods);
                }
                else if(cat.Equals("Feeding Essentials")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Feeding Essentials");
                    displaymethod(prods);
                }
                else if(cat.Equals("Health Products")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Health Products");
                    displaymethod(prods);
                }
                else if(cat.Equals("Baby Bedding")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Baby Bedding");
                    displaymethod(prods);
                }
                else if(cat.Equals("Diapering Must-Haves")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Diapering Must-Haves");
                    displaymethod(prods);
                }
                else if(cat.Equals("Bath Items")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Bath Items");
                    displaymethod(prods);
                }
                else if(cat.Equals("Project SafeHaven")) {
                    //create variable with prodcuts from specific catoegory 
                    prods = client.getProductCat("Project SafeHaven");
                    displaymethod(prods);
                }

            }

        }
        private void displaymethod(dynamic prods) {
            string display = " ";
            int n = 0;

            display += "<div class='col-lg-9 col-md-9'><div class='row'>";

            foreach(Product pr in prods) {
                //display += "<div class='col-lg-4 col-md-6'>";
                //display += "<div class='product__item'>";
                //display += "<a href='ProductDetails.aspx?P_ID=" + pr.Product_Id + "'>";
                //display += "<div class='product__item__pic set-bg' data-setbg='" + pr.P_Image + "'></div>"; // Wrap the image in an anchor tag
                //display += "<div class='product__hover'>";
                //display += "<span class='hover-icon'>?</span>"; // Add a question mark or any other icon/image here
                //display += "</div></a>";
                //display += "<div class='product__item__text'>";
                //display += "<h6><a href='#'>" + pr.P_Name + "</a></h6>" + "<br />";
                //display += "<div class='product__price'>R" + String.Format("{0:0.00}", pr.P_Price);
                //display += "</div></div></div></div>";

                display += "<div class='col-lg-4 col-md-6'>";
                display += "<div class='product__item'>" + "<div class='product__item__pic set-bg' data-setbg='" + pr.P_Image + "'>";
                display += "<ul class='product__hover'>" +
                "<li><a href='" + pr.P_Image + "' class='image-popup'><span class='arrow_expand'></span></a></li>" +
                "<li><a href='ProductDetails.aspx?P_ID=" + pr.Product_Id + "'><span class='fa fa-question'></span></li>" +
                "</ul>" +
                "</div>";
                display += "<div class='product__item__text'>";
                display += "<h6>" + pr.P_Name + "</h6>" + "<br />";
                display += "<div class='product__price'>" + String.Format("{0:0.00}", pr.P_Price);
                display += "</div></div></div></div>";


                n++;

                if(n % 3 == 0) {
                    display += "</div><div class='row'>";
                }
            }
            if(n % 3 != 0) {
                display += "</div>";
            }

            display += "</div>";
            productDisplay.Text = display;
        }

        //load products based on max/min filter
        protected void SearchProducts(object sender, EventArgs e) {
            decimal lowPrice = decimal.Parse(minPrice.Value);
            decimal highPrice = decimal.Parse(maxPrice.Value);
            dynamic prods = client.Getallproducts();
            var filterprods = new List<Product>();
            foreach(Product pr in prods) {
                if(pr.P_Price >= lowPrice && pr.P_Price <= highPrice) {
                    filterprods.Add(pr);
                }
            }
            // Sort filterprods by product price in ascending order
            filterprods = filterprods.OrderBy(pr => pr.P_Price).ToList();
            displaymethod(filterprods);
        }
    }

}
