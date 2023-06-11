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
using System.Collections;


namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Main_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Main_Form()
        {
            InitializeComponent();
            button_highligted();
            load_category();
            view_product();
        }



        private Color defaultColor = Color.FromArgb(14, 159, 104);
        private Color settingsColor = Color.FromArgb(242, 197, 70);
        private Form activeForm = null;

        // loading of date and time
        private void Main_Form_Load(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Now.ToLongDateString();
            label_Time.Text = DateTime.Now.ToLongTimeString();
            label_amount.Text = "0.00";
        }

        // method for over the mouse color
        public void button_highligted()
        {

            btn_Inventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Inventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Archive.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Archive.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_User.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_User.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Sales_Report.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Sales_Report.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_History.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_History.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)

                activeForm.Close();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            center_panel.Controls.Add(childForm);
            center_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // to clear the data in data grid
        public void Clear_Transaction()
        {
            data_Grid_Transaction.Rows.Clear();
            data_Grid_Transaction.Refresh();
            txt_Payment_Amount.Clear();
            txt_Refund.Clear();
            label_amount.Text = "0.00";
        }

        // button for clear transaction in grid
        private void btn_Clear_All_Click(object sender, EventArgs e)
        {
            Clear_Transaction();
            view_product();
        }

        // method to compute total amount 
        public void get_total()
        {
            /*
            double total = 0;
            label_amount.Text = "";
            foreach (DataGridViewRow item in data_Grid_Transaction.Rows)
            {

                total += double.Parse(item.Cells["Amount"].Value.ToString());

            }

            label_amount.Text = total.ToString("N2");
            */
            double total = 0;
            label_amount.Text = "";

            foreach (DataGridViewRow item in data_Grid_Transaction.Rows)
            {
                total += double.Parse(item.Cells["Amount"].Value.ToString());
            }

            // Check if discount is entered by the user
            if (!string.IsNullOrEmpty(txt_discount.Text))
            {
                // Retrieve discount from txt_Discount control
                int discount = Convert.ToInt32(txt_discount.Text);

                // Apply the discount to the total amount
                total -= total * discount / 100;
            }

            label_amount.Text = total.ToString("N2");

        }


        // load the category list
        public void load_category()
        {
            cmd_Category.Items.Add("All");

            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT Category_Name FROM Categories WHERE Archive = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string categoryName = reader.GetString(0);
                    cmd_Category.Items.Add(categoryName);
                }

                reader.Close();
                connect.Close();
            }
            cmd_Category.SelectedItem = "All";

        }

        // view the product list from database combine of table Product and Categories
        public void view_product()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT ps.ProductStock_ID, p.Product_ID, p.Product_Code, p.Product_Name, p.Price, c.Category_Name, p.Size, ps.ProductStock_Qyt " +
                             "FROM Product p " +
                             "JOIN Categories c ON p.Category_ID = c.Category_ID " +
                             "JOIN Product_Stock ps ON p.Product_ID = ps.Product_ID " +
                             "WHERE ps.ProductStock_Qyt > 0 AND p.Archive = 0";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Available.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Grid_Available.Rows.Add(i, reader["ProductStock_ID"].ToString(), reader["Product_ID"].ToString(), reader["Product_Code"].ToString(),
                                                reader["Product_Name"].ToString(), reader["Category_Name"].ToString(), reader["Price"].ToString(),
                                                reader["Size"].ToString(), "20 %", null, reader["ProductStock_Qyt"].ToString());
                }

                reader.Close();
                connect.Close();
            }
        }

        private void data_Grid_Available_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == data_Grid_Available.Columns["sell"].Index && e.RowIndex >= 0)
            {
                // selected product's details
                int product_stockID = Convert.ToInt32(data_Grid_Available.Rows[e.RowIndex].Cells["ProductStock_ID"].Value);
                int id = Convert.ToInt32(data_Grid_Available.Rows[e.RowIndex].Cells["Product_ID"].Value);
                string productName = data_Grid_Available.Rows[e.RowIndex].Cells["Product_Name"].Value.ToString();
                decimal price = Convert.ToDecimal(data_Grid_Available.Rows[e.RowIndex].Cells["Price"].Value);
                int quantity = Convert.ToInt32(data_Grid_Available.Rows[e.RowIndex].Cells["Quantity"].Value);


                bool productExists = false;
                foreach (DataGridViewRow row in data_Grid_Transaction.Rows)
                {
                    if (row.Cells["productName"].Value.ToString() == productName)
                    {
                        productExists = true;
                        break;
                    }
                }

                // pag ang product ay hnd exist, add it to data_grid_transaction
                if (!productExists)
                {
                    // Calculate the amount
                    decimal amount = price * quantity;

                    // Add the details to data_grid_transaction
                    data_Grid_Transaction.Rows.Add(0, product_stockID, id, productName, price, quantity, amount);
                    get_total();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string column_available = data_Grid_Available.Columns[e.ColumnIndex].Name;

                if (column_available == "Add")
                {
                    int quantity = Convert.ToInt32(data_Grid_Available.Rows[e.RowIndex].Cells["Quantity"].Value);
                    int availableQuantity = Convert.ToInt32(data_Grid_Available.Rows[e.RowIndex].Cells["Quantity"].Value);

                    if (quantity < availableQuantity)
                    {
                        data_Grid_Available.Rows[e.RowIndex].Cells["Quantity"].Value = quantity + 1;
                    }
                }
                else if (column_available == "Minus")
                {
                    int quantity = Convert.ToInt32(data_Grid_Available.Rows[e.RowIndex].Cells["Quantity"].Value);

                    if (quantity > 1)
                    {
                        data_Grid_Available.Rows[e.RowIndex].Cells["Quantity"].Value = quantity - 1;
                    }
                }
            }
        }

        private void data_Grid_Transaction_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int count = 0;
            foreach (DataGridViewRow row in data_Grid_Transaction.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        // button to send the transaction to database
        private void btn_Sell_Click(object sender, EventArgs e)
        {

            int id_staff;

            if (data_Grid_Transaction.Rows.Count == 0)
            {
                MessageBox.Show("No transaction input try again");
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    Account_Class pass = new Account_Class();
                    id_staff = pass.Staff_ID;

                    int total_quantity = 0;
                    decimal total_amount = 0;

                    connect.Open();

                    // for table transaction_log
                    string sql = "INSERT INTO Order_Transaction (Staff_ID, Transaction_Date, Total_Quantity, Total_Amount) VALUES " +
                                 "(@Staff_ID, @Transaction_Date, @Total_Quantity, @Total_Amount); SELECT SCOPE_IDENTITY();";
                    SqlCommand command = new SqlCommand(sql, connect);

                    command.Parameters.AddWithValue("@Staff_ID", id_staff);
                    command.Parameters.AddWithValue("@Transaction_Date", DateTime.Now);

                    // compute the total quantity and total amount
                    foreach (DataGridViewRow row in data_Grid_Transaction.Rows)
                    {
                        int count_quanity = Convert.ToInt32(row.Cells["orderQuantity"].Value);
                        decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);

                        total_quantity += count_quanity;
                        total_amount += amount;
                    }

                    int discount = 0;

                    command.Parameters.AddWithValue("@Total_Quantity", total_quantity);
                    command.Parameters.AddWithValue("@Total_Amount", total_amount);

                    int transactionID = Convert.ToInt32(command.ExecuteScalar());

                    // for table order_transction
                    foreach (DataGridViewRow row in data_Grid_Transaction.Rows)
                    {
                        int productStockID = Convert.ToInt32(row.Cells["productstockID"].Value);
                        int productID = Convert.ToInt32(row.Cells["productID"].Value);
                        int orderQuantity = Convert.ToInt32(row.Cells["orderQuantity"].Value);
                        decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);

                        string sql1 = "INSERT INTO Order_Product (Transaction_ID, Product_ID, Order_Quantity, Amount) VALUES " +
                                      "(@Transaction_ID, @Product_ID, @Order_Quantity, @Amount)";
                        SqlCommand command1 = new SqlCommand(sql1, connect);

                        command1.Parameters.AddWithValue("@Transaction_ID", transactionID);
                        command1.Parameters.AddWithValue("@Product_ID", productID);
                        command1.Parameters.AddWithValue("@Order_Quantity", orderQuantity);
                        command1.Parameters.AddWithValue("@Amount", amount);
                        command1.ExecuteNonQuery();


                        // update
                        string selectProductStock = "SELECT ProductStock_Qyt FROM Product_Stock WHERE ProductStock_ID = @ProductStock_ID";
                        SqlCommand selectProductStockCmd = new SqlCommand(selectProductStock, connect);
                        selectProductStockCmd.Parameters.AddWithValue("@ProductStock_ID", productStockID);
                        int currentQuantity = Convert.ToInt32(selectProductStockCmd.ExecuteScalar());

                        int updatedQuantity = currentQuantity - orderQuantity;

                        string updateProductStock = "UPDATE Product_Stock SET ProductStock_Qyt = @UpdatedQuantity WHERE ProductStock_ID = @ProductStock_ID";
                        SqlCommand updateProductStockCmd = new SqlCommand(updateProductStock, connect);
                        updateProductStockCmd.Parameters.AddWithValue("@ProductStock_ID", productStockID);
                        updateProductStockCmd.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);
                        updateProductStockCmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("New transaction added");
                    connect.Close();
                    Clear_Transaction();
                    view_product();
                }

            }

        }

        // button for user management
        private void btn_User_Click(object sender, EventArgs e)
        {
            btn_User.BackColor = settingsColor;

            User_Form frm = new User_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_User.BackColor = defaultColor;
        }

        // button for inventory
        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            btn_Inventory.BackColor = settingsColor;
            Inventory_Form frm = new Inventory_Form(this);
            frm.ShowDialog();
            frm.Dispose();
            btn_Inventory.BackColor = defaultColor;
            // frm.btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);

        }

        // button for settings
        private void btn_Settings_Click(object sender, EventArgs e)
        {

        }

        // button for trash bin
        private void btn_Trash_Click(object sender, EventArgs e)
        {
            btn_Archive.BackColor = settingsColor;

            Trash_Bin_Form frm = new Trash_Bin_Form(this);
            frm.ShowDialog();
            frm.Dispose();
            btn_Archive.BackColor = defaultColor;
        }
        // button for sales report
        private void btn_Sales_Report_Click(object sender, EventArgs e)
        {
            btn_Sales_Report.BackColor = settingsColor;

            Sales_Report_Form frm = new Sales_Report_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Sales_Report.BackColor = defaultColor;
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            btn_History.BackColor = settingsColor;
            History_Log_Form frm = new History_Log_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_History.BackColor = defaultColor;
        }
        private void user_profile_Click(object sender, EventArgs e)
        {
            Account_Class account = new Account_Class();
            Profile_Popup_Form frm = new Profile_Popup_Form();
            frm.popup_picture.Image = account.Staff_Image;
            frm.popup_staff_name.Text = account.Staff_Name;
            frm.lblupper_role.Text = account.Staff_Role + " Mode";
            frm.ShowDialog();
            frm.Dispose();
        }
        private void picture_account_Click(object sender, EventArgs e)
        {

        }
        // moving time
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void txt_Payment_Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Refund.Text = (Convert.ToDecimal(txt_Payment_Amount.Text) - Convert.ToDecimal(label_amount.Text)).ToString();
            }
            catch
            {
                txt_Refund.Text = string.Empty;
            }
        }

        private void txt_Payment_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void filter_data_available(string filterText)
        {
            foreach (DataGridViewRow row in data_Grid_Available.Rows)
            {
                string p_code = row.Cells["Product_Code"].Value?.ToString();
                string p_name = row.Cells["Product_Name"].Value?.ToString();
                string c_tegory = row.Cells["Category"].Value?.ToString();

                if (p_code != null && p_code.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p_name != null && p_name.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    c_tegory != null && c_tegory.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }


        private void txt_mainsearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_mainsearch.Text;
            filter_data_available(filterText);
        }

        private void data_Grid_Transaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_order = data_Grid_Transaction.Columns[e.ColumnIndex].Name;
            if (column_order == "Remove")
            {
                DataGridViewRow selectedRow = data_Grid_Transaction.Rows[e.RowIndex];
                data_Grid_Transaction.Rows.Remove(selectedRow);
                view_product();
            }
        }

        private void cmd_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmd_Category.SelectedItem?.ToString();
            if (selectedCategory == "All")
            {
                foreach (DataGridViewRow row in data_Grid_Available.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                filter_data_available(selectedCategory);
            }
        }

        private void filter_data_cmdCategory(string filterText)
        {
            foreach (DataGridViewRow row in data_Grid_Available.Rows)
            {
                string category = row.Cells["Category"].Value?.ToString();

                if (filterText == "All" || category.Equals(filterText, StringComparison.OrdinalIgnoreCase))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }

            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and delete keys
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '\b') // Handle backspace key
            {
                // No further action needed for backspace key
            }
            else
            {
                // Get the current text in the TextBox
                string currentText = txt_discount.Text;

                // Handle the case of leading zero
                if (currentText == "0")
                {
                    e.Handled = true;
                }
                else
                {
                    // Allow up to 3 digits and restrict input to values up to 100
                    if (currentText.Length >= 2 || (currentText.Length == 1 && currentText[0] != '0'))
                    {
                        int value;
                        bool isNumeric = int.TryParse(currentText + e.KeyChar, out value);
                        if (!isNumeric || value > 100)
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
    }
}
