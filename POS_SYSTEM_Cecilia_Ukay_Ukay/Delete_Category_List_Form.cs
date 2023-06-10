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
    public partial class Delete_Category_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Delete_Category_List_Form()
        {
            InitializeComponent();
            show_delete_category();
        }

        public void show_delete_category()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {

                int i = 0;
                connect.Open();
                string sql = "SELECT Category_ID, Category_Name, Date_Added, Archive FROM Categories WHERE Archive = 1 ";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Delete_Category.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "1")
                    {
                        i += 1;
                        data_Delete_Category.Rows.Add(i, reader["Category_ID"].ToString(), reader["Category_Name"].ToString(), reader["Date_Added"].ToString());
                    }

                }
                reader.Close();
                connect.Close();
            }
        }

        private void data_Delete_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string delete_category = data_Delete_Category.Columns[e.ColumnIndex].Name;
            if (delete_category == "Restore")
            {
                if (MessageBox.Show("Do you want to restore this product?", "Restore the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.ColumnIndex == data_Delete_Category.Columns["Restore"].Index && e.RowIndex >= 0)
                    {
                        int id = Convert.ToInt32(data_Delete_Category.Rows[e.RowIndex].Cells["Category_ID"].Value);

                        using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                        {

                            connect.Open();
                            string sql = "UPDATE Categories SET Archive = 0 WHERE Category_ID = @Category_ID";
                            SqlCommand command = new SqlCommand(sql, connect);
                            command.Parameters.AddWithValue("@Category_ID", Convert.ToInt32(id));
                            command.ExecuteNonQuery();
                            connect.Close();

                        }

                        data_Delete_Category.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }
    }
}
