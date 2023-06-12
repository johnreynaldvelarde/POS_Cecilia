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
    public partial class Delete_Product_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

    
        public Delete_Product_List_Form()
        {
            InitializeComponent();
            show_delete_product();
        }

        public void show_delete_product()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {

                int i = 0;
                connect.Open();
                string sql = "SELECT Product_ID, Product_Name, Date_Added, Archive FROM Product WHERE Archive = 1 ";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Delete_Product.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "1")
                    {
                        i += 1;
                        data_Delete_Product.Rows.Add(i, reader["Product_ID"].ToString(), reader["Product_Name"].ToString(), reader["Date_Added"].ToString());
                    }

                }
                reader.Close();
                connect.Close();
            }
        }

        private void data_Delete_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnProduct = data_Delete_Product.Columns[e.ColumnIndex].Name;
            if (columnProduct == "Restore")
            {

                if (MessageBox.Show("Do you want to restore this product?", "Restore the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.ColumnIndex == data_Delete_Product.Columns["Restore"].Index && e.RowIndex >= 0)
                    {
                        int id = Convert.ToInt32(data_Delete_Product.Rows[e.RowIndex].Cells["Product_ID"].Value);

                        using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                        {

                            connect.Open();
                            string sql = "UPDATE Product SET Archive = 0 WHERE Product_ID = @Product_ID";
                            SqlCommand command = new SqlCommand(sql, connect);
                            command.Parameters.AddWithValue("@Product_ID", Convert.ToInt32(id));
                            command.ExecuteNonQuery();
                            connect.Close();

                        }

                        data_Delete_Product.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }
    }
}
