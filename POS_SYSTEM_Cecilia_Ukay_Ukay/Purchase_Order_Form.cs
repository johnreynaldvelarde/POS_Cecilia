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
            view_stock();
        }

        private int stock_ID;

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Purchase_Order_Form_Load(object sender, EventArgs e)
        {
            txt_Date_Created.Text = DateTime.Now.ToLongDateString();
            label_amount.Text = "0.00";
        }

        public void Clear_Purchase()
        {
            data_Grid_Purchase.Rows.Clear();
            data_Grid_Purchase.Refresh();
            label_amount.Text = "0.00";
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

        public void view_stock()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT s.StockItem_ID, i.Item_Code, s.Stock_Quantity FROM Stock_Item s JOIN Item i ON s.Item_ID = i.Item_ID";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string stock_itemName = reader.GetString(1);
                    cmd_item_purchase.Items.Add(stock_itemName);
                }

                reader.Close();
                connect.Close();
            }
            cmd_item_purchase.SelectedIndexChanged += cmd_item_purchase_SelectedIndexChanged;
        }

        private void cmd_item_purchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_item = cmd_item_purchase.SelectedItem.ToString();

            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT s.StockItem_ID, s.Stock_Quantity FROM Stock_Item s JOIN Item i ON s.Item_ID = i.Item_ID WHERE i.Item_Code = @ItemCode";
                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@ItemCode", select_item);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    stock_ID = reader.GetInt32(0);
                    int stockQuantity = reader.GetInt32(1);
                    txt_ShowQyt.Text = stockQuantity.ToString();
                }
                else
                {
                    stock_ID = 0;
                    txt_ShowQyt.Text = string.Empty;
                }

                reader.Close();
                connect.Close();
            }
        }

        // add to data grid
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmd_item_purchase.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the available item");
            }
            else if (cmd_quantity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a quantity");
            }
            else
            {
                string selectedItemCode = cmd_item_purchase.SelectedItem.ToString();
                int choose_quantity = Convert.ToInt32(cmd_quantity.SelectedItem);

                // Fetch the item details from the database based on the selected item code
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {

                    connect.Open();
                    string sql = "SELECT i.Item_ID, i.Item_Name, i.Price, i.Per_Piece FROM Item i WHERE i.Item_Code = @ItemCode";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@ItemCode", selectedItemCode);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int itemID = reader.GetInt32(0);
                        string itemName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int perPiece = reader.GetInt32(3);

                        int total_quantity = choose_quantity * perPiece;
                        decimal total_amount = price * choose_quantity;


                        bool purchaseExists = false;

                        foreach (DataGridViewRow row in data_Grid_Purchase.Rows)
                        {
                            if (row.Cells["itemCode"].Value != null && row.Cells["itemCode"].Value.ToString() == selectedItemCode)
                            {
                                purchaseExists = true;
                                break;
                            }
                        }

                        if (!purchaseExists)
                        {
                            // Add the row only if the item does not already exist in the data grid
                            data_Grid_Purchase.Rows.Add(0, itemID, selectedItemCode, itemName, price, perPiece, total_quantity, total_amount);
                            get_total();
                        }

                    }

                    reader.Close();
                }

            }

            // Clear the combo box and quantity textbox for the next selection
            // cmd_item_purchase.SelectedIndex = -1;
            //txt_Quantity.Text = string.Empty;
        }

        // method to compute total amount 
        public void get_total()
        {

            double total = 0;
            label_amount.Text = "";
            foreach (DataGridViewRow item in data_Grid_Purchase.Rows)
            {

                total += double.Parse(item.Cells[7].Value.ToString());

            }

            label_amount.Text = total.ToString("N2");

        }

        private void data_Grid_Purchase_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in data_Grid_Purchase.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void btn_Clear_All_Click(object sender, EventArgs e)
        {
            Clear_Purchase();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {

        }
    }
}
