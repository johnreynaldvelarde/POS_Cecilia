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


    public partial class Delete_Staff_Account_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Delete_Staff_Account_Form()
        {
            InitializeComponent();
            show_delete_staff();
        }

        public void show_delete_staff()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {

                int i = 0;
                connect.Open();
                string sql = "SELECT Staff_ID, Staff_Name, Date_Added, Archive FROM Staff_Account WHERE Archive = 1 ";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Delete_Staff.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "1")
                    {
                        i += 1;
                        data_Delete_Staff.Rows.Add(i, reader["Staff_ID"].ToString(), reader["Staff_Name"].ToString(), reader["Date_Added"].ToString());
                    }

                }
                reader.Close();
                connect.Close();
            }
        }

        private void data_Delete_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnSupplier = data_Delete_Staff.Columns[e.ColumnIndex].Name;

            if (columnSupplier == "Restore")
            {

                if (MessageBox.Show("Do you want to restore this staff", "Restore the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.ColumnIndex == data_Delete_Staff.Columns["Restore"].Index && e.RowIndex >= 0)
                    {
                        int id = Convert.ToInt32(data_Delete_Staff.Rows[e.RowIndex].Cells["Staff_ID"].Value);

                        using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                        {

                            connect.Open();
                            string sql = "UPDATE Staff_Account SET Archive = 0 WHERE Staff_ID = @Staff_ID";
                            SqlCommand command = new SqlCommand(sql, connect);
                            command.Parameters.AddWithValue("@Staff_ID", Convert.ToInt32(id));
                            command.ExecuteNonQuery();
                            connect.Close();

                        }

                        data_Delete_Staff.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }
    }
}
