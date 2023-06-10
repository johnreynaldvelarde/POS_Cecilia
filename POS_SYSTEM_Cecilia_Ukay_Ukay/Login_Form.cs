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
using System.Collections;
using System.Diagnostics;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Login_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Login_Form()
        {
            InitializeComponent();

        }

        private string name = "Admin";
        private string pass = "12345";
        private string role = "Default";

        public void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // login button to main form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputtedUsername = txtUsername.Text;
            string inputtedPassword = txtPassword.Text;

            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter both Staff Name and Password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (inputtedUsername == name && inputtedPassword == pass)
            {
                Account_Class account = new Account_Class();
                account.Staff_Name = name;
                account.Staff_Role = role;

                this.Hide();
                Main_Form mainForm = new Main_Form();
                mainForm.btn_Sell.Enabled = false;
                mainForm.Show();
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();

                    string sql = "SELECT Staff_ID, Staff_Image, Staff_Name, Role, Password FROM Staff_Account WHERE Staff_Name = @username and Archive = 0";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        command.Parameters.AddWithValue("@username", txtUsername.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedUsername = reader.GetString("Staff_Name");
                                string storedPassword = reader.GetString("Password");

                                if (string.Equals(txtUsername.Text, storedUsername, StringComparison.Ordinal) && string.Equals(txtPassword.Text, storedPassword, StringComparison.Ordinal))
                                {
                                    Account_Class account = new Account_Class();

                                    account.Staff_ID = reader.GetInt32("Staff_ID");

                                    byte[] imageData = (byte[])reader["Staff_Image"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        account.Staff_Image = Image.FromStream(ms);
                                    }
                                    account.Staff_Name = storedUsername;
                                    account.Staff_Role = reader.GetString("Role");

                                    if (account.Staff_Role == "Manager")
                                    {
                                        this.Hide();
                                        Main_Form manager = new Main_Form();
                                        manager.user_profile.Image = account.Staff_Image;
                                        manager.Show();
                                    }
                                    else if (account.Staff_Role == "Cashier")
                                    {
                                        this.Hide();
                                        Main_Form cashier = new Main_Form();
                                        cashier.btn_Inventory.Enabled = false;
                                        cashier.btn_Archive.Enabled = false;
                                        cashier.btn_History.Enabled = false;
                                        cashier.btn_Settings.Enabled = false;
                                        cashier.btn_User.Enabled = false;
                                        cashier.user_profile.Image = account.Staff_Image;
                                        cashier.Show();
                                        // Rest of the code for the cashier role
                                    }
                                    else
                                    {
                                        // Handle other roles or show an error message for unrecognized roles
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Staff Name or Password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Staff Name");
                            }
                        }
                    }

                }
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Now.ToLongDateString();
            label_time.Text = DateTime.Now.ToLongTimeString();
        }

        // button for application exit
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // button for clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_Change_DateTime_Click(object sender, EventArgs e)
        {
            Process.Start("control", "timedate.cpl");
        }

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
    }
}
