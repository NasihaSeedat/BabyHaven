using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;
namespace Frontend
{
    public partial class AddProduct : System.Web.UI.Page
    {
        //reference to server
        BabyHavenServiceClient s = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddProds_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(ProPrice.Value);
            int quantity = Convert.ToInt32(ProQuantity.Value);

            int admin = 0;
            int prodID = 0;
            int active = 0;

            //active state
            if (ProActive.Value.Equals("1"))
            {
                active = 1;
            }
            else
            {
                active = 0;
            }

            //category
            if (ProCategory.Value.Equals("1"))
            {
                prodID = 1;
            }
            else if (ProCategory.Value.Equals("2"))
            {
                prodID = 2;
            }
            else if (ProCategory.Value.Equals("3"))
            {
                prodID = 3;
            }
            else if (ProCategory.Value.Equals("4"))
            {
                prodID = 4;
            }
            else if (ProCategory.Value.Equals("5"))
            {
                prodID = 5;
            }
            else if (ProCategory.Value.Equals("6"))
            {
                prodID = 6;
            }
            else if (ProCategory.Value.Equals("7"))
            {
                prodID = 7;
            }
            else if (ProCategory.Value.Equals("8"))
            {
                prodID = 8;
            }
            else if (ProCategory.Value.Equals("9"))
            {
                prodID = 9;
            }

            admin = Convert.ToInt32(Session["LoggedInUser"]);

            string add = s.Addproducts(ProName.Value, ProDescription.Value, prodID, quantity, price, active, admin);
        }
    }
}