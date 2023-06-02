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
using Microsoft.Office.Interop.Excel;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Add_New_Item_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Add_New_Item_Form()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txt_Item_Name.Clear();
            txt_Price.Clear();
            txt_Item_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_Item_Name.Text) || String.IsNullOrEmpty(txt_Price.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string sql = "INSERT INTO Item (Item_Name, Price, Date_Added, Archive) VALUES (@Item_Name, @Price, @Date_Added, @Archive)";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Item_Name", txt_Item_Name.Text);
                    command.Parameters.AddWithValue("@Price", Convert.ToDouble(txt_Price.Text));
                    command.Parameters.AddWithValue("@Date_Added", DateTime.Parse(txt_Date_Added.Text));
                    command.Parameters.AddWithValue("@Archive", 0);
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Successfully added");
                    Clear();
                }
            }
            /*
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
            */

        }



        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Add_New_Item_Form_Load(object sender, EventArgs e)
        {
            txt_Date_Added.Text = DateTime.Now.ToLongDateString();
        }
    }
}
