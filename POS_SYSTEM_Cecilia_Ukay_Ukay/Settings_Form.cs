using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Settings_Form : Form
    {
        public Settings_Form()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Settings_Form_Load(object sender, EventArgs e)
        {
            setting_date.Text = DateTime.Now.ToLongDateString();
            setting_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setting_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_Change_DateTime_Click(object sender, EventArgs e)
        {
            Process.Start("control", "timedate.cpl");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
       



    }
}
