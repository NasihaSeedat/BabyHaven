using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class BabyHaven : System.Web.UI.MasterPage
    {
        BackendReference.BabyHavenServiceClient sr = new BackendReference.BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //int UserID;
            //int totalItems = 0;

            //if (Session["LoggedInUserID"] != null)
            //{
            //    UserID = Convert.ToInt32(Session["LoggedInUserID"]);
            //    dynamic products = sr.GetCartProducts(UserID);
            //    foreach (BackendReference.Product pr in products)
            //    {
            //        int Quantity = sr.GetQuantity(UserID, pr.Product_Id);
            //        totalItems += Quantity;
            //    }
            //}
            //else
            //{
            //    totalItems = 0;
            //}



            if (Session["LoggedInUserType"] != null && Session["LoggedInUserType"].Equals(0))
            {
                adminLink.Visible = true;
                DropAdmin.Visible = true;
                invoices.Visible = true;
                reports.Visible = true;
            }
            else if(Session["LoggedInUserType"] == null && Session["LoggedInUserID"]==null)
            {
                adminLink.Visible = false;
                DropAdmin.Visible = false;
                invoices.Visible = false;
                reports.Visible = false;
            }
        }

        public int GetCartItemCount()
        {
            int UserID;
            int totalItems = 0;

            if (Session["LoggedInUserID"] != null)
            {
                UserID = Convert.ToInt32(Session["LoggedInUserID"]);
                dynamic products = sr.GetCartProducts(UserID);
                foreach (BackendReference.Product pr in products)
                {
                    int Quantity = sr.GetQuantity(UserID, pr.Product_Id);
                    totalItems += Quantity;
                }
            }
            else
            {
                totalItems = 0;
            }

            return totalItems;
        }

    }
}