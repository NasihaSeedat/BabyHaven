using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;
namespace Frontend
{
    public partial class AddAdmin : System.Web.UI.Page
    {
        //reference to server
        BabyHavenServiceClient sr = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic users = sr.GetAllUsers();
            string display = " ";
            int n = 0;

            foreach(BackendReference.User_Table u in users)
            {
                if (n == 3)
                {
                    display+= "<div class='row'>";
                    n = 0;
                }
                display += u.User_Id + u.Email + u.Name + u.Surname + u.Phone_Number;

            }
            addadmins.InnerHtml = display;
        }

        protected void btn_register(object sender, EventArgs e)
        {

            
        }
    }
}