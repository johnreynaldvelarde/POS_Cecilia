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
    public partial class Purchase_Order_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Purchase_Order_Form()
        {
            InitializeComponent();
            view_supplier();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Purchase_Order_Form_Load(object sender, EventArgs e)
        {
            txt_Date_Created.Text = DateTime.Now.ToLongDateString();
        }

        public void view_supplier()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {

                connect.Open();
                string sql = "SELECT Supplier_Name FROM Suppliers WHERE Archive = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string supplierName = reader.GetString(0);
                    cmd_Supplier.Items.Add(supplierName);
                }

                reader.Close();
                connect.Close();
            }
        }
    }
}
