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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            button_highligted();
        }

        private Color defaultColor = Color.FromArgb(43, 43, 43);
        private Color settingsColor = Color.FromArgb(242, 197, 70);

        public void button_highligted()
        {
            btn_Settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Inventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Inventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_Warehouse.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Warehouse.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

            btn_User.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_User.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }
    }
}
