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
    public partial class Add_New_Category_Form : Form
    {
        DB_Connection database = new DB_Connection();
        Category_List_Form frm;

        public string categoryID;

        public Add_New_Category_Form(Category_List_Form category)
        {
            InitializeComponent();
            frm = category;

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txt_Category.Clear();
            txt_Category.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Category.Text))
            {
                MessageBox.Show("Fill in the Blank");
            }
            else
            {

                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string sql = "INSERT INTO Categories (Category_Name, Date_Added, Archive) VALUES (@Category_Name, @Date_Added, @Archive)";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Category_Name", txt_Category.Text);
                    command.Parameters.AddWithValue("@Date_Added", DateTime.Now);
                    command.Parameters.AddWithValue("@Archive", 0);
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Successfully added!!!");
                    frm.view_category();
                    Clear();
                }

            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Category.Text))
            {
                MessageBox.Show("Fill in the Blank");
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    connect.Open();
                    string sql = "UPDATE Categories SET Category_Name = @Category_Name, Date_Added = @Date_Added WHERE Category_ID = @Category_ID ";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Category_Name", txt_Category.Text);
                    command.Parameters.AddWithValue("@Date_Added", DateTime.Now);
                    command.Parameters.AddWithValue("@Category_ID", Convert.ToInt32(categoryID));

                    int rowsAffected = command.ExecuteNonQuery();
                    connect.Close();
                }

                this.Dispose();
                MessageBox.Show("Edit successfully");
                frm.view_category();
            }
        }

        private void Add_New_Category_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

      
    }
}
