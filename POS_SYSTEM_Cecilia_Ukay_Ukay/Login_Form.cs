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
        private string role = "Manager";

        public void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // login button to main form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main_Form frm = new Main_Form();
            frm.Show();
            /*
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {

            }
            else 
            {

                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();

                    string sql = "SELECT Staff_ID, Staff_Image, Staff_Name, Role FROM Staff_Account WHERE Staff_Name = @username AND Password = @password ";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        command.Parameters.AddWithValue("@username", txtUsername.Text.ToString()); // Replace username with the actual value from the login form
                        command.Parameters.AddWithValue("@password", txtPassword.Text.ToString()); // Replace password with the actual value from the login form

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                Account_Class account = new Account_Class();

                                account.Staff_ID = reader.GetInt32("Staff_ID");
                                // Assuming staff_image is stored as a byte array in the database
                                byte[] imageData = (byte[])reader["Staff_Image"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    account.Staff_Image = Image.FromStream(ms);
                                }
                                account.Staff_Name = reader.GetString(2);
                                account.Staff_Role = reader.GetString(3);

                                if (account.Staff_Role == "Manager")
                                {
                                    
                                    Main_Form manager = new Main_Form();
                                    manager.user_profile.Image = account.Staff_Image;
                                    manager.Show();

                                }
                                else if (account.Staff_Role == "Cashier")
                                {
                                    Main_Form cashier = new Main_Form();
                                    
                                }
                                else
                                {
                                    // Handle other roles or show an error message for unrecognized roles
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Staff Name and Password");
                            }
                        }
                    }
                }
            }

             /*
            Main_Form frm = new Main_Form();
            frm.Show();
            this.Hide(); //this hides the login Form after before the the main form opens

            // Sa ulit muna ilagay ang code para mabilis buksan
            //  "Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True"  --dapiton string connections
         
            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from tbl_admin";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                 if (userBox.Text.Equals(dr["userName"].ToString()) && passBox.Text.Equals(dr["password01"].ToString()))
                {

                    MessageBox.Show("Login Success");






                }
                else { 
                
                MessageBox.Show("Login Failed");
                }

                

            }
            else {


                MessageBox.Show("No data found, create account pls");
            
            }
            */
        }


        private void openForm_Click(object sender, EventArgs e) //----------This is a sample bttn only to open the other form
        {
            Inventory_Form showForm = new Inventory_Form();
            showForm.Show();
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

        }
    }
}
