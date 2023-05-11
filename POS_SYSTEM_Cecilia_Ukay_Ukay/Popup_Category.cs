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
    public partial class Popup_Category : UserControl
    {
        public Popup_Category()
        {
            InitializeComponent();
        }

        public void LoadCategory(Category category)
        {
            category_name.Text = category.Category_Name;
        }

        private void Popup_Category_Click(object sender, EventArgs e)
        {

        }
    }
}
