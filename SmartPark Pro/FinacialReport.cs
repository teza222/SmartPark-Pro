using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartPark_Pro
{
    public partial class FinacialReport : Form
    {
        private readonly SmartParkProDbEntities _db;
        private static FinacialReport _instance;
        public FinacialReport()
        {
            InitializeComponent();
            _db = new SmartParkProDbEntities();

        }


        //Singleton form
        public static FinacialReport Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FinacialReport();
                }
                return _instance;
            }
        }

        private void FinacialReport_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime startDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            DateTime endDate = DateTime.Now;

            dpStartDate.Value = startDate;
            dpEndDate.Value = endDate; 

            //await Task.Delay(1000);
            LoadPaymentchart(startDate, endDate);
            LoadPaymentGridView(startDate, endDate);

        }



        private void btDateSearch_Click(object sender, EventArgs e)
        {
            DateTime now = dpStartDate.Value;
            DateTime startDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            DateTime endDate = dpEndDate.Value; 

            LoadPaymentchart(startDate, endDate);
            LoadPaymentGridView(startDate, endDate);
        }

        private void LoadPaymentGridView(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Fetch records with "Exit" operation between the selected dates
                var exitOperations = _db.VehiclesDetecteds
                    .Where(p => p.Operation == "Exit" && p.ExitDate >= startDate && p.ExitDate < endDate)
                    .Select(p => new
                    {
                        p.TicketNumber,
                        Operation = "PAID",
                        Cost = p.Payment.Paid,
                        p.LicensePlateNumber,
                    })
                    .ToList();

                if (exitOperations.Count == 0)
                {
                   // MessageBox.Show("Nothing found in selected date range.");
                    return;
                }
                gvPaymentsGridview.DataSource = exitOperations;

            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
}
        

        private async void LoadPaymentchart(DateTime startDate, DateTime endDate )
        {
            try
            {
                var payments = _db.Payments
                    .Where(p => p.TimeStamp >= startDate && p.TimeStamp < endDate)
                    .ToList();

                if (payments.Count == 0)
                {
                    MessageBox.Show("No payments found in the selected date range.");
                    return;
                }

                decimal totalAmount = payments.Sum(p =>(int) p.Paid);
                ctPaymentchart.Series.Clear();
                ctPaymentchart.Titles.Clear();
                ctPaymentchart.Titles.Add($"Total Payments: {startDate:yyyy-MM-dd} to {endDate.AddDays(-1):yyyy-MM-dd}");
                var series = new Series("Payments")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true,
                    Color = Color.SteelBlue,
                    ["PixelPointWidth"] = "60" 
                };

                ctPaymentchart.Series.Add(series);

                series.Points.AddXY("Total Payments", totalAmount);
                lbTotal.Text = totalAmount.ToString("C");

                ctPaymentchart.ChartAreas[0].AxisX.Title = "Payment Summary";
                ctPaymentchart.ChartAreas[0].AxisY.Title = "Total Amount ($)";
                ctPaymentchart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

       
    }
}
