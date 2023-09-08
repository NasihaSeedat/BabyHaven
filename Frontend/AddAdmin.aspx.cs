using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if (!IsPostBack)
            {
                dynamic users = sr.GetAllUsers();

                foreach (BackendReference.User_Table u in users)
                {
                    // Create a new table row for each user
                    TableRow row = new TableRow();

                    // Add cells with user data
                    TableCell userIdCell = new TableCell();
                    userIdCell.Text = u.User_Id.ToString();
                    row.Cells.Add(userIdCell);

                    TableCell emailCell = new TableCell();
                    emailCell.Text = u.Email;
                    row.Cells.Add(emailCell);

                    TableCell nameCell = new TableCell();
                    nameCell.Text = u.Name;
                    row.Cells.Add(nameCell);

                    TableCell surnameCell = new TableCell();
                    surnameCell.Text = u.Surname;
                    row.Cells.Add(surnameCell);

                    TableCell phoneCell = new TableCell();
                    phoneCell.Text = u.Phone_Number;
                    row.Cells.Add(phoneCell);

                    // Add a button for each user
                    TableCell actionCell = new TableCell();
                    Button userButton = new Button();
                    userButton.ID = "btnAddAdmin";
                    userButton.Text = "Add Admin";
                    userButton.CssClass = "site-btn";

                    userButton.CommandArgument = u.User_Id.ToString();
                    userButton.CommandArgument = u.Surname.ToString();
                    userButton.Click += btn_register; // Attach an event handler
                    actionCell.Controls.Add(userButton);
                    row.Cells.Add(actionCell);

                    // Add the row to the userTable
                    userTable.Rows.Add(row);
                }
            }
        }

        protected void btn_register(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender; // Get the button that triggered the event
            string userId = clickedButton.CommandArgument;
            string surname= clickedButton.CommandArgument;

            bool admin = sr.AddAdmin(sr.GetUser(int.Parse(userId)), surname);

            if (admin == true)
            {
                Response.Redirect("Login.aspx");
            }
            else if(admin == false){
                error.Text = "Something went wrong OR the admin already exists";
                error.Visible = true;
            }
        }
    }
}