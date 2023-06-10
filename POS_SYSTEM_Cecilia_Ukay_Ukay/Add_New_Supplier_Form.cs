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
    public partial class Add_New_Supplier_Form : Form
    {

        DB_Connection database = new DB_Connection();

        Supplier_List_Form frm;

        public string supplier_id;

        public Add_New_Supplier_Form(Supplier_List_Form supplier)
        {
            InitializeComponent();
            frm = supplier;
        }

        public void Clear()
        {
            txt_Supplier_Name.Clear();
            txt_Address.Clear();
            txt_Contact_Number.Clear();
            txt_Email.Clear();
            txt_Supplier_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Supplier_Name.Text) || String.IsNullOrEmpty(txt_Address.Text) || String.IsNullOrEmpty(txt_Contact_Number.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();

                    string sql = "INSERT INTO Suppliers (Supplier_Name, Address, Contact_Number, Email, Archive) VALUES (@Supplier_Name, @Address, @Contact_Number, @Email, @Archive)";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Supplier_Name", txt_Supplier_Name.Text);
                    command.Parameters.AddWithValue("@Address", txt_Address.Text);
                    command.Parameters.AddWithValue("@Contact_Number", txt_Contact_Number.Text);
                    command.Parameters.AddWithValue("@Email", txt_Email.Text);
                    command.Parameters.AddWithValue("@Archive", 0);
                    command.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("Successfully saved");
                    frm.view_supplier();
                    Clear();
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
