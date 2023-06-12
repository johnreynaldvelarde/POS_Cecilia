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
using System.Text.RegularExpressions;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class User_Create_Account_Form : Form
    {
        DB_Connection database = new DB_Connection();

        User_List_Form frm;

        public User_Create_Account_Form(User_List_Form user)
        {
            InitializeComponent();
            frm = user;
        }

        public string staffID;


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

        /*
         public void regex(string name, string pass) {   //functions for regex userName and pass

            try {
            string namePattern = @"\W";  //any non character
            string passPattern = @"\s"; //any space or newline

            Regex regName = new Regex(namePattern);
            Match matchName = regName.Match(name);

            Regex regPass = new Regex(passPattern);
            Match matchPass = regPass.Match(pass);

            if (!matchName.Success && !matchPass.Success && pass.Length >= 6) // if matchName and matchPass not equal to true nean success
            {
                MessageBox.Show("Success");


            }
            else {

                MessageBox.Show("Failed");
            
            }


            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }

        }
        */

        public bool IsPasswordValid(string password)
        {
            string pattern = @"^[a-zA-Z0-9]{8,}$";
            return password.Length >= 8 && Regex.IsMatch(password, pattern);
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
            else if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("Invalid password format. Password should be 8 or higher characters consisting of letters or numbers");
            }
            else if (User_Profile != null && User_Profile.Image == null)
            {
                MessageBox.Show("No Staff Image Try Again");
            }
            else if (cmdRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role");
            }
            else
            {
                bool nameExists = staff_name_exists(txtUsername.Text);

                if (nameExists)
                {
                    MessageBox.Show("Staff Name is already exists. Please enter a different staff name.");
                }
                else
                {
                    // regex(txtUsername.Text.ToString(), txtPassword.Text.ToString()); //this is the regex function for user and password --dapits
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
                        frm.view_user_account();
                        this.Dispose();
                        Clear();

                    }
                }
            }
        }

        private bool staff_name_exists(string staffName)
        {
            bool exists = false;

            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT COUNT(*) FROM Staff_Account WHERE LOWER(Staff_Name) = LOWER(@StaffName)";
                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@StaffName", staffName);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    exists = true;
                }

            }
            return exists;
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

            int cursorPosition = txtContact.SelectionStart; 

            if (e.KeyChar == '\b') // for backspace
            {
               
                if (txtContact.Text.Length > 0)
                {
                    txtContact.Text = txtContact.Text.Substring(0, txtContact.Text.Length - 1);
                }
            }
            else if (!char.IsDigit(e.KeyChar) || txtContact.Text.Length >= 11)
            {
                e.Handled = true; 
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

        private void btn_Update_Click(object sender, EventArgs e)
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
            else if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("Invalid password format. Password should be 8 or higher characters consisting of letters or numbers");
            }
            else if (User_Profile != null && User_Profile.Image == null)
            {
                MessageBox.Show("No Staff Image Try Again");
            }
            else if (cmdRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role");
            }
            else
            {
                MemoryStream mstream = new MemoryStream();
                User_Profile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] select_image = mstream.ToArray();

                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string sql = "UPDATE Staff_Account SET Staff_Name = @Staff_Name, Staff_Image = @Staff_Image, Password = @Password, Contact_Number = @Contact_Number, Role = @Role, Date_Added = @Date_Added WHERE Staff_ID = @Staff_ID ";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Staff_Name", txtUsername.Text);
                    command.Parameters.AddWithValue("@Staff_Image", select_image);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    command.Parameters.AddWithValue("@Contact_Number", txtContact.Text);
                    command.Parameters.AddWithValue("@Role", cmdRole.SelectedItem);
                    command.Parameters.AddWithValue("@Date_Added", DateTime.Now);
                    command.Parameters.AddWithValue("@Staff_ID", Convert.ToInt32(staffID));

                    int rowsAffected = command.ExecuteNonQuery();
                    connect.Close();
                }
                MessageBox.Show("Edit successfully");
                frm.view_user_account();
                this.Dispose();
            }
        }
    }
}
