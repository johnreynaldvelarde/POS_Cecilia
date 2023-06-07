using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Sales_Report_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Sales_Report_Form()
        {
            InitializeComponent();
            MonitorSales();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MonitorSales()
        {
            label_today.Text = GetTodaySales().ToString("#,##0.00");
           // lblWeek.Text = GetTotal("SELECT SUM(Total_Amount) AS total_sum FROM Transaction_Log WHERE DATEPART(week, Transaction_Date) = DATEPART(week, GETDATE()) AND DATEPART(year, Transaction_Date) = DATEPART(year, GETDATE())").ToString("#,##0.00");
           // lblMonth.Text = GetTotal("SELECT SUM(Total_Amount) AS total_sum FROM Transaction_Log WHERE DATEPART(month, Transaction_Date) = DATEPART(month, GETDATE()) AND DATEPART(year, Transaction_Date) = DATEPART(year, GETDATE())").ToString("#,##0.00");
          //  lblAnnual.Text = GetTotal("SELECT SUM(Total_Amount) AS total_sum FROM Transaction_Log WHERE DATEPART(year, Transaction_Date) = DATEPART(year, GETDATE())").ToString("#,##0.00");
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

    }
}
