using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "<table class='styled-table'>";
            display += "<thead><tr><th>Type Of Report</th><th>View</th></tr></thead>";
            display += "<tbody>";

            display += "<tr>";
            display += "<td>Number of Items Per Category</td>";
            display += "<td><a href='numcat.aspx'>View Report</a></td>";
            display += "</tr>";

            display += "<tr>";
            display += "<td>Products Sold On Website</td>";
            display += "<td><a href='allprods.aspx'>View Report</a></td>";
            display += "</tr>";

            display += "<tr>";
            display += "<td>Products On Hand</td>";
            display += "<td><a href='handprods.aspx'>View Report</a></td>";
            display += "</tr>";

            display += "<tr>";
            display += "<td>Sales Report</td>";
            display += "<td><a href='salesreport.aspx'>View Report</a></td>";
            display += "</tr>";

            display += "<tr>";
            display += "<td>Top 5 Selling Products</td>";
            display += "<td><a href='topprods.aspx'>View Report</a></td>";
            display += "</tr>";

            display += "<tr>";
            display += "<td>Lowest 5 Selling Products</td>";
            display += "<td><a href='lowprods.aspx'>View Report</a></td>";
            display += "</tr>";


            display += "</tbody>";
            display += "</table><br />";

            displayt.InnerHtml = display;
        }
    }
}