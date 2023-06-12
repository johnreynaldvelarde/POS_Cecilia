﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class View_Monthly_Sales_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public View_Monthly_Sales_Form()
        {
            InitializeComponent();
            view_monthly_sales();
            select_month();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void select_month()
        {
            string[] months = new string[] {
                            "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December"
                            };

            cmd_Month.Items.AddRange(months);
            cmd_Month.SelectedIndex = 0;
        }



        public void get_total()
        {

            double total = 0;
            label_amount.Text = "";
            foreach (DataGridViewRow item in data_Grid_Monthly.Rows)
            {

                total += double.Parse(item.Cells[3].Value.ToString());

            }

            label_amount.Text = total.ToString("N2");

        }

        public void view_monthly_sales()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();

                string sql = "SELECT p.Product_Name, op.Order_Quantity, op.Amount " +
                             "FROM Order_Product op " +
                             "JOIN Order_Transaction ot ON op.Transaction_ID = ot.Transaction_ID " +
                             "JOIN Product p ON op.Product_ID = p.Product_ID " +
                             "WHERE MONTH(ot.Transaction_Date) = MONTH(GETDATE()) " +
                             "AND YEAR(ot.Transaction_Date) = YEAR(GETDATE())";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Monthly.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Grid_Monthly.Rows.Add(i, reader["Product_Name"].ToString(), reader["Order_Quantity"].ToString(), reader["Amount"].ToString());
                }

                reader.Close();
                connect.Close();
                get_total();
            }
        }

    }
}
