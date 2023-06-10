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
    public partial class Remove_Stock_Form : Form
    {
        DB_Connection database = new DB_Connection();

        View_Stock_List_Form frm;
        public Remove_Stock_Form(View_Stock_List_Form stock)
        {
            InitializeComponent();
            frm = stock;
        }

        public string stock_ItemID;

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txt_Reduce_Quantity.Clear();
            txt_Reduce_Quantity.Focus();
        }


        private void btn_Reduce_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Quantity.Text))
            {
                MessageBox.Show("No input quantity ");
            }
            else
            {
                int stock_quantity = Convert.ToInt32(txt_Quantity.Text);
                int reduce_quantity = Convert.ToInt32(txt_Reduce_Quantity.Text);

                if (0 == reduce_quantity)
                {
                    MessageBox.Show("The quantity is zero");
                }
                else if (reduce_quantity > stock_quantity)
                {
                    MessageBox.Show("Quantity exceeds the stock limit.");
                    Clear();
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                    {
                        connect.Open();

                        // update for stock quantity
                        string update_stock = "UPDATE Item_Stock SET ItemStock_Qyt = ItemStock_Qyt - @Subtract_Quantity WHERE ItemStock_ID = @ItemStock_ID";
                        SqlCommand command = new SqlCommand(update_stock, connect);
                        command.Parameters.AddWithValue("@ItemStock_ID", stock_ItemID);
                        command.Parameters.AddWithValue("@Subtract_Quantity", Convert.ToInt32(txt_Reduce_Quantity.Text));
                        command.ExecuteNonQuery();

                        connect.Close();
                        MessageBox.Show("Successfully reduce the stock");
                        Clear();
                        frm.show_item_stock();
                        this.Close();

                    }
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
