﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Sales_Report_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Sales_Report_Form()
        {
            InitializeComponent();
            MonitorSales();
            PopulateChart();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MonitorSales()
        {
            label_today.Text = GetTodaySales().ToString("#,##0.00");
            label_weekly.Text = GetWeeklySales().ToString("#,##0.00");
            label_monthly.Text = GetMonthlySales().ToString("#,##0.00");
            label_annual.Text = GetAnnualSales().ToString("#,##0.00");

        }

        public double GetTodaySales()
        {
            double todaySales = 0;
            try
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();

                    string sql = "SELECT SUM(Total_Amount) AS today_sales FROM Order_Transaction WHERE CONVERT(date, Transaction_Date) = CONVERT(date, GETDATE())";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            todaySales = Convert.ToDouble(result);
                        }
                    }

                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return todaySales;
        }

        public double GetWeeklySales()
        {
            double weekly_sales = 0;
            try
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();

                    string sql = "SELECT SUM(Total_Amount) AS total_sum FROM Order_Transaction WHERE DATEPART(week, Transaction_Date) = DATEPART(week, GETDATE()) AND DATEPART(year, Transaction_Date) = DATEPART(year, GETDATE())";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            weekly_sales = Convert.ToDouble(result);
                        }
                    }

                    connect.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return weekly_sales;
        }

        public double GetMonthlySales()
        {
            double monthly_sales = 0;
            try
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();

                    string sql = "SELECT SUM(Total_Amount) AS total_sum FROM Order_Transaction WHERE DATEPART(month, Transaction_Date) = DATEPART(month, GETDATE()) AND DATEPART(year, Transaction_Date) = DATEPART(year, GETDATE())";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            monthly_sales = Convert.ToDouble(result);
                        }
                    }

                    connect.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return monthly_sales;
        }

        public double GetAnnualSales()
        {
            double annual_sales = 0;
            try
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();

                    string sql = "SELECT SUM(Total_Amount) AS total_sum FROM Order_Transaction WHERE DATEPART(year, Transaction_Date) = DATEPART(year, GETDATE())";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            annual_sales = Convert.ToDouble(result);
                        }
                    }

                    connect.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return annual_sales;
        }






        private void btn_todaySales_Click(object sender, EventArgs e)
        {
            View_Today_Sales_Form frm = new View_Today_Sales_Form();
            frm.ShowDialog();
        }

        private void PopulateChart()
        {
            // Create a new CartesianChart instance
            CartesianChart chart = new CartesianChart();

            // Create a new SeriesCollection
            SeriesCollection seriesCollection = new SeriesCollection();

            // Add some sample data
            seriesCollection.Add(new LineSeries
            {
                Title = "Series 1",
                Values = new ChartValues<double> { 3, 5, 7, 4, 2 }
            });

            seriesCollection.Add(new LineSeries
            {
                Title = "Series 2",
                Values = new ChartValues<double> { 7, 2, 4, 2, 5 }
            });

            // Assign the SeriesCollection to the chart
            chart.Series = seriesCollection;

            // Set the X and Y axis labels
            chart.AxisX.Add(new Axis
            {
                Title = "X Axis",
                Labels = new[] { "A", "B", "C", "D", "E" }
            });

            chart.AxisY.Add(new Axis
            {
                Title = "Y Axis"
            });

            // Add the chart to your form's controls
            cartesianChart1.Dock = DockStyle.Fill;
            Controls.Add(cartesianChart1);
        }
    }
}
