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
                // safehaveninvoices.Visible = true;
                dropInvoices.Visible = true;
                TaskAdmins.Visible = true;
                DropTasks.Visible = true;
                //reports.Visible = true;
                getTaskCounts();
            }
            else if(Session["LoggedInUserType"] == null && Session["LoggedInUserID"]==null)
            {
                adminLink.Visible = false;
                DropAdmin.Visible = false;
                invoices.Visible = false;
                // safehaveninvoices.Visible = false;
                dropInvoices.Visible = false;
                TaskAdmins.Visible = false;
                DropTasks.Visible = false;
                // reports.Visible = false;
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

        public int getTaskCounts()
        {
            int UsId;
           
            if (Session["LoggedInUserId"] != null)
            {
                
                UsId = Convert.ToInt32(Session["LoggedInUserId"]);
                
                int count = sr.GetTasksCount(UsId);
                if (count == 0)
                {
                    tas.Visible = false;
                }
                
                return count;
            }
            else
            {
                tas.Visible = false;
                return 0;
            }
          
         
        }

        protected void btn_Subscribe(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

    }
}