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
    public partial class User_Create_Account_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public User_Create_Account_Form()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // clear method
        public void Clear()
        {
            txtUsername.Focus();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRetype.Clear();
            txtContact.Clear();
            cmdRole.SelectedIndex = -1;
            User_Profile.Image = null;

        }

        // button for clear
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // button save info to database
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtRetype.Text) ||
                String.IsNullOrEmpty(txtContact.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    
                }
            }
        }
            

        // button for adding user image
        private void btn_Add_Profile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Title = "Select an image file";
                openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    User_Profile.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method for contact number accepting only 11 number and not non number
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {

            int cursorPosition = txtContact.SelectionStart; // store the current cursor position

            if (e.KeyChar == '\b') // for backspace
            {
                // Allow the use of backspace key to delete digits
                if (txtContact.Text.Length > 0)
                {
                    txtContact.Text = txtContact.Text.Substring(0, txtContact.Text.Length - 1);
                }
            }
            else if (!char.IsDigit(e.KeyChar) || txtContact.Text.Length >= 11)
            {
                e.Handled = true; // prevent input of non-digits and limit the input to 11 digits
            }

            txtContact.SelectionStart = cursorPosition;

        }

       
    }
}
