using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;
namespace Frontend
{
    public partial class DelegateTask : System.Web.UI.Page
    {
        BabyHavenServiceClient sr = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dynamic users = sr.GetAllUsersAdmin();



                displayUsers(users);
            }
        }

        private void displayUsers(dynamic users)
        {
            string display = "<table class='styled-table'><thead><tr><th>Name</th><th>Surname</th><th>Email</th><th>Select Admin</th></tr></thead><tbody>";

            foreach (BackendReference.User_Table u in users)
            {
                display += "<tr>";


                display += "<td>" + u.Name + "</td>";
                display += "<td>" + u.Surname + "</td>";
                display += "<td>" + u.Email + "</td>";
                


                display += "<td>";
                display += "<input type='radio' name='adminRadio' id='adminRadio' value='" + u.User_Id + "'>";
                display += "</td>";

                display += "</tr>";
            }

            display += "</tbody></table><br />";

            userTabless.Text = display;
        }


        private void PerformSearch()
        {


            string tx = txtSearch.Text;

            if (!string.IsNullOrEmpty(tx))
            {
                // Call your service method to search for users by name
                dynamic searchResults = sr.SearchUsersByNameAdmins(tx);

                // Create a string to store the HTML table
                string tableHtml = "<table class='styled-table'><thead><tr><th>Name</th><th>Surname</th><th>Email</th><th>Select Admin</th></tr></thead><tbody>";

                foreach (BackendReference.User_Table u in searchResults)
                {
                    tableHtml += "<tr>";
                    tableHtml += "<td>" + u.Name + "</td>";
                    tableHtml += "<td>" + u.Surname + "</td>";
                    tableHtml += "<td>" + u.Email + "</td>";
                 


                    tableHtml += "<td>";
                    tableHtml += "<input type='radio' name='adminRadio' id='adminRadio' value='" + u.User_Id + "'>";
                    tableHtml += "</td>";
                    tableHtml += "</tr>";
                }

                tableHtml += "</tbody></table><br />";

                // Set the generated HTML to the userTabless Literal control
                userTabless.Text = tableHtml;
            }
        }

        protected void btnSelAdmin_Click(object sender, EventArgs e)
        {

            
        }
      
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        protected void AddTaskButton_Click1(object sender, EventArgs e)
        {
            string taskDescription = TaskTextBox.Text;
            if (!string.IsNullOrEmpty(taskDescription))
            {
                // Add the task to the ListBox
                ListBox1.Items.Add(new ListItem(taskDescription, taskDescription));
                string selAdm = Request.Form["adminRadio"];

                if (!string.IsNullOrEmpty(selAdm))
                {

                    if (int.TryParse(selAdm, out int adminRadio))
                    {

                        sr.AssignTask(adminRadio, taskDescription);





                    }
                }
                else
                {
                    string script = "<script>alert('Could Not Delegate Task');</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
                }
               
                
            }

        }
    }
}