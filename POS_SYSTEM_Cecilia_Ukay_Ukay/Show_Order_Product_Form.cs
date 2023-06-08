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
    public partial class Show_Order_Product_Form : Form
    {
        DB_Connection database = new DB_Connection();

        private int Order_id;

        public Show_Order_Product_Form(int order_id)
        {
            InitializeComponent();
            this.Order_id = order_id;
            view_order_product();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void view_order_product()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();

                string sql = "SELECT product.Product_ID, product.Product_Code, product.Product_Name, op.Order_Quantity, op.Amount " +
                             "FROM Order_Product op " +
                             "JOIN Product product ON op.Product_ID = product.Product_ID " +
                             "WHERE op.Transaction_ID = @ManageID";

                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@ManageID", Order_id);
                SqlDataReader reader = command.ExecuteReader();

                data_Purchase_Item.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Purchase_Item.Rows.Add(i, reader["Product_Code"].ToString(), reader["Product_Name"].ToString(), reader["Order_Quantity"].ToString(),
                                                   reader["Amount"].ToString());
                }
                reader.Close();
                connect.Close();
            }
        }
    }
}
