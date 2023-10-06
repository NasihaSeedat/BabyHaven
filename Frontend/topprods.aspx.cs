using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend {
    public partial class topprods : System.Web.UI.Page {

        BabyHavenServiceClient sc = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e) {

            if(!IsPostBack) {

                Order_Item[] allItemsArray = sc.GetAllOrderItems();

                List<Order_Item> allOrderItems = allItemsArray.ToList();

                // Calculate the total quantity sold for each product
                var productQuantities = allOrderItems
                .GroupBy(item => item.Product_Id)
                .Select(group => new
                {
                    ProductId = group.Key,
                    TotalQuantitySold = group.Sum(item => item.Quantity)
                })
                .OrderByDescending(item => item.TotalQuantitySold)
                .Take(5) // Select the top 5 products
                .ToList();

                // Fetch product details using ProductId
                List<Product> productsInfo = new List<Product>();
                foreach(var product in productQuantities) {
                    string name =  sc.GetProductName(product.ProductId);

                    productsInfo.Add(new Product {
                        P_Name = name,
                        P_Quantity = product.TotalQuantitySold
                    });
                }

                // Bind the data to the repeater
                InvoicesRepeater.DataSource = productsInfo;
                InvoicesRepeater.DataBind();
            }
        }

    }
}