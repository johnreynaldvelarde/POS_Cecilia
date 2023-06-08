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

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Order_Transaction_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Order_Transaction_List_Form()
        {
            InitializeComponent();
            order_transaction_list();
        }

        public void order_transaction_list()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT t.Transaction_ID, s.Staff_Name, t.Transaction_Date, t.Total_Quantity, t.Total_Amount " +
                             "FROM Order_Transaction t " +
                             "JOIN Staff_Account s ON t.Staff_ID = s.Staff_ID";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Order_Transaction.Rows.Clear();
                while (reader.Read())
                {


                    i += 1;
                    data_Grid_Order_Transaction.Rows.Add(i, reader["Transaction_ID"].ToString(), reader["Staff_Name"].ToString(), reader["Transaction_Date"].ToString(),
                                                     reader["Total_Quantity"].ToString(), reader["Total_Amount"].ToString());


                }
                reader.Close();
                connect.Close();

            }

        }

        private void data_Grid_Order_Transaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_order = data_Grid_Order_Transaction.Columns[e.ColumnIndex].Name;
            if (column_order == "View")
            {
                int order_id = Convert.ToInt32(data_Grid_Order_Transaction.Rows[e.RowIndex].Cells[1].Value);
                Show_Order_Product_Form frm = new Show_Order_Product_Form(order_id);
                frm.ShowDialog();
            }
        }
    }
}
