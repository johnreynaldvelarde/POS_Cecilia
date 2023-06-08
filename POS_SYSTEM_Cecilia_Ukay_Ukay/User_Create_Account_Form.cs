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
            else if (txtPassword.Text != txtRetype.Text)
            {
                MessageBox.Show("Password did not match");
            }
            else if (User_Profile != null && User_Profile.Image == null)
            {
                MessageBox.Show("No Staff Image Try Again");
            }
            else
            {
                MemoryStream mstream = new MemoryStream();
                User_Profile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] select_image = mstream.ToArray();

                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string sql = "INSERT INTO Staff_Account (Staff_Name, Staff_Image, Password, Contact_Number, Role, Date_Added, Archive) " +
                                 "VALUES (@Staff_Name, @Staff_Image, @Password, @Contact_Number, @Role, @Date_Added, @Archive)";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Staff_Name", txtUsername.Text);
                    command.Parameters.AddWithValue("@Staff_Image", select_image);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    command.Parameters.AddWithValue("@Contact_Number", txtContact.Text);
                    command.Parameters.AddWithValue("@Role", cmdRole.SelectedItem);
                    command.Parameters.AddWithValue("@Date_Added", DateTime.Now);
                    command.Parameters.AddWithValue("@Archive", 0);
                    command.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("Successfully saved");
                    Clear();
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

        // password hide 
        private void passhide1_CheckedChanged(object sender, EventArgs e)
        {
            if (passhide1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        // retype password hide
        private void passhide2_CheckedChanged(object sender, EventArgs e)
        {
            if (passhide2.Checked)
            {
                txtRetype.UseSystemPasswordChar = true;
            }
            else
            {
                txtRetype.UseSystemPasswordChar = false;
            }
        }
    }
}
