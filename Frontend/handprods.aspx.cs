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
    }
}