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

        public Add_New_Category_Form()
        {
            InitializeComponent();

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
                    string sql = "INSERT INTO Categories (Category_Name, Deleted) VALUES (@Category_Name, @Deleted)";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@Category_Name", txt_Category.Text);
                    command.Parameters.AddWithValue("@Deleted", 0);
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Successfully added!!!");
                    Clear();
                }

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
