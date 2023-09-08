using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class Shop : System.Web.UI.Page
    {
        //linking page to service
        BackendReference.BabyHavenServiceClient client = new BackendReference.BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic prods = client.Getallproducts();
            string display = "";
            foreach (BackendReference.Product pr in prods)
            {
                display += //"<div class='col-lg-4 col-md-6'>" +
                "<div class='product__item'>" +
                "<div class='product__item__pic set-bg' data-setbg='" + pr.P_Image + "'>" +
                "<ul class='product__hover'>" +
                "<li><a href='" + pr.P_Image + "' class='image-popup'><span class='arrow_expand'></span></a></li>" +
                "<li><a href='#'><span class='fa fa-shopping-cart'></span></a></li>" +
                "</ul>" +
                "</div>" +
                "<div class='product__item__text'>" +
                "<h6><a href='#'>" + pr.P_Name + "</a></h6>" +
                "<br />" +
                "<div class='product__price'>" + String.Format("{0:0.00}", pr.P_Price) + "</div>" +
                "</div>" +
                "</div>";
                //"</div>";
            }
            productsdiv.InnerHtml = display;
        }
        }
}