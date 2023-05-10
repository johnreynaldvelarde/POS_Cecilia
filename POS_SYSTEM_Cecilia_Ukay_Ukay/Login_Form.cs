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
    public partial class Login_Form : Form
    {
        DB_Connection database = new DB_Connection();
        public Login_Form()
        {
            InitializeComponent();

        }

        public void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            if(txtUsername.Text ==)
            {

            }
            else
            {
                using ()
                {

                }

            }
            
            */
            Main_Form frm = new Main_Form();
            frm.Show();
        }
    }
}
