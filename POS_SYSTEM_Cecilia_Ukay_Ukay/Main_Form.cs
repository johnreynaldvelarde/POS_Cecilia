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

        // method for over the mouse color
        public void button_highligted()
        {
            btn_Settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Inventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Inventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Trash.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Trash.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_User.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_User.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Sales_Report.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Sales_Report.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

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



        // load the category list
        public void load_category()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string query = "SELECT Category_Name FROM Categories WHERE Deleted = 0";
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

        // view the product list from database combine of table Product and Categories
        public void view_product()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT p.Product_ID, p.Product_Name, p.Price, p.Quantity, c.Category_Name, p.Unit_Measurement  " +
                             "FROM Product p JOIN Categories c ON p.Category_ID = c.Category_ID WHERE p.Quantity > 0 AND p.Deleted = 0;";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Available.Rows.Clear();

                while (reader.Read())
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
                    

                    i += 1;
                    data_Grid_Available.Rows.Add(i, reader["Product_ID"].ToString(), reader["Product_Name"].ToString(), reader["Category_Name"].ToString(), reader["Price"].ToString(),
                                                    reader["Unit_Measurement"].ToString(), reader["Quantity"].ToString());


                }
                reader.Close();
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
            btn_Trash.BackColor = settingsColor;

            Trash_Bin_Form frm = new Trash_Bin_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Trash.BackColor = defaultColor;
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

        // loading of date and time
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

        private void data_Grid_Available_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
