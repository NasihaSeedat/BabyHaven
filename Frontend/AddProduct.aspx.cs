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
            string prodcat=" ";
            bool activestate=true;
            if (ProActive.Equals("1"))
            {
                activestate = true;
            }else if (ProActive.Equals("2"))
            {
                activestate = false;
            }
            
                                    
                                    
                                

            //category
            if (ProCategory.Value.Equals("1"))
            {
                prodcat = "Nursery Items";
            }
            else if (ProCategory.Value.Equals("2"))
            {
                prodcat = "Baby Gear";
            }
            else if (ProCategory.Value.Equals("3"))
            {
                prodcat = "Baby Clothes";
            }
            else if (ProCategory.Value.Equals("4"))
            {
                prodcat = "Feeding Essentials";
            }
            else if (ProCategory.Value.Equals("5"))
            {
                prodcat = "Health Products";
            }
            else if (ProCategory.Value.Equals("6"))
            {
                prodcat = "Baby Bedding";
            }
            else if (ProCategory.Value.Equals("7"))
            {
                prodcat = "Diapering Must-Haves";
            }
            else if (ProCategory.Value.Equals("8"))
            {
                prodcat = "Bath Items";
            }
            else if (ProCategory.Value.Equals("9"))
            {
                prodcat = "Project SafeHaven";
            }

            admin = Convert.ToInt32(Session["LoggedInUser"]);
            bool add = s.AdminaddProds(ProName.Value, ProDescription.Value, prodcat, quantity, price, activestate, ProImage.Value);


            if (add == true)
            {
                //redirect to the home page 
                Response.Redirect("Home.aspx");
            }else if (add == false)
            {
                //Display error message to admin  
                error.Value = "Product not added to database OR Product already exists ";
                error.Visible = true;
            }

        }
    }
}