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
    public partial class Show_Purchase_Item_Form : Form
    {
        DB_Connection database = new DB_Connection();

        private int Manage_id;

        public Show_Purchase_Item_Form(int manage_id)
        {
            InitializeComponent();
            this.Manage_id = manage_id;
            view_purchase_item();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void view_purchase_item()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();

                string sql = "SELECT item.ItemStock_ID, i.Item_Code, i.Item_Name, pi.Purchase_Quantity, pi.Amount " +
                             "FROM Purchase_Item pi " +
                             "JOIN Item_Stock item ON pi.ItemStock_ID = item.ItemStock_ID " +
                             "JOIN Item i ON item.Item_ID = i.Item_ID " +
                             "WHERE pi.Purchase_ID = @ManageID";

                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@ManageID", Manage_id);
                SqlDataReader reader = command.ExecuteReader();

                data_Purchase_Item.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Purchase_Item.Rows.Add(i, reader["Item_Code"].ToString(), reader["Item_Name"].ToString(), reader["Purchase_Quantity"].ToString(),
                                                   reader["Amount"].ToString());
                }
                reader.Close();
                connect.Close();
            }
        }
    }
}
