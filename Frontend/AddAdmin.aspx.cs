using System;
using System.Collections.Generic;
using System.Diagnostics;
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

                    // Add a placeholder for the button in the row
                    TableCell actionCell = new TableCell();
                    PlaceHolder buttonPlaceholder = new PlaceHolder();
                    actionCell.Controls.Add(buttonPlaceholder);
                    row.Cells.Add(actionCell);

                    // Create a button and add it to the placeholder
                    Button userButton = new Button();
                    userButton.ID = "btnAddAdmin_" + u.User_Id; // Unique ID based on user ID
                    userButton.Text = "Add Admin";
                    userButton.CssClass = "site-btn";
                    userButton.CommandArgument = u.User_Id.ToString() + "|" + u.Surname;
                    userButton.Click += btn_register; // Attach the event handler

                    buttonPlaceholder.Controls.Add(userButton);

                    // Add the row to the userTable
                    userTable.Rows.Add(row);

                }
            }
        }

        protected void btn_register(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            string commandArgument = clickedButton.CommandArgument;

            string[] arguments = commandArgument.Split('|');
            if (arguments.Length == 2)
            {
                string userId = arguments[0];
                string surname = arguments[1];

                bool admin = sr.AddAdmin(int.Parse(userId), surname);

                if (admin)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    error.Text = "Something went wrong OR the admin already exists";
                    error.Visible = true;
                }
            }
        }



        private void PerformSearch()
        {

            string tx = txtSearch.Text;
            
            if (tx != null)
            {
                
               




                // Call your service method to search for users by name
                dynamic searchResults = sr.SearchUsersByName(tx);

                // Clear the existing table rows
                userTable.Rows.Clear();

                foreach (BackendReference.User_Table u in searchResults)
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
                    userButton.ID = "btnAddAdmin"; // Give each button a unique ID
                    userButton.Text = "Add Admin";
                    userButton.CssClass = "site-btn";

                    // Set the CommandArgument to pass user information to the event handler
                    userButton.CommandArgument = u.User_Id.ToString() + "|" + u.Surname;
                    userButton.Click += btn_register; // Attach an event handler
                    actionCell.Controls.Add(userButton);
                    row.Cells.Add(actionCell);

                    // Add the row to the userTable
                    userTable.Rows.Add(row);
                }

            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }
    }
}