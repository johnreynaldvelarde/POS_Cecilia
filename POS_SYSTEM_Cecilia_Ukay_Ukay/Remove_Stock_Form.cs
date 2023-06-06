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

        public Remove_Stock_Form()
        {
            InitializeComponent();
        }

        public string stock_ItemID;

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txt_Quantity.Clear();
            txt_Quantity.Focus();
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
                else if (reduce_quantity >= stock_quantity)
                {
                    using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                    {
                        connect.Open();

                        // update for stock quantity
                        string update_stock = "UPDATE Stock_Item SET Quantity = Quantity - @Subtract_Quantity WHERE StockItem_ID = @StockItem_ID";
                        SqlCommand command = new SqlCommand(update_stock, connect);
                        command.Parameters.AddWithValue("@StockItem_ID", stock_ItemID);
                        command.Parameters.AddWithValue("@Subtract_Quantity", Convert.ToInt32(txt_Reduce_Quantity.Text));
                        command.ExecuteNonQuery();

                        connect.Close();
                        MessageBox.Show("Successfully reduce the stock");
                        Clear();
                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Quantity exceeds the stock limit.");
                    Clear();
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
