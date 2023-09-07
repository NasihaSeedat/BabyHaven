using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;


namespace Frontend
{
    public partial class Login : System.Web.UI.Page
    {
        //reference to server
        BabyHavenServiceClient s = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            var hashedpass = Hash.HashPassword(Password.Value);
            int Id = s.Login(Email.Value, hashedpass);

            //zvar user = s.GetUser(Id);
            if (Id == 0)
            {
                error.Visible = true;
            }
            else
            {
                Session["LoggedInUserID"] = Id;
                Response.Redirect("Home.aspx");
            }
        }
    }
}