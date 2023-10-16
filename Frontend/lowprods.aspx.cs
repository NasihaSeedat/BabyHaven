using Frontend.BackendReference;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Frontend {
    public partial class lowprods : System.Web.UI.Page {

        BabyHavenServiceClient sc = new BabyHavenServiceClient();

        protected void Page_Load(object sender, EventArgs e) {

            if(!IsPostBack) {

                Order_Item[] allItemsArray = sc.GetAllOrderItems();

                List<Order_Item> allOrderItems = allItemsArray.ToList();

                
                var productQuantities = allOrderItems
                .GroupBy(item => item.Product_Id)
                .Select(group => new
                {
                    ProductId = group.Key,
                    TotalQuantitySold = group.Sum(item => item.Quantity)
                })
                .OrderBy(item => item.TotalQuantitySold) 
                .Take(5) 
                .ToList();

                
                List<Product> productsInfo = new List<Product>();
                foreach(var product in productQuantities) {
                    string name = sc.GetProductName(product.ProductId);

                    productsInfo.Add(new Product {
                        P_Name = name,
                        P_Quantity = product.TotalQuantitySold
                    });
                }

                
                InvoicesRepeater.DataSource = productsInfo;
                InvoicesRepeater.DataBind();

                var pieData = productsInfo.Select(p => p.P_Quantity).ToArray();
                var pieLabels = productsInfo.Select(p => p.P_Name).ToArray();


                var pieChartCanvas = new HtmlGenericControl("canvas");
                pieChartCanvas.Attributes.Add("id", "myPieChart");


                ChartDiv.Controls.Add(pieChartCanvas);

                var pastelColors = new string[] { "#A3C1AD", "#E2B9C2", "#9D88A0", "#FFD3B6", "#8AC6D1" };

                            string pieChartScript = $@"
                <script>
                    var ctx = document.getElementById('myPieChart').getContext('2d');
                    var myPieChart = new Chart(ctx, {{
                        type: 'pie',
                        data: {{
                            labels: {JsonConvert.SerializeObject(pieLabels)},
                            datasets: [{{
                                data: {JsonConvert.SerializeObject(pieData)},
                                backgroundColor: {JsonConvert.SerializeObject(pastelColors)}
                            }}
                            ]
                        }},
                    }});
                </script>
            ";


                ChartDiv.Controls.Add(new LiteralControl(pieChartScript));
            }
        }
    }
}