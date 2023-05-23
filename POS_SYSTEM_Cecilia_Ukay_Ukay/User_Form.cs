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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
            view_employee_list();
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
            this.Dispose();
        }

        public void view_employee_list()
        {
            openChildForm(new User_List_Form());
            btn_Employee_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            openChildForm(new User_List_Form());
            resetButtonColors();
            btn_Employee_List.BackColor = Color.FromArgb(242, 197, 70);
        }

        private void resetButtonColors()
        {
            btn_Employee_List.BackColor = defaultColor;

        }


    }
}
