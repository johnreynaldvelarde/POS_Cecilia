using System;
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
    public partial class View_Annual_Sales_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public View_Annual_Sales_Form()
        {
            InitializeComponent();
            view_annual_sales();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void view_annual_sales()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();

                string sql = "SELECT p.Product_Name, op.Order_Quantity, op.Amount " +
                             "FROM Order_Product op " +
                             "JOIN Order_Transaction ot ON op.Transaction_ID = ot.Transaction_ID " +
                             "JOIN Product p ON op.Product_ID = p.Product_ID " +
                             "WHERE YEAR(ot.Transaction_Date) = YEAR(GETDATE())";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Annual.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Grid_Annual.Rows.Add(i, reader["Product_Name"].ToString(), reader["Order_Quantity"].ToString(), reader["Amount"].ToString());
                }

                reader.Close();
                connect.Close();
            }
        }

    }
}
