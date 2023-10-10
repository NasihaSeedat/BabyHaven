using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class handprods : System.Web.UI.Page
    {
        BabyHavenServiceClient client = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Assuming prods is a List<Product>
            dynamic prods = client.Getallproducts();
            DataTable dt = new DataTable();
            dt.Columns.Add("p_name");
            dt.Columns.Add("numhand");

            foreach (Product p in prods)
            {
                int numhand = client.numOnHand(p.Product_Id);
                dt.Rows.Add(p.P_Name, numhand);
            }

            ProductGridView.DataSource = dt;
            ProductGridView.DataBind();
        }

        protected void btnFilter_Click(object sender, EventArgs e) {
            // Get the minimum and maximum quantity values from the textboxes
            int minQuantity = Convert.ToInt32(txtMinQuantity.Text);
            int maxQuantity = Convert.ToInt32(txtMaxQuantity.Text);

            // Assuming the original data source is stored in a DataTable named dt
            DataTable originalData = (DataTable)ProductGridView.DataSource;

            // Create a new DataTable to store the filtered data
            DataTable filteredData = originalData.Clone();

            // Iterate through the original data and add rows that meet the filter criteria
            foreach(DataRow row in originalData.Rows) {
                int numhand = Convert.ToInt32(row["numhand"]);
                if(numhand >= minQuantity && numhand <= maxQuantity) {
                    filteredData.ImportRow(row);
                }
            }

            // Bind the filtered data to the GridView
            ProductGridView.DataSource = filteredData;
            ProductGridView.DataBind();
        }

    }

}