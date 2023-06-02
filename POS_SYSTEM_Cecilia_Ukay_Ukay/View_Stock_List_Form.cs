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
    public partial class View_Stock_List_Form : Form
    {
        public View_Stock_List_Form()
        {
            InitializeComponent();
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            Purchase_Order_Form frm = new Purchase_Order_Form();
            frm.ShowDialog();
        }
    }
}
