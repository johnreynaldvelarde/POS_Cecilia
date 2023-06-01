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
    public partial class Stock_Item_List_Form : Form
    {
        public Stock_Item_List_Form()
        {
            InitializeComponent();
        }

        private void btn_Create_Item_Click(object sender, EventArgs e)
        {
            Add_New_Item_Form frm = new Add_New_Item_Form();
            frm.btn_Update.Enabled = false;
            frm.ShowDialog();
        }
    }
}
