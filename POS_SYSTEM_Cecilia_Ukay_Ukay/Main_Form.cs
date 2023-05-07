﻿using System;
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

        private Color defaultColor = Color.FromArgb(14, 159, 104);
        private Color settingsColor = Color.FromArgb(242, 197, 70);

        // method for overmouse color
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

            btn_Sales_Report.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Sales_Report.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }


        // button for user management
        private void btn_User_Click(object sender, EventArgs e)
        {
            btn_User.BackColor = settingsColor;

            User_Form frm = new User_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_User.BackColor = defaultColor;
        }

        // button for inventory
        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            btn_Inventory.BackColor = settingsColor;
            Inventory_Form frm = new Inventory_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Inventory.BackColor = defaultColor;
            // frm.btn_Product_List.BackColor = Color.FromArgb(242, 197, 70);

        }

        // button for settings
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            btn_Settings.BackColor = settingsColor;

            Settings_Form frm = new Settings_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Settings.BackColor = defaultColor;
        }

        // button for sales report
        private void btn_Sales_Report_Click(object sender, EventArgs e)
        {
            btn_Sales_Report.BackColor = settingsColor;

            Sales_Report_Form frm = new Sales_Report_Form();
            frm.ShowDialog();
            frm.Dispose();
            btn_Sales_Report.BackColor = defaultColor;
        }

        private void picture_account_Click(object sender, EventArgs e)
        {
            Profile_Popup_Form frm = new Profile_Popup_Form();
            frm.ShowDialog();
            frm.Dispose();
        }

        // date and time
        private void Main_Form_Load(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Now.ToLongDateString();
            label_Time.Text = DateTime.Now.ToLongTimeString();
        }

        // moving time
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


    }
}
