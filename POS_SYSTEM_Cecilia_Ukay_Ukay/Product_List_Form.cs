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
    public partial class Product_List_Form : Form
    {
        public Product_List_Form()
        {
            InitializeComponent();
            button_highligted();
        }

        private Color defaultColor = Color.FromArgb(14, 159, 104);
        private Color settingsColor = Color.FromArgb(242, 197, 70);

        public void button_highligted()
        {
            btn_Add_Product.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Add_Product.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            btn_Add_Product.BackColor = settingsColor;

            Add_New_Product_Form frm = new Add_New_Product_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Add_Product.BackColor = defaultColor;
        }
    }
}
