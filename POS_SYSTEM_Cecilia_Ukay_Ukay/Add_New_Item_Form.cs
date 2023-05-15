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
    public partial class Add_New_Item_Form : Form
    {
        public Add_New_Item_Form()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into product (productPrice, code, productName, quantity)  values (@productPrice, @code, @productName, @quantity)");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@productPrice", decimal.Parse(txt_Price.Text));
            //cmd.Parameters.AddWithValue("@categoryProduct", txt);
            cmd.Parameters.AddWithValue("@code", txt_Product_Code.Text);
            cmd.Parameters.AddWithValue("@productName", txt_Product_Name.Text);
            cmd.Parameters.AddWithValue("@quantity", int.Parse(txt_Availability.Text));

            con.Open();
            cmd.ExecuteNonQuery();

        }

        private void txt_Availability_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
