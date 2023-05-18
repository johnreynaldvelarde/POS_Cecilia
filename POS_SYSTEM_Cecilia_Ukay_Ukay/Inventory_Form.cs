using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Inventory_Form : Form
    {
        public Inventory_Form()
        {
            InitializeComponent();
            view_Item_List();
        }

        private Color defaultColor = Color.FromArgb(14, 159, 104);
        private Color settingsColor = Color.FromArgb(242, 197, 70);
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)

                activeForm.Close();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            childForm.Show();
        }

        public void button_highligted()
        {
            // btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);
            btn_Product_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Product_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            //  btn_Category_List.BackColor = Color.FromArgb(242, 197, 70);
            btn_Category_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Category_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);
        }

        private void resetButtonColors()
        {
            btn_Product_List.BackColor = defaultColor;
            btn_Category_List.BackColor = defaultColor;
        }

        public void view_Item_List()
        {
            openChildForm(new Product_List_Form());
            btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // button for category
        private void btn_Category_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Category_List_Form());
            resetButtonColors();
            btn_Category_List.BackColor = Color.FromArgb(242, 197, 70);

        }

        // button for product list
        private void btn_Product_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Product_List_Form());
            resetButtonColors();
            btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Product_List_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from viewProduct", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void gridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
