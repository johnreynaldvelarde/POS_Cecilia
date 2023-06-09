using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Sales_Report_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Sales_Report_Form()
        {
            InitializeComponent();
            MonitorSales();
            chart_SalesMonth();
            chart_Product_Stock_Level();
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
            label_product_sold.Text = GetProductTotal().ToString();

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

        public int GetProductTotal()
        {
            int product_total = 0;
            try
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string sql = "SELECT SUM(Order_Quantity) AS TotalQuantity FROM Order_Product";
                    SqlCommand command = new SqlCommand(sql, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            product_total = reader.GetInt32(0);
                        }
                    }

                    reader.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return product_total;
        }

        public void chart_SalesMonth()
        {
            try
            {
                string sql = "SELECT MONTH(Transaction_Date) as month, YEAR(Transaction_Date) as year, SUM(Total_Amount) as Total_Amount " +
                             "FROM Order_Transaction " +
                             "GROUP BY MONTH(Transaction_Date), YEAR(Transaction_Date)";

                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand(sql, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int month = reader.GetInt32(0);
                        int year = reader.GetInt32(1);
                        decimal total_amount = reader.GetDecimal(2);
                        string month_name = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(month);

                        chart_sales.Series["Monthly Sales"].Points.AddXY(month_name + "/" + year, total_amount);

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void chart_Product_Stock_Level()
        {
            try
            {
                string sql = "SELECT SUM(ProductStock_Qyt) AS TotalStock FROM Product_Stock";
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand(sql, connect);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int totalStock = Convert.ToInt32(result);
                        chart_ProductStock.Series["Product Stock"].Points.AddXY("Total Stock", totalStock);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_todaySales_Click(object sender, EventArgs e)
        {
            View_Today_Sales_Form frm = new View_Today_Sales_Form();
            frm.ShowDialog();
        }

        private void btn_Weekly_Click(object sender, EventArgs e)
        {
            View_Weekly_Sales_Form frm = new View_Weekly_Sales_Form();
            frm.ShowDialog();
        }

        private void btn_Monthly_Click(object sender, EventArgs e)
        {
            View_Monthly_Sales_Form frm = new View_Monthly_Sales_Form();
            frm.ShowDialog();
        }

        private void btn_Annual_Click(object sender, EventArgs e)
        {
            View_Annual_Sales_Form frm = new View_Annual_Sales_Form();
            frm.ShowDialog();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            View_Product_Sold_Form frm = new View_Product_Sold_Form();
            frm.ShowDialog();
        }
    }
}
