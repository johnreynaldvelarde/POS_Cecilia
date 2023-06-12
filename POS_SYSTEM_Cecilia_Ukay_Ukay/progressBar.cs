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
    public partial class progressBar : Form
    {
        
        public progressBar()
        {
            InitializeComponent();
        }

        private void progressBar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            time01.Start();
        }

        private void time01_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2; 
            if (panel2.Width >= 700) {

                end();
                




            }
            

            

           
        }

        void end() { //if progress is full call this method

            time01.Stop();
            Login_Form log1 = new Login_Form();
            log1.Show();
            this.Hide();



        }
    }
}
