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
    public partial class Restock_Product_Form : Form
    {
        DB_Connection database = new DB_Connection();
        View_Stock_List_Form frm;

        public Restock_Product_Form(View_Stock_List_Form stock)
        {
            InitializeComponent();
            show_item();
            frm = stock;
        }

        public string stock_ProductID;
        private int stockItemID;

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txt_Put_Quantity.Clear();
            txt_Put_Quantity.Focus();
        }

        public void show_item()
        {

            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT s.StockItem_ID, i.Item_Code, s.Stock_Quantity FROM Stock_Item s JOIN Item i ON s.Item_ID = i.Item_ID WHERE s.Stock_Quantity > 0 ";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string stock_itemName = reader.GetString(1);
                    cmd_Stock.Items.Add(stock_itemName);
                }

                reader.Close();
                connect.Close();
            }
            cmd_Stock.SelectedIndexChanged += cmd_Stock_SelectedIndexChanged;
        }

        private void cmd_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_itemCode = cmd_Stock.SelectedItem.ToString();

            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT s.StockItem_ID, s.Stock_Quantity FROM Stock_Item s JOIN Item i ON s.Item_ID = i.Item_ID WHERE i.Item_Code = @ItemCode";
                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@ItemCode", selected_itemCode);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    stockItemID = reader.GetInt32(0);
                    int stockQuantity = reader.GetInt32(1);
                    txt_StockQyt.Text = stockQuantity.ToString();
                }
                else
                {
                    stockItemID = 0; 
                    txt_StockQyt.Text = string.Empty;
                }

                reader.Close();
                connect.Close();
            }
        }

        // the quantity of product in database
        private void btn_Restock_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_Put_Quantity.Text) || String.IsNullOrEmpty(txt_StockQyt.Text) )
            {
                MessageBox.Show("No input quantity ");
            }
            else if (cmd_Stock.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the available stock");
            }
            else
            {
                int stockQuantity = Convert.ToInt32(txt_StockQyt.Text);
                int putQuantity = Convert.ToInt32(txt_Put_Quantity.Text);
                
                if ( 0 == putQuantity)
                {
                    MessageBox.Show("The quantity is zero");
                }
                else if (putQuantity <= stockQuantity)
                {

                    using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                    {
                        connect.Open();

                        // update for product
                        string update_product = "UPDATE Product SET Quantity = Quantity + @Add_Quantity WHERE Product_ID = @Product_ID";
                        SqlCommand command = new SqlCommand(update_product, connect);
                        command.Parameters.AddWithValue("@Product_ID", stock_ProductID);
                        command.Parameters.AddWithValue("@Add_Quantity", Convert.ToInt32(txt_Put_Quantity.Text));
                        command.ExecuteNonQuery();

                        // udapte for stock
                        string update_stock = "UPDATE Stock_Item SET Stock_Quantity = Stock_Quantity - @PutQuantity WHERE StockItem_ID = @StockItemID";
                        SqlCommand update_command = new SqlCommand(update_stock, connect);
                        update_command.Parameters.AddWithValue("@StockItemID", stockItemID);
                        update_command.Parameters.AddWithValue("@PutQuantity", putQuantity);
                        update_command.ExecuteNonQuery();


                        connect.Close();
                        MessageBox.Show("Successfully restock");
                        frm.show_product_stock();
                        frm.show_item_stock();
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

        private void txt_Put_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and delete keys
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true;
            }
            else
            {
                // Get the current text in the TextBox
                string currentText = txt_Put_Quantity.Text;

                // Handle the case of leading zero
                if (currentText == "0" && e.KeyChar != '\b' && e.KeyChar != '\u007F')
                {
                    e.Handled = true;
                }
                else
                {
                    // Allow up to 3 digits and ignore additional input
                    if (currentText.Length >= 3 && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
