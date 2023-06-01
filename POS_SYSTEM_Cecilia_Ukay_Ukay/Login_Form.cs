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
    public partial class Login_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Login_Form()
        {
            InitializeComponent();

        }

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

            // Sa ulit muna ilagay ang code para mabilis buksan
            //  "Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True"  --dapiton string connections
            /*
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
    }
}
