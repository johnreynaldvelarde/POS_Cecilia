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

        public string productID, c_id;

        public Add_New_Product_Form(Product_List_Form product)
        {
            InitializeComponent();
            frm = product;
            show_category();
        }

        // method for clear the text in textbox
        public void Clear()
        {
            txt_Product_Code.Clear();
            txt_Product_Name.Clear();
            txt_Price.Clear();
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
            if (String.IsNullOrEmpty(txt_Product_Code.Text) || String.IsNullOrEmpty(txt_Product_Name.Text) || String.IsNullOrEmpty(txt_Price.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else if (cmd_Category.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category");
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
                        string sql = "INSERT INTO Product (Product_Code, Product_Name, Price, Size, Date_Added, Archive, Category_ID) " +
                                     "VALUES (@Product_Code, @Product_Name, @Price,  @Size,  @Date_Added, @Archive, @Category_ID); SELECT SCOPE_IDENTITY(); ";
                        SqlCommand command = new SqlCommand(sql, connect);
                        command.Parameters.AddWithValue("@Product_Code", txt_Product_Code.Text);
                        command.Parameters.AddWithValue("@Product_Name", txt_Product_Name.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDouble(txt_Price.Text));
                        command.Parameters.AddWithValue("@Size", cmd_Measurement.SelectedItem);
                        command.Parameters.AddWithValue("@Date_Added", DateTime.Now);
                        command.Parameters.AddWithValue("@Archive", 0);
                        command.Parameters.AddWithValue("@Category_ID", categoryId);

                        int productID = Convert.ToInt32(command.ExecuteScalar());

                        string insert_stock = "INSERT INTO Product_Stock (Product_ID, ProductStock_Qyt) VALUES (@Product_ID, @ProductStock_Qyt)";
                        SqlCommand command_stock = new SqlCommand(insert_stock, connect);
                        command_stock.Parameters.AddWithValue("@Product_ID", productID);
                        command_stock.Parameters.AddWithValue("@ProductStock_Qyt", 0);
                        command_stock.ExecuteNonQuery();

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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Product_Code.Text) || String.IsNullOrEmpty(txt_Product_Name.Text) || String.IsNullOrEmpty(txt_Price.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else
            {
                
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string sql = "UPDATE Product SET Product_Name = @Product_Name, Price  = @Price, Size = @Size, Category_ID, @Category_ID, Date_Added = @Date_Added WHERE Product_ID = @Product_ID ";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Product_Name", txt_Product_Name.Text);
                    command.Parameters.AddWithValue("@Price", txt_Price.Text);
                    command.Parameters.AddWithValue("@Size", cmd_Measurement.SelectedItem);
                   // command.Parameters.AddWithValue("@Category_ID", );
                    command.Parameters.AddWithValue("@Date_Added", DateTime.Now);
                    command.Parameters.AddWithValue("@Product_ID", Convert.ToInt32(productID));

                    int rowsAffected = command.ExecuteNonQuery();
                    connect.Close();
                }
                
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void Add_New_Product_Form_Load(object sender, EventArgs e)
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


    }
}
