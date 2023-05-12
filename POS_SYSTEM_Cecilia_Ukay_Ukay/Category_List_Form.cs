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
    public partial class Category_List_Form : Form
    {
        public Category_List_Form()
        {
            InitializeComponent();
        }

        private void btn_Add_Category_Click(object sender, EventArgs e)
        {
            Add_New_Category_Form frm = new Add_New_Category_Form();
            frm.btn_Update.Enabled = false;
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
