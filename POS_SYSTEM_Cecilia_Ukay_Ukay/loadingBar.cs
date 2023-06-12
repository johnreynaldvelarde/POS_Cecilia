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
    public partial class loadingBar : Form
    {
        public loadingBar()
        {
            InitializeComponent();
        }

        private void time01_Tick(object sender, EventArgs e)
        {
            progressPanel.Width += 6;

            if (progressPanel.Width >= 700)
            {

                time01.Stop();
                Login_Form logs = new Login_Form();
                logs.Show();
                this.Hide();

            }

            if (progressPanel.Width >= label_logo.Left && label_logo.Text.Length > 0)
            {
                label_logo.ForeColor = Color.White;
                label_logo.BackColor = Color.FromArgb(14, 159, 104);
            }

        }

        private void loadingBar_Load(object sender, EventArgs e)
        {
            time01.Start();
        }
    }
}
