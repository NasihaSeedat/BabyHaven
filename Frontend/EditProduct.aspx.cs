using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;
namespace Frontend
{
    public partial class EditProduct : System.Web.UI.Page
    {
        BabyHavenServiceClient s = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String paramID = Request.QueryString["P_ID"];
                int proid = Convert.ToInt32(paramID);

                if (proid > 0)
                {
                    var proinfo = s.getSingleProd(proid);

                    if (!IsPostBack)
                    {
                        ProName.Value = proinfo.P_Name;
                        ProDescription.Value = proinfo.P_Description;
                        ProPrice.Value = Convert.ToString(proinfo.P_Price);
                        ProCategory.Value = proinfo.P_Category;


                        ProActive.Value = Convert.ToString(proinfo.isActive);
                        ProImage.Value = proinfo.P_Image;

                        ProQuantity.Value = Convert.ToString(proinfo.P_Quantity);


                    }
                    else
                    {
                        Response.Redirect("Shop.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Shop.aspx");
                }
            }
        }

        protected void edtpro_Click(object sender, EventArgs e)
        {
            string paramId = Request.QueryString["P_ID"];
            int proid = Convert.ToInt32(paramId);

            if (proid != null)
            {
                int price = Convert.ToInt32(ProPrice.Value);
                string prodcat = "";
                int quant = Convert.ToInt32(ProQuantity.Value);
                
                bool active;
                if (ProActive.Value.Equals("1"))
                {
                    active = true;
                }
                else
                {
                    active = false;
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

                bool edited = s.UpdateProduct(proid, ProName.Value, ProDescription.Value, prodcat, quant, price, active, ProImage.Value);

                if (edited)
                {
                    Response.Redirect("Shop.aspx");
                }
                else
                {
                    error.Value = "Could Not Update Product";
                    error.Visible = true;
                }
            }
            else
            {
                error.Value = "Something Went Wrong ,Could Not Update Product";
                error.Visible = true;
            }

        }
    }
}