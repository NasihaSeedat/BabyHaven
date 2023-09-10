using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;

namespace Frontend
{
    public partial class Shop : System.Web.UI.Page
    {
        BabyHavenServiceClient client = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string display = " ";
            int n = 0;
            if (Request.QueryString["Category"] == null)
            {
                dynamic prods = client.Getallproducts();
                display += "<div class='col-lg-9 col-md-9'><div class='row'>";

                foreach (BackendReference.Product pr in prods)
                {
                    display += "<div class='col-lg-4 col-md-6'>";
                    display += "<div class='product__item'>" + "<div class='product__item__pic set-bg' data-setbg='" + pr.P_Image + "'>";
                    display += "<ul class='product__hover'>" +
                    "<li><a href='" + pr.P_Image + "' class='image-popup'><span class='arrow_expand'></span></a></li>" +
                    "<li><a href='#'><span class='fa fa-shopping-cart'></span></a></li>" +
                    "</ul>" +
                    "</div>";
                    display += "<div class='product__item__text'>";
                    display += "<h6><a href='#'>" + pr.P_Name + "</a></h6>" + "<br />";
                    display += "<div class='product__price'>" + String.Format("{0:0.00}", pr.P_Price);
                    display += "</div></div></div></div>";

                    n++;

                    if (n % 3 == 0)
                    {
                        display += "</div><div class='row'>";
                    }
                }
                if (n % 3 != 0)
                {
                    display += "</div>";
                }

                display += "</div>";
                productDisplay.Text = display;
            }else if (Request.QueryString["Category"] != null)
            {
                string cat = Request.QueryString["Category"];
                if(cat.Equals("Nursery Items"))
                {
                    dynamic prods = client.getProductCat("Nursery Items");
                }
            }
        }
    }
}
