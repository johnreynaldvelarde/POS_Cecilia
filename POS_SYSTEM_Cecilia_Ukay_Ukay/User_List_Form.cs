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
    public partial class User_List_Form : Form
    {
        public User_List_Form()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            User_Create_Account_Form frm = new User_Create_Account_Form();
            frm.ShowDialog();
        }
    }
}
