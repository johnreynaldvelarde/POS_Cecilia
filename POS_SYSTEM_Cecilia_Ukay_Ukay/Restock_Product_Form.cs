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
    public partial class Restock_Product_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Restock_Product_Form()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            cmd_Stock.SelectedIndex = -1;
        }

        private void btn_Restock_Click(object sender, EventArgs e)
        {
            if (cmd_Stock.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the avaiable stock");
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {

                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

       
    }
}
