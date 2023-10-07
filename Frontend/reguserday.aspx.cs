using Frontend.BackendReference;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class reguserday : System.Web.UI.Page
    {
        BabyHavenServiceClient SC = new BabyHavenServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int year = 2023; // Replace with the desired year
                var userData = SC.GetNumberOfUsersRegisteredPerDayInYear(year);

                // Create a JavaScript array for labels (dates)
                var labels = userData.Keys.Select(date => date.ToString("yyyy-MM-dd")).ToArray();

                // Create a JavaScript array for data points (user registrations)
                var data = userData.Values.ToArray();

                // Construct the Chart.js script
                string chartScript = $@"
                    <canvas id='userChart' width='400' height='200'></canvas>
                    <script>
                        function createChart() {{
                            var ctx = document.getElementById('userChart').getContext('2d');
                            var userChart = new Chart(ctx, {{
                                type: 'line',
                                data: {{
                                    labels: {JsonConvert.SerializeObject(labels)},
                                    datasets: [{{
                                        label: 'User Registrations',
                                        data: {JsonConvert.SerializeObject(data)},
                                        fill: false,
                                        borderColor: 'rgb(75, 192, 192)',
                                        lineTension: 0.1
                                    }}]
                                }},
                                options: {{
                                    scales: {{
                                        y: {{
                                            beginAtZero: true
                                        }}
                                    }}
                                }}
                            }});
                        }}

                        // Call the createChart function when the DOM is fully loaded
                        document.addEventListener('DOMContentLoaded', createChart);
                    </script>
                ";

                // Assign the chartScript string to your HTML element's InnerHtml as needed
                regchart.InnerHtml = chartScript;
            }
        }

    }
}