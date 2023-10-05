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



        protected string selectedUserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dynamic users = sr.GetAllUsers();

                //foreach (BackendReference.User_Table u in users)
                //{
                //    // Create a new table row for each user
                //    TableRow row = new TableRow();

                //    // Add cells with user data
                //    TableCell userIdCell = new TableCell();
                //    userIdCell.Text = u.User_Id.ToString();
                //    row.Cells.Add(userIdCell);

                //    TableCell emailCell = new TableCell();
                //    emailCell.Text = u.Email;
                //    row.Cells.Add(emailCell);

                //    TableCell nameCell = new TableCell();
                //    nameCell.Text = u.Name;
                //    row.Cells.Add(nameCell);

                //    TableCell surnameCell = new TableCell();
                //    surnameCell.Text = u.Surname;
                //    row.Cells.Add(surnameCell);

                //    TableCell phoneCell = new TableCell();
                //    phoneCell.Text = u.Phone_Number;
                //    row.Cells.Add(phoneCell);

                //    // Add a placeholder for the radio button in the row
                //    TableCell actionCell = new TableCell();
                //    PlaceHolder radioPlaceholder = new PlaceHolder();
                //    actionCell.Controls.Add(radioPlaceholder);
                //    row.Cells.Add(actionCell);

                //    // Create a radio button and add it to the placeholder
                //    RadioButton userRadioButton = new RadioButton();
                //    userRadioButton.ID = "rbtnAddAdmin_" + u.User_Id; // Unique ID based on user ID
                //    userRadioButton.Text = "Add Admin";
                //    userRadioButton.GroupName = "AdminGroup"; // Group radio buttons to select only one
                //    userRadioButton.CssClass = "site-radio";
                //    userRadioButton.Attributes["data-user-id"] = u.User_Id.ToString(); // Store user ID as an attribute
                //    userRadioButton.CheckedChanged += userRadioButton_CheckedChanged; // Add event handler for radio button change

                //    radioPlaceholder.Controls.Add(userRadioButton);

                //    // Add the row to the userTable
                //    userTable.Rows.Add(row);

                //}

                displayUsers(users);
            }
        }
        protected void userRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;
            selectedUserId = selectedRadioButton.Attributes["data-user-id"];
        }

        private void displayUsers(dynamic users)
        {
            string display = "<div style='text-align: center;'><table class='styled-table'><thead><tr><th>Name</th><th>Surname</th><th>Email</th><th>Phone Number</th><th>Make Admin</th></tr></thead><tbody>";

            foreach (BackendReference.User_Table u in users)
            {
                display += "<tr>";

            
                display += "<td>" + u.Surname + "</td>";
                display += "<td>" + u.Name + "</td>";
                display += "<td>" + u.Email + "</td>";
                display += "<td>" + u.Phone_Number + "</td>";
               

                display += "<td>";
                display += "<input type='radio' name='adminRadio' id='adminRadio' value='" + u.User_Id + "'>";
                display += "</td>";

                display += "</tr>";
            }

            display += "</tbody></table></div><br />";

            userTabless.Text = display;
        }
        protected void btn_register(object sender, EventArgs e)
        {

            string makeAdmin = Request.Form["adminRadio"];

            if (!string.IsNullOrEmpty(makeAdmin))
            {

                if (int.TryParse(makeAdmin, out int adminRadio))
                {

                    sr.AddAdminTEST(adminRadio);


                    dynamic updatedUsers = sr.GetAllUsers();

                    
                    displayUsers(updatedUsers);
                    string script = "<script>alert('Successfully added admin');</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
                }
            }
            else
            {
                string script = "<script>alert('Please select a User to make an admin.');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
            }
        }



        private void PerformSearch()
        {


            string tx = txtSearch.Text;

            if (!string.IsNullOrEmpty(tx))
            {
                // Call your service method to search for users by name
                dynamic searchResults = sr.SearchUsersByName(tx);

                // Create a string to store the HTML table
                string tableHtml = "<div style='text-align: center;'><table class='styled-table'><thead><tr><th>Name</th><th>Surname</th><th>Email</th><th>Phone Number</th><th>Make Admin</th></tr></thead><tbody>";

                foreach (BackendReference.User_Table u in searchResults)
                {
                    tableHtml += "<tr>";
                    tableHtml += "<td>" + u.Surname + "</td>";
                    tableHtml += "<td>" + u.Name + "</td>";
                    tableHtml += "<td>" + u.Email + "</td>";
                    tableHtml += "<td>" + u.Phone_Number + "</td>";
                    

                    tableHtml += "<td>";
                    tableHtml += "<input type='radio' name='adminRadio' id='adminRadio' value='" + u.User_Id + "'>";
                    tableHtml += "</td>";
                    tableHtml += "</tr>";
                }

                tableHtml += "</tbody></table></div><br />";

                // Set the generated HTML to the userTabless Literal control
                userTabless.Text = tableHtml;
            }

            //string tx = txtSearch.Text;

            //if (tx != null)
            //{






            //    // Call your service method to search for users by name
            //    dynamic searchResults = sr.SearchUsersByName(tx);

            //    // Clear the existing table rows
            //    userTable.Rows.Clear();

            //    foreach (BackendReference.User_Table u in searchResults)
            //    {
            //        // Create a new table row for each user
            //        TableRow row = new TableRow();

            //        // Add cells with user data
            //        TableCell userIdCell = new TableCell();
            //        userIdCell.Text = u.User_Id.ToString();
            //        row.Cells.Add(userIdCell);

            //        TableCell emailCell = new TableCell();
            //        emailCell.Text = u.Email;
            //        row.Cells.Add(emailCell);

            //        TableCell nameCell = new TableCell();
            //        nameCell.Text = u.Name;
            //        row.Cells.Add(nameCell);

            //        TableCell surnameCell = new TableCell();
            //        surnameCell.Text = u.Surname;
            //        row.Cells.Add(surnameCell);

            //        TableCell phoneCell = new TableCell();
            //        phoneCell.Text = u.Phone_Number;
            //        row.Cells.Add(phoneCell);

            //        // Add a placeholder for the radio button in the row
            //        TableCell actionCell = new TableCell();
            //        PlaceHolder radioPlaceholder = new PlaceHolder();
            //        actionCell.Controls.Add(radioPlaceholder);
            //        row.Cells.Add(actionCell);

            //        // Create a radio button and add it to the placeholder
            //        RadioButton userRadioButton = new RadioButton();
            //        userRadioButton.ID = "rbtnAddAdmin_" + u.User_Id; // Unique ID based on user ID
            //        userRadioButton.Text = "Add Admin";
            //        userRadioButton.GroupName = "AdminGroup"; // Group radio buttons to select only one
            //        userRadioButton.CssClass = "site-radio";
            //        userRadioButton.Attributes["data-user-id"] = u.User_Id.ToString(); // Store user ID as an attribute

            //        radioPlaceholder.Controls.Add(userRadioButton);

            //        // Add the row to the userTable
            //        userTable.Rows.Add(row);
            //    }

            //}
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }
    }
}