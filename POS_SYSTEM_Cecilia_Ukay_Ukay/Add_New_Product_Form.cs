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

        private Main_Form main_form;

        public string productID;

        public Add_New_Product_Form()
        {
            InitializeComponent();
            //  main_form = main;
            show_category();
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
            if (String.IsNullOrEmpty(txt_Product_Code.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else
            {
                int categoryId = 0;

                /*
                if (combo_Category.SelectedValue != null)
                {
                    categoryId = (int)combo_Category.SelectedValue;
                }
                */

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
                    string sql = "INSERT INTO Product (Product_Code, Product_Name, Price, Quantity, Date_Added, Category_ID, Size, Archive  ) " +
                                 "VALUES (@Product_Code, @Product_Name, @Price, @Quantity, @Date_Added, @Category_ID, @Size, @Archive )";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Product_Code", txt_Product_Code.Text);
                    command.Parameters.AddWithValue("@Product_Name", txt_Product_Name.Text);
                    command.Parameters.AddWithValue("@Price", Convert.ToDouble(txt_Price.Text));
                    command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_Quantity.Text));
                    command.Parameters.AddWithValue("@Date_Added", DateTime.Parse(txt_Date_Added.Text));
                    command.Parameters.AddWithValue("@Category_ID", categoryId);
                    command.Parameters.AddWithValue("@Size", cmd_Measurement.SelectedItem);
                    command.Parameters.AddWithValue("@Archive", 0);
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Successfully added");
                    Clear();
                }

            }
        }


        // button for clear
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void Add_New_Product_Form_Load(object sender, EventArgs e)
        {
            txt_Date_Added.Text = DateTime.Now.ToLongDateString();
        }
    }
}
