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
    public partial class Supplier_List_Form : Form
    {
        public Supplier_List_Form()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Supplier_Click(object sender, EventArgs e)
        {
            Add_New_Supplier_Form frm = new Add_New_Supplier_Form();
            frm.ShowDialog();
        }
    }
}
