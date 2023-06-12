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
    public partial class Delete_Item_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Delete_Item_List_Form()
        {
            InitializeComponent();
            show_delete_item();
        }

        public void show_delete_item()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {

                int i = 0;
                connect.Open();
                string sql = "SELECT Item_ID, Item_Name, Date_Added, Archive FROM Item WHERE Archive = 1 ";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Delete_Item.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "1")
                    {
                        i += 1;
                        data_Delete_Item.Rows.Add(i, reader["Item_ID"].ToString(), reader["Item_Name"].ToString(), reader["Date_Added"].ToString());
                    }

                }
                reader.Close();
                connect.Close();
            }
        }

        private void data_Delete_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnItem = data_Delete_Item.Columns[e.ColumnIndex].Name;

            if (columnItem == "Restore")
            {

                if (MessageBox.Show("Do you want to restore this item?", "Restore the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.ColumnIndex == data_Delete_Item.Columns["Restore"].Index && e.RowIndex >= 0)
                    {
                        int id = Convert.ToInt32(data_Delete_Item.Rows[e.RowIndex].Cells["Item_ID"].Value);

                        using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                        {

                            connect.Open();
                            string sql = "UPDATE Item SET Archive = 0 WHERE Item_ID = @Item_ID";
                            SqlCommand command = new SqlCommand(sql, connect);
                            command.Parameters.AddWithValue("@Item_ID", Convert.ToInt32(id));
                            command.ExecuteNonQuery();
                            connect.Close();

                        }

                        data_Delete_Item.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }
    }
}
