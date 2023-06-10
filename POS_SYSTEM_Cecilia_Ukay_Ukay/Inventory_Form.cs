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
        Main_Form frm;
        public Inventory_Form(Main_Form main)
        {
            InitializeComponent();
            view_product_list();
            frm = main;
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
            panel_center.Controls.Add(childForm);
            panel_center.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // color highlight for button
        public void button_highligted()
        {
            btn_Product_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Product_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Category_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Category_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Stock_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Stock_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Item_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Item_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            // btn_Purchase_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            // btn_Purchase_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);
        }

        private void resetButtonColors()
        {
            btn_Product_List.BackColor = defaultColor;
            btn_Category_List.BackColor = defaultColor;
            btn_Stock_List.BackColor = defaultColor;
            btn_Item_List.BackColor = defaultColor;
        }

        // first form view // show the product list in data grid
        public void view_product_list()
        {
            openChildForm(new Product_List_Form());
            btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        // button for product list
        private void btn_Product_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Product_List_Form());
            resetButtonColors();
            btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        // button for category list
        private void btn_Category_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Category_List_Form());
            resetButtonColors();
            btn_Category_List.BackColor = Color.FromArgb(242, 197, 70);
        }



        private void btn_Item_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Item_List_Form());
            resetButtonColors();
            btn_Item_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Stock_List_Click(object sender, EventArgs e)
        {
            openChildForm(new View_Stock_List_Form());
            resetButtonColors();
            btn_Stock_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frm.view_product();
            this.Dispose();
        }

        
    }
}
