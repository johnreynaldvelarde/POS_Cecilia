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

        View_Stock_List_Form frm;
        public Purchase_Order_Form(View_Stock_List_Form order)
        {
            InitializeComponent();
            view_supplier();
            view_stock();
            frm = order;
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

            Account_Class account = new Account_Class();
            txtUsername.Text = account.Staff_Name;

            if (account.Staff_Role == "Default")
            {
                btn_Buy.Enabled = false;
            }
            else
            {
                btn_Buy.Enabled = true;
            }
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
                string sql = "SELECT s.ItemStock_ID, i.Item_Code, s.ItemStock_Qyt, i.Archive " +
                             "FROM Item_Stock s JOIN Item i ON s.Item_ID = i.Item_ID " +
                             "WHERE i.Archive = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "0")
                    {
                        string stock_itemName = reader.GetString(1);
                        cmd_item_purchase.Items.Add(stock_itemName);
                    }
                      
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
                string sql = "SELECT s.ItemStock_ID, s.ItemStock_Qyt FROM Item_Stock s JOIN Item i ON s.Item_ID = i.Item_ID WHERE i.Item_Code = @ItemCode";
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
            int ss_id;

            if (cmd_Supplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier.");
            }
            else if (cmd_item_purchase.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the item");
            }
            else if (data_Grid_Purchase.RowCount == 0)
            {
                MessageBox.Show("The table is empty. Please add items.");
            }
            else
            {
                int supplierId = 0;

                string selectedSupplier = cmd_Supplier.SelectedItem.ToString();

                // looking for  Supplier_ID value in the Suppliers table
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string sql = "SELECT Supplier_ID FROM Suppliers WHERE Supplier_Name = @Supplier_Name AND Archive = 0";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Supplier_Name", selectedSupplier);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        supplierId = Convert.ToInt32(result);
                    }
                    connect.Close();
                }

                // for putting input in purhcase log in database
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    Account_Class pass = new Account_Class();
                    ss_id = pass.Staff_ID;

                    int staff_id = 1;
                    decimal total_amount = 0;

                    connect.Open();

                    string sql1 = "INSERT INTO Purchase_Transaction (Staff_ID, Supplier_ID, Purchase_Date, Total_Amount) VALUES " +
                                  "(@Staff_ID, @Supplier_ID, @Purchase_Date, @Total_Amount); SELECT SCOPE_IDENTITY();";
                    SqlCommand command1 = new SqlCommand(sql1, connect);
                    command1.Parameters.AddWithValue("@Staff_ID", ss_id);
                    command1.Parameters.AddWithValue("@Supplier_ID", supplierId);
                    command1.Parameters.AddWithValue("@Purchase_Date", DateTime.Now);

                    foreach (DataGridViewRow row in data_Grid_Purchase.Rows)
                    {
                        decimal amount = Convert.ToDecimal(row.Cells[7].Value);
                        total_amount += amount;
                    }
                    command1.Parameters.AddWithValue("@Total_Amount", total_amount);

                    int purchaseID = Convert.ToInt32(command1.ExecuteScalar());

                    // for purchase item
                    foreach (DataGridViewRow row in data_Grid_Purchase.Rows)
                    {
                        int stockitemID = Convert.ToInt32(row.Cells[1].Value);
                        int itemQuantity = Convert.ToInt32(row.Cells[5].Value);
                        decimal itemAmount = Convert.ToDecimal(row.Cells[7].Value);

                        string sql2 = "INSERT INTO Purchase_Item (Purchase_ID, ItemStock_ID, Purchase_Quantity, Amount ) VALUES" +
                                      "(@Purchase_ID, @ItemStock_ID, @Purchase_Quantity, @Amount );";

                        SqlCommand command2 = new SqlCommand(sql2, connect);

                        command2.Parameters.AddWithValue("@Purchase_ID", purchaseID);
                        command2.Parameters.AddWithValue("@ItemStock_ID", stockitemID);
                        command2.Parameters.AddWithValue("@Purchase_Quantity", itemQuantity);
                        command2.Parameters.AddWithValue("@Amount", itemAmount);
                        command2.ExecuteNonQuery();


                        // for select /update the table product and reduce the quantity of specific product
                        string selectStockItem = "SELECT ItemStock_Qyt FROM Item_Stock WHERE ItemStock_ID = @ItemStock_ID";
                        SqlCommand select_stock = new SqlCommand(selectStockItem, connect);
                        select_stock.Parameters.AddWithValue("@ItemStock_ID", stockitemID);

                        int current_quantity = Convert.ToInt32(select_stock.ExecuteScalar());

                        int update_quantity = current_quantity + itemQuantity;

                        string updateStockItem = "UPDATE Item_Stock SET ItemStock_Qyt = @UpdatedQuantity WHERE ItemStock_ID = @ItemStock_ID";
                        SqlCommand update_stock = new SqlCommand(updateStockItem, connect);
                        update_stock.Parameters.AddWithValue("@ItemStock_ID", stockitemID);
                        update_stock.Parameters.AddWithValue("@UpdatedQuantity", update_quantity);
                        update_stock.ExecuteNonQuery();

                    }
                    MessageBox.Show("New purchase order added");
                    connect.Close();
                    Clear_Purchase();
                    frm.show_item_stock();
                    this.Close();
                }
            }
        }

        private void data_Grid_Purchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_purchase= data_Grid_Purchase.Columns[e.ColumnIndex].Name;
            if (column_purchase == "Cancel")
            {
                DataGridViewRow selectedRow = data_Grid_Purchase.Rows[e.RowIndex];
                data_Grid_Purchase.Rows.Remove(selectedRow);
                get_total();
            }
        }
    }
}
