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
    public partial class Supplier_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Supplier_List_Form()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Supplier_Click(object sender, EventArgs e)
        {
            Add_New_Supplier_Form frm = new Add_New_Supplier_Form();
            frm.ShowDialog();
        }

        public void view_supplier_()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT Supplier_ID, Supplier_Name, Address, Contact_Number, Email, Deleted FROM Supplier WHERE Archive = 0";
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
    }
}
