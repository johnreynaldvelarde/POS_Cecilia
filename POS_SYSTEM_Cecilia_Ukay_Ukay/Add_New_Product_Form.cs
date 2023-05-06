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
    public partial class Add_New_Product_Form : Form
    {
       // SqlConnection connect = new SqlConnection();
        DB_Connection database = new DB_Connection();


        public Add_New_Product_Form()
        {
            InitializeComponent();
          //  connect = new SqlConnection(database.MyConnection());


        }

        public void Clear()
        {

        }

        // button for exit
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // button for save the details in database
        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "INSERT INTO Products_List (ProductId, ProductName, ProductQuantity) VALUES (@ProductId, @ProductName, @ProductQuantity)";
                SqlCommand command = new SqlCommand(sql, connect);

                command.Parameters.AddWithValue("@ProductId", Convert.ToInt32(txt_ProductID.Text));
                command.Parameters.AddWithValue("@ProductName", txt_Product_Name.Text);
                command.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt32(txt_Qyt));
                command.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Successfully added!!!");
                Clear();

            }
        }

        // button for clear
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // button for getting product image
        private void btn_Product_Image_Click(object sender, EventArgs e)
        {

        }
    }
}
