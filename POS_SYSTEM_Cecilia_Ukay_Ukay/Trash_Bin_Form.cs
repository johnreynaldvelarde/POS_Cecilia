using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Trash_Bin_Form : Form
    {
        Main_Form frm;
        public Trash_Bin_Form(Main_Form main)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            frm.cmd_Category.Items.Clear();
            frm.load_category();
            frm.view_product();
            this.Close();

        }

        public void button_highligted()
        {
            btn_Product_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Product_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Category_List.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Category_List.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Item.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Item.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Staff.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Staff.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Supplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Supplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }

        private void resetButtonColors()
        {
            btn_Product_List.BackColor = defaultColor;
            btn_Category_List.BackColor = defaultColor;
            btn_Item.BackColor = defaultColor;
            btn_Staff.BackColor = defaultColor;
            btn_Supplier.BackColor = defaultColor;

        }

        public void view_product_list()
        {

            openChildForm(new Delete_Product_List_Form());
            btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);

        }

        private void btn_Category_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Delete_Category_List_Form());
            resetButtonColors();
            btn_Category_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Product_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Delete_Product_List_Form());
            resetButtonColors();
            btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            openChildForm(new Delete_Item_List_Form());
            resetButtonColors();
            btn_Item.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            openChildForm(new Delete_Staff_Account_Form());
            resetButtonColors();
            btn_Staff.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Delete_Suppliers_Form());
            resetButtonColors();
            btn_Supplier.BackColor = Color.FromArgb(242, 197, 70);
        }
    }
}
