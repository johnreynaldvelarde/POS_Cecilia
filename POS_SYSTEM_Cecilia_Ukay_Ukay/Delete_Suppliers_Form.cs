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
    public partial class Delete_Suppliers_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Delete_Suppliers_Form()
        {
            InitializeComponent();
            Delete_Supplier();

        }

        public void Delete_Supplier()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT Supplier_ID, Supplier_Name, Date_Added FROM Suppliers WHERE Archive = 1";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Delete_Supplier.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Delete_Supplier.Rows.Add(i, reader["Supplier_ID"].ToString(), reader["Supplier_Name"].ToString(), reader["Date_Added"].ToString());
                }

                reader.Close();
                connect.Close();
            }
        }


        private void data_Delete_Supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnSupplier = data_Delete_Supplier.Columns[e.ColumnIndex].Name;

            if (columnSupplier == "Restore")
            {

                if (MessageBox.Show("Do you want to restore this supplier?", "Restore the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.ColumnIndex == data_Delete_Supplier.Columns["Restore"].Index && e.RowIndex >= 0)
                    {
                        int id = Convert.ToInt32(data_Delete_Supplier.Rows[e.RowIndex].Cells["Supplier_ID"].Value);

                        using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                        {

                            connect.Open();
                            string sql = "UPDATE Suppliers SET Archive = 0 WHERE Supplier_ID = @Supplier_ID";
                            SqlCommand command = new SqlCommand(sql, connect);
                            command.Parameters.AddWithValue("@Supplier_ID", Convert.ToInt32(id));
                            command.ExecuteNonQuery();
                            connect.Close();

                        }

                        data_Delete_Supplier.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }

        private void Delete_Suppliers_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

