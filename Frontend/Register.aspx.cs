using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;

namespace Frontend
{
    public partial class Register : System.Web.UI.Page
    {
        BabyHavenServiceClient s = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            if(Password.Value!= ConfirmPass.Value)
            {
                error.Text = "Passwords do not match";
                error.Visible = true;
            }
            else
            {
                bool registered = s.Register(Email.Value, Hash.HashPassword(Password.Value), firstname.Value, lastname.Value, contact.Value, addressUser.Value, 1);

                if (registered)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    error.Text = "Something went wrong or the user already exists. Please try again later.";
                    error.Visible = true;
                }
            }
        }


    }
}