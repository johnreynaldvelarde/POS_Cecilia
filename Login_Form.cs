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
        Main_Form frm = new Main_Form(); //temporary instance
        public Login_Form()
        {
            InitializeComponent();

        }
        DB_Connection dbcn = new DB_Connection();
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

            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from tbl_admin";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){

                if (txtUsername.Text.Equals(dr["userName"].ToString()) && txtPassword.Text.Equals(dr["password01"].ToString()))
                {

                    MessageBox.Show("Login Success");
                    
                    con.Dispose();
                    

                }
                else { //if the password is wrong

                    MessageBox.Show("Input user and password wrong...");
                
                }


            }
            else {


                MessageBox.Show("No data found, create account pls");
            
            }
            
        }

        private void openForm_Click(object sender, EventArgs e) //----------This is a sample bttn only to open the other form
        {
            
            frm.Show();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        // button for application exit
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


    }
}
