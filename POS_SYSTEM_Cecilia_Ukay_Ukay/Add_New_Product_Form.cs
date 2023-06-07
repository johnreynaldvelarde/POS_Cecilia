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
    public partial class Add_New_Product_Form : Form
    {
        DB_Connection database = new DB_Connection();

        Product_List_Form frm;

        public string productID;
        private int stockItemID;

        public Add_New_Product_Form(Product_List_Form product)
        {
            InitializeComponent();
            frm = product;
            show_category();
            show_item();
            this.Hide();
        }

        // method for clear the text in textbox
        public void Clear()
        {
            txt_Product_Code.Clear();
            txt_Product_Name.Clear();
            txt_Price.Clear();
            txt_Quantity.Clear();
            cmd_Category.SelectedIndex = -1;
            cmd_Measurement.SelectedIndex = -1;
            txt_Product_Name.Focus();

        }

        // populate the combo box category coming from database
        public void show_category()
        {
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
        }

        // button for exit
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // button for save the details in database
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Product_Code.Text) || String.IsNullOrEmpty(txt_Product_Name.Text) || String.IsNullOrEmpty(txt_Price.Text) || String.IsNullOrEmpty(txt_Quantity.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else if (cmd_Category.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category");
            }
            else if (cmd_Stock.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the available stock");
            }
            else
            {
                bool codeExists = product_code_exists(txt_Product_Code.Text);

                if (codeExists)
                {
                    MessageBox.Show("Product code already exists. Please enter a different product code.");
                }

                else
                {
                    int categoryId = 0;

                    string selectedCategory = cmd_Category.SelectedItem.ToString();
                    int putQuantity = Convert.ToInt32(txt_Quantity.Text);

                    // looking for  Category_ID value in the Categories table
                    using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                    {
                        connect.Open();
                        string sql = "SELECT Category_ID FROM Categories WHERE Category_Name = @Category_Name AND Archive = 0";
                        SqlCommand command = new SqlCommand(sql, connect);
                        command.Parameters.AddWithValue("@Category_Name", selectedCategory);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            categoryId = Convert.ToInt32(result);
                        }
                        connect.Close();
                    }

                    using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                    {

                        connect.Open();
                        string sql = "INSERT INTO Product (Product_Code, Product_Name, Price, Quantity, Size, Date_Added, Archive, Category_ID, StockItem_ID) " +
                                     "VALUES (@Product_Code, @Product_Name, @Price, @Quantity, @Size,  @Date_Added, @Archive, @Category_ID, @StockItem_ID)";
                        SqlCommand command = new SqlCommand(sql, connect);
                        command.Parameters.AddWithValue("@Product_Code", txt_Product_Code.Text);
                        command.Parameters.AddWithValue("@Product_Name", txt_Product_Name.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDouble(txt_Price.Text));
                        command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_Quantity.Text));
                        command.Parameters.AddWithValue("@Size", cmd_Measurement.SelectedItem);
                        command.Parameters.AddWithValue("@Date_Added", DateTime.Now);
                        command.Parameters.AddWithValue("@Archive", 0);
                        command.Parameters.AddWithValue("@Category_ID", categoryId);
                        command.Parameters.AddWithValue("@StockItem_ID", stockItemID);

                        command.ExecuteNonQuery();

                        string update_stock = "UPDATE Stock_Item SET Stock_Quantity = Stock_Quantity - @PutQuantity WHERE StockItem_ID = @StockItemID";
                        SqlCommand update_command = new SqlCommand(update_stock, connect);
                        update_command.Parameters.AddWithValue("@StockItemID", stockItemID);
                        update_command.Parameters.AddWithValue("@PutQuantity", putQuantity);
                        update_command.ExecuteNonQuery();


                        connect.Close();

                        MessageBox.Show("Successfully added");
                        if (frm != null)
                        {
                            frm.view_product_list();
                        }
                        Clear();
                    }
                }
            }
        }

        private bool product_code_exists(string productCode)
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT COUNT(*) FROM Product WHERE LOWER(Product_Code) = LOWER(@Product_Code)";
                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@Product_Code", productCode.ToLower());
                int count = (int)command.ExecuteScalar();
                connect.Close();

                return count > 0;
            }
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
                    txt_Total_Stock.Text = stockQuantity.ToString();
                }
                else
                {
                    stockItemID = 0;
                    txt_Total_Stock.Text = string.Empty;
                }

                reader.Close();
                connect.Close();
            }
        }


        // button for clear
        /*
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        */
        private void Add_New_Product_Form_Load(object sender, EventArgs e)
        {
            txt_Date_Added.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                // Check if the key pressed is a backspace or delete key
                if (e.KeyChar != '\b' && e.KeyChar != 127)
                {
                    // Ignore the input by setting the handled flag
                    e.Handled = true;
                }
            }
            else
            {
                // Convert the entered text to an integer and check if it's between 1-99
                int value = Int32.Parse(txt_Quantity.Text + e.KeyChar);
                if (value < 1 || value > 1000)
                {
                    // Ignore the input by setting the handled flag
                    e.Handled = true;
                }
            }
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
            /*
             if (combo_Category.SelectedValue != null)
             {
                 categoryId = (int)combo_Category.SelectedValue;
             }
             */
        }

      
    }
}
