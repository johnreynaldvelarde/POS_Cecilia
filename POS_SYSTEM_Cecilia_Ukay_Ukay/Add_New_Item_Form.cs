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
        Item_List_Form frm;

        public Add_New_Item_Form(Item_List_Form item)
        {
            InitializeComponent();
            frm = item;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txt_Item_Name.Clear();
            txt_Price.Clear();
            cmd_Piece.SelectedIndex = -1;
            txt_Item_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_Item_Name.Text) || String.IsNullOrEmpty(txt_Price.Text) || String.IsNullOrEmpty(txt_Item_Code.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else if (cmd_Piece.SelectedIndex == -1)
            {
                MessageBox.Show("Please select per piece");
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string insert_item = "INSERT INTO Item (Item_Code, Item_Name, Price, Per_Piece, Date_Added, Archive) VALUES " +
                                         "(@Item_Code, @Item_Name, @Price, @Per_Piece, @Date_Added, @Archive); SELECT SCOPE_IDENTITY();";
                    SqlCommand insert_command = new SqlCommand(insert_item, connect);
                    insert_command.Parameters.AddWithValue("@Item_Code", txt_Item_Code.Text);
                    insert_command.Parameters.AddWithValue("@Item_Name", txt_Item_Name.Text);
                    insert_command.Parameters.AddWithValue("@Price", Convert.ToDouble(txt_Price.Text));
                    insert_command.Parameters.AddWithValue("@Per_Piece", cmd_Piece.SelectedItem);
                    insert_command.Parameters.AddWithValue("@Date_Added", DateTime.Parse(txt_Date_Added.Text));
                    insert_command.Parameters.AddWithValue("@Archive", 0);
                   
               
                    int itemID = Convert.ToInt32(insert_command.ExecuteScalar());

                    string insert_stock = "INSERT INTO Stock_Item (Item_ID, Stock_Quantity) VALUES (@Item_ID, @Stock_Quantity)";
                    SqlCommand command_stock = new SqlCommand(insert_stock, connect);
                    command_stock.Parameters.AddWithValue("@Item_ID", itemID);
                    command_stock.Parameters.AddWithValue("@Stock_Quantity", 0);
                    command_stock.ExecuteNonQuery();
                    
                    connect.Close();
                    MessageBox.Show("Successfully added");
                    frm.show_item_list();
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
            txt_Date_Added.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {


            }
            else if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ascii code 48-57 between 0-9
            {
                e.Handled = true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
