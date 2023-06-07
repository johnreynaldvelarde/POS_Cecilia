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
    public partial class History_Log_Form : Form
    {
        public History_Log_Form()
        {
            InitializeComponent();
            view_management();
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
            btn_Retailer.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Retailer.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Transaction.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Transaction.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }

        public void view_management()
        {
            openChildForm(new Management_Transaction_List_Form());
            btn_Retailer.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void resetButtonColors()
        {
            btn_Retailer.BackColor = defaultColor;
            btn_Transaction.BackColor = defaultColor;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Retailer_Click(object sender, EventArgs e)
        {
            openChildForm(new Management_Transaction_List_Form());
            resetButtonColors();
            btn_Retailer.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            openChildForm(new Order_Transaction_List_Form());
            resetButtonColors();
            btn_Transaction.BackColor = Color.FromArgb(242, 197, 70);
        }
    }
}
