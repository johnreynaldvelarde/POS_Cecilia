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
    public partial class Inventory_Form : Form
    {
        public Inventory_Form()
        {
            InitializeComponent();
            view_Product_List();
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

        public void view_Product_List()
        {
            openChildForm(new Product_List_Form());
            btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Product_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Product_List_Form());
            // button_highligted();
            resetButtonColors();
            btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Category_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Category_List_Form());
            // button_highligted();
            resetButtonColors();
            btn_Category_List.BackColor = Color.FromArgb(242, 197, 70);
        }
    }
}
