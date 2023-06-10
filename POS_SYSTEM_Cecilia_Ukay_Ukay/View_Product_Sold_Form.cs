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
    public partial class View_Product_Sold_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public View_Product_Sold_Form()
        {
            InitializeComponent();
            view_products_sold();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void view_products_sold()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();

                string sql = "SELECT p.Product_Name, SUM(op.Order_Quantity) AS Total_Quantity " +
                             "FROM Order_Product op " +
                             "JOIN Product p ON op.Product_ID = p.Product_ID " +
                             "GROUP BY p.Product_Name";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Product.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Grid_Product.Rows.Add(i, reader["Product_Name"].ToString(), reader["Total_Quantity"].ToString());
                }

                reader.Close();
                connect.Close();
            }
        }

    }
}
