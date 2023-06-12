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
    public partial class Profile_Popup_Form : Form
    {
        public Profile_Popup_Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - this.Width, Screen.PrimaryScreen.WorkingArea.Top);

        }



        private void btn_Sign_Out_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Dispose();
                Application.OpenForms["Main_Form"].Close();
                Login_Form frm = new Login_Form();
                frm.Show();
            }
            else
            {
                this.Show();

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
