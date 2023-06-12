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
using System.Diagnostics;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Supplier_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Supplier_List_Form()
        {
            InitializeComponent();
            view_supplier();
        }

        private string supplierID, supplierName, supplierAddress, supplierNumber, supplierEmail;

        private void btn_Add_New_Supplier_Click(object sender, EventArgs e)
        {
            Add_New_Supplier_Form frm = new Add_New_Supplier_Form(this);
            frm.btn_Update.Enabled = false;
            frm.ShowDialog();
        }

        public void view_supplier()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT Supplier_ID, Supplier_Name, Address, Contact_Number, Email, Archive FROM Suppliers WHERE Archive = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Supplier.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Grid_Supplier.Rows.Add(i, reader["Supplier_ID"].ToString(), reader["Supplier_Name"].ToString(), reader["Address"].ToString(),
                                                   reader["Contact_Number"].ToString(), reader["Email"].ToString());
                }
                reader.Close();
                connect.Close();

            }
        }

        private void data_Grid_Supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_supplier = data_Grid_Supplier.Columns[e.ColumnIndex].Name;
            if (column_supplier == "Edit")
            {
                Add_New_Supplier_Form frm = new Add_New_Supplier_Form(this);
                frm.btn_Save.Enabled = false;
                frm.label_title_supplier.Text = "Update the supplier";
                frm.supplier_id = supplierID;
                frm.txt_Supplier_Name.Text = supplierName;
                frm.txt_Address.Text = supplierAddress;
                frm.txt_Contact_Number.Text = supplierNumber;
                frm.txt_Email.Text = supplierEmail;
                frm.ShowDialog();

            }
            else if (column_supplier == "Delete")
            {
                if (e.ColumnIndex == data_Grid_Supplier.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Do you want to delete this supplier?", "Delete the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                        {
                            connect.Open();
                            string sql = "UPDATE Suppliers SET Archive = 1 WHERE Supplier_ID = @Supplier_ID";
                            SqlCommand command = new SqlCommand(sql, connect);
                            command.Parameters.AddWithValue("@Supplier_ID", Convert.ToInt32(supplierID));
                            command.ExecuteNonQuery();
                            connect.Close();

                        }

                        data_Grid_Supplier.Rows.RemoveAt(e.RowIndex);
                        view_supplier();
                    }
                }
            }
        }

        private void data_Grid_Supplier_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Grid_Supplier.CurrentRow != null)
            {
                int i = data_Grid_Supplier.CurrentRow.Index;
                supplierID = data_Grid_Supplier[1, i].Value.ToString();
                supplierName = data_Grid_Supplier[2, i].Value.ToString();
                supplierAddress = data_Grid_Supplier[3, i].Value.ToString();
                supplierNumber = data_Grid_Supplier[4, i].Value.ToString();
                supplierEmail = data_Grid_Supplier[5, i].Value.ToString();

            }
        }
    }
}
