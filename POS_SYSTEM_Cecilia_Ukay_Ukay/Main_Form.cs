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
            load_product();
            load_category();
        }

        private Color defaultColor = Color.FromArgb(14, 159, 104);
        private Color settingsColor = Color.FromArgb(242, 197, 70);

        // method for over the mouse color
        public void button_highligted()
        {
            btn_Settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Inventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Inventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Supplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Supplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_User.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_User.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Sales_Report.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Sales_Report.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }

        // load the category list
        public void load_category()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string query = "SELECT Category_Name FROM Category_List WHERE Deleted = 0";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.Category_Name = reader.GetString(0);

                    Popup_Category category_control = new Popup_Category();
                    category_control.LoadCategory(category);
                    category_panel_flow.Controls.Add(category_control);
                }
            }
        }

        // load the product list from the database and use of user control form
        public void load_product()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string query = "SELECT Product_Name, Description, Price, Availability, Product_Image FROM Product_List WHERE Deleted = 0";
                SqlCommand command = new SqlCommand(query, connect);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.Name = reader.GetString(0);
                    product.Description = reader.GetString(1);
                    product.Price = reader.GetDecimal(2);
                    product.Availability = reader.GetInt32(3);

                    // Load the product image from the database or default image file
                    byte[] imageBytes = reader.IsDBNull(4) ? null : (byte[])reader[4];
                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            product.product_image = Image.FromStream(ms);
                        }
                    }

                    // Create a new Product_Control user control for the product
                    Product_Show productControl = new Product_Show();
                    productControl.LoadProduct(product);

                    // Add the product control to the FlowLayoutPanel
                    flow_list_product.Controls.Add(productControl);

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

        // button for sales report
        private void btn_Sales_Report_Click(object sender, EventArgs e)
        {
            btn_Sales_Report.BackColor = settingsColor;

            Sales_Report_Form frm = new Sales_Report_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Sales_Report.BackColor = defaultColor;
        }

        private void picture_account_Click(object sender, EventArgs e)
        {
            Profile_Popup_Form frm = new Profile_Popup_Form();
            frm.ShowDialog();
            frm.Dispose();
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Now.ToLongDateString();
            label_Time.Text = DateTime.Now.ToLongTimeString();
        }

        // moving time
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


    }
}
