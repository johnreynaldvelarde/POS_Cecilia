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
    public partial class Remove_Stock_Form : Form
    {
        public Remove_Stock_Form()
        {
            InitializeComponent();
        }

        public string stock_ItemID;

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reduce_Click(object sender, EventArgs e)
        {

        }
    }
}
