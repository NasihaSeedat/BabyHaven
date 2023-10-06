using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class numcat : System.Web.UI.Page
    {
        BabyHavenServiceClient SC = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string chartScript = @"
    <canvas id='myChart' width='100' height='100'></canvas>
    <script>
        function createChart() {
            var ctx = document.getElementById('myChart').getContext('2d');
            var myChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ['Nursery Items', 'Baby Gear', 'Baby Clothes', 'Feeding Essentials', 'Health Products', 'Baby Bedding', 'Diapering Must-Haves', 'Bath Items', 'Project SafeHaven'],
                    datasets: [{
                        label: 'num of items in each category',
                        data: [";

            // Dynamically populate the data values here
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Nursery Items")) + ",";
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Baby Gear")) + ",";
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Baby Clothes")) + ",";
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Feeding Essentials")) + ",";
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Health Products")) + ",";
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Baby Bedding")) + ",";
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Diapering Must-Haves")) + ",";
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Bath Items")) + ",";
            chartScript += Convert.ToInt32(SC.GetProductCategoryReport("Project SafeHaven")) + @"],
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)',
                            'rgba(255, 159, 64, 0.2)',
                            'rgba(255, 206, 86, 0.2)', // Additional color for the 5th bar
                            'rgba(75, 192, 192, 0.2)', // Additional color for the 6th bar
                            'rgba(153, 102, 255, 0.2)'
                        ],
                        borderColor: [
                             'rgba(255, 99, 132, 1)',
                            'rgba(54, 162, 235, 1)',
                            'rgba(255, 159, 64, 1)',
                            'rgba(255, 206, 86, 1)',
                            'rgba(75, 192, 192, 1)',
                            'rgba(153, 102, 255, 1)'
                        ],
                        borderWidth: 1
                    }]
                },
                options: {
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }
            });
        }

        window.onload = createChart; // Call the function when the page loads
    </script>
";

            // Assign the chartScript string to your HTML element's InnerHtml as needed
            UT.InnerHtml = chartScript;

           
        }
    }
}