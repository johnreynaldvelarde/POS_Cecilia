﻿using System;
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
        // SqlConnection connect = new SqlConnection();
        DB_Connection database = new DB_Connection();


        public Add_New_Product_Form()
        {
            InitializeComponent();
            show_category();
            //  connect = new SqlConnection(database.MyConnection());


        }

        // method for clear the text in textbox
        public void Clear()
        {
            txt_Product_Code.Clear();
            txt_Product_Name.Clear();
            txt_Description.Clear();
            txt_Price.Clear();
            txt_Availability.Clear();
            cmd_Category.SelectedIndex = -1;
            cmd_Measurement.SelectedIndex = -1;
            picture_Product.Image = null;
            txt_Product_Name.Focus();

        }

        // populate the combo box category coming from database
        public void show_category()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT Category_Name FROM Category_List WHERE Deleted = 0";
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
                if (cmd_Category.SelectedValue != null)
                {
                    categoryId = (int)cmd_Category.SelectedValue;
                }

                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {

                    MemoryStream mstream = new MemoryStream();
                    picture_Product.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] selectImage = mstream.GetBuffer();

                    connect.Open();
                    string sql = "INSERT INTO Product_List (Product_Image, Product_Code, Product_Name, Description, Price, Availability, Date_Added, Expiration_Date, Unit_Measurement, Deleted  ) " +
                                 "VALUES (@Product_Image, @Product_Code, @Product_Name, @Description, @Price, @Availability, @Date_Added, @Expiration_Date, @Unit_Measurement, @Deleted )";
                    SqlCommand command = new SqlCommand(sql, connect);

                    command.Parameters.AddWithValue("@Product_Image", selectImage);
                    command.Parameters.AddWithValue("@Product_Code", txt_Product_Code.Text);
                    command.Parameters.AddWithValue("@Product_Name", txt_Product_Name.Text);
                    command.Parameters.AddWithValue("@Description", txt_Description.Text);
                    command.Parameters.AddWithValue("@Price", Convert.ToDouble(txt_Price.Text));
                    command.Parameters.AddWithValue("@Availability", Convert.ToInt32(txt_Availability.Text));
                    command.Parameters.AddWithValue("@Date_Added", DateTime.Parse(txt_Date_Added.Text));
                    command.Parameters.AddWithValue("@Expiration_Date", DateTime.Parse(date_expiration.Text));
                    command.Parameters.AddWithValue("@Category_ID", categoryId);
                    command.Parameters.AddWithValue("@Unit_Measurement", cmd_Measurement.SelectedItem);
                    command.Parameters.AddWithValue("@Deleted", 0);
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

        // button for getting product image
        private void btn_Product_Image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Title = "Select an image file";
                openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    picture_Product.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Add_New_Product_Form_Load(object sender, EventArgs e)
        {
            txt_Date_Added.Text = DateTime.Now.ToLongDateString();
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

        
        private void txt_Availability_KeyPress(object sender, KeyPressEventArgs e)
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
                int value = Int32.Parse(txt_Availability.Text + e.KeyChar);
                if (value < 1 || value > 1000)
                {
                    // Ignore the input by setting the handled flag
                    e.Handled = true;
                }
            }
        }
    }
}