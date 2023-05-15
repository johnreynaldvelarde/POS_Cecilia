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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            

            //  "Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True"  --dapiton string connections
            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from tbl_admin";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Add_New_Item_Form add_form = new Add_New_Item_Form();
                add_form.Show();

                MessageBox.Show("Hello, World that works");

            }
            else {


                MessageBox.Show("No data found, create account pls");
            
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
