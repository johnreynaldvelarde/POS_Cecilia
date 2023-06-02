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
            btn_Settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

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

            double total = 0;
            label_amount.Text = "";
            foreach (DataGridViewRow item in data_Grid_Transaction.Rows)
            {

                total += double.Parse(item.Cells[5].Value.ToString());

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
                string sql = "SELECT p.Product_ID, p.Product_Name, p.Price, p.Quantity, c.Category_Name, p.Size  " +
                             "FROM Product p JOIN Categories c ON p.Category_ID = c.Category_ID WHERE p.Quantity > 0 AND p.Archive = 0;";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Available.Rows.Clear();

                while (reader.Read())
                {

                    i += 1;
                    data_Grid_Available.Rows.Add(i, reader["Product_ID"].ToString(), reader["Product_Name"].ToString(), reader["Category_Name"].ToString(), reader["Price"].ToString(),
                                                    reader["Size"].ToString(), "20 %", null, reader["Quantity"].ToString());

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
                int id = Convert.ToInt32(data_Grid_Available.Rows[e.RowIndex].Cells["Product_ID"].Value);
                string productName = data_Grid_Available.Rows[e.RowIndex].Cells["Product_Name"].Value.ToString();
                decimal price = Convert.ToDecimal(data_Grid_Available.Rows[e.RowIndex].Cells["Price"].Value);
                int quantity = Convert.ToInt32(data_Grid_Available.Rows[e.RowIndex].Cells["Quantity"].Value);

                // Calculate the amount
                // decimal amount = price * quantity;

                // Add the details to data_grid_transaction

                //data_Grid_Transaction.Rows.Add(0, id, productName, price, quantity, amount);

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
                    data_Grid_Transaction.Rows.Add(0, id, productName, price, quantity, amount);
                    get_total();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //   DataGridView dataGridView = (DataGridView)sender;
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
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "";
                SqlCommand command = new SqlCommand(sql, connect);





                connect.Close();
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
            Inventory_Form frm = new Inventory_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Inventory.BackColor = defaultColor;
            // frm.btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);

        }

        // button for settings
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            btn_Settings.BackColor = settingsColor;

            Settings_Form frm = new Settings_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Settings.BackColor = defaultColor;
        }

        // button for trash bin
        private void btn_Trash_Click(object sender, EventArgs e)
        {
            btn_Archive.BackColor = settingsColor;

            Trash_Bin_Form frm = new Trash_Bin_Form();
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
            Profile_Popup_Form frm = new Profile_Popup_Form();
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
        public void aa()
        {
            /*
                 i += 1;
                 string productName = reader["Product_Name"].ToString();
                 string price = reader["Price"].ToString();
                 string quantity = reader["Quantity"].ToString();
                 string categoryName = reader["Category_Name"].ToString();
                 string unitMeasurement = reader["Unit_Measurement"].ToString();

                 data_Grid_Available.Rows.Add(i, productName, categoryName, price, quantity, unitMeasurement);
                 */

            /*
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
           {
               DataGridView dataGridView = (DataGridView)sender;
               DataGridViewCell cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

               // Check if the clicked cell is in the Quantity column
               if (cell.OwningColumn.Name == "Quantity")
               {
                   int quantity = Convert.ToInt32(cell.Value);

                   if (e.ColumnIndex == dataGridView.Columns[7].Index)
                   {
                       // Increment the quantity by 1 (if not exceeding the range)
                       if (quantity < int.MaxValue)
                           cell.Value = quantity + 1;
                   }
                   else if (e.ColumnIndex == dataGridView.Columns[9].Index)
                   {
                       // Decrement the quantity by 1 (if not exceeding the range)
                       if (quantity > 1)
                           cell.Value = quantity - 1;
                   }
               }
           }
           */
        }

      
    }
}
