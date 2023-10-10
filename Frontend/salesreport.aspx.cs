using Frontend.BackendReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class salesreport : System.Web.UI.Page
    {
        BabyHavenServiceClient SC = new BabyHavenServiceClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {


            DateTime targetMonth = new DateTime(2023, 1, 1);

            dynamic invoices = SC.GetInvoicesForYear(targetMonth);
            

            
            string data = "[";

            
            string labels = "[";

            
            foreach (Order_Table invoice in invoices)
            {
                data += invoice.O_Total.ToString() + ",";
                labels += $"'{invoice.O_Date.ToString("dd MMM yyyy")}',";
            }

           
            if (data.EndsWith(","))
            {
                data = data.Remove(data.Length - 1);
            }

            if (labels.EndsWith(","))
            {
                labels = labels.Remove(labels.Length - 1);
            }

            data += "]";
            labels += "]";

            
            string chartScript = $@"
            <canvas id='myChart' width='400' height='200'></canvas>
            <script>
                var ctx = document.getElementById('myChart').getContext('2d');
                var myChart = new Chart(ctx, {{
                    type: 'line',
                    data: {{
                        labels: {labels}, // Use the 'labels' string
                        datasets: [{{
                            label: 'Invoice Amount',
                            data: {data},
                            borderColor: 'rgba(75, 192, 192, 1)',
                            borderWidth: 1,
                            fill: false
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
            </script>
        ";

            
            ChartDiv.InnerHtml = chartScript;
        }

        protected void ddlMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime targetMonth;
            if (ddlMonths.SelectedValue != "0")
            {
                int selectedMonths = int.Parse(ddlMonths.SelectedValue);
                DateTime currentDate = DateTime.Now;

                
                DateTime resultDate = currentDate.AddMonths(-selectedMonths);

                
                targetMonth = new DateTime(resultDate.Year, resultDate.Month, 1);

                
                string result = targetMonth.ToString("yyyy-MM-dd");
                valid.Text = "Result date: " + result;

                dynamic invoices = SC.GetInvoicesForYear(targetMonth);

                string data = "[";
                string labels = "[";

                foreach (Order_Table invoice in invoices)
                {
                    data += invoice.O_Total.ToString() + ",";
                    labels += $"'{invoice.O_Date.ToString("dd MMM yyyy")}',";
                }

                if (data.EndsWith(","))
                {
                    data = data.Remove(data.Length - 1);
                }

                if (labels.EndsWith(","))
                {
                    labels = labels.Remove(labels.Length - 1);
                }

                data += "]";
                labels += "]";

                string chartScript = $@"
        <canvas id='myChart' width='400' height='200'></canvas>
        <script>
            var ctx = document.getElementById('myChart').getContext('2d');
            var myChart = new Chart(ctx, {{
                type: 'line',
                data: {{
                    labels: {labels},
                    datasets: [{{
                        label: 'Invoice Amount',
                        data: {data},
                        borderColor: 'rgba(75, 192, 192, 1)',
                        borderWidth: 1,
                        fill: false
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
        </script>
    ";

                ChartDiv.InnerHtml = chartScript;
            }
            else
            {
                
                valid.Visible = true;
               // valid.Text = "Please select a valid option.";
                targetMonth = DateTime.Now;
            }

            
        }

    }
}