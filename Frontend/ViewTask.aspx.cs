using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frontend.BackendReference;
namespace Frontend
{
    public partial class ViewTask : System.Web.UI.Page
    {
        BabyHavenServiceClient sr = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int adminId = Convert.ToInt32(Session["LoggedInUserID"]); ;
                String[] assignedTasks = sr.GetAssignedTasks(adminId);
                if (!assignedTasks.Length.Equals(0))
                {
                    foreach (string td in assignedTasks)
                    {
                        ListItem item = new ListItem(td);
                        string idd = Convert.ToString(sr.GetAssignmentIdForTask(td));
                        item.Attributes["AssignmentId"] = idd;

                        CheckBoxList1.Items.Add(item);
                    }
                }
                else
                {


                    notask.Visible = true;
                    Taskss.Visible = false;
                }

            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    item.Attributes["class"] = "checked-item";
                }
                else
                {
                    item.Attributes.Remove("class");
                }
            }
        }

        protected void donetasks_Click(object sender, EventArgs e)
        {
            // Create a list to store items to be removed
            List<ListItem> itemsToRemove = new List<ListItem>();

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    
                    string idd = Convert.ToString(sr.GetAssignmentIdForTask(Convert.ToString(item)));

                    item.Attributes["AssignmentId"] = idd;
                    int assignmentId = Convert.ToInt32(item.Attributes["AssignmentId"]);
                    sr.MarkTaskCompleted(assignmentId);
                    itemsToRemove.Add(item); // Add the item to the removal list
                }
            }

            // Remove the items after the loop
            foreach (ListItem itemToRemove in itemsToRemove)
            {
                CheckBoxList1.Items.Remove(itemToRemove);
            }

            if (CheckBoxList1.Items.Count == 0)
            {
                notask.Visible = true; // Show the "notask" element
                Taskss.Visible = false;
            }
        }
    }
}