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
    public partial class User_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public User_List_Form()
        {
            InitializeComponent();
            view_user_account();
        }

        // button for adding new staff_account
        private void btn_Add_New_Staff_Click(object sender, EventArgs e)
        {
            User_Create_Account_Form frm = new User_Create_Account_Form();
            frm.ShowDialog();
        }

        // method to show data from database table Staff_Account to data_Grid_Staff
        public void view_user_account()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT * FROM Staff_Account WHERE Deleted = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Staff.Rows.Clear();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString() == "0")
                    {
                        i += 1;
                        data_Grid_Staff.Rows.Add(i, reader["Staff_Image"], reader["Staff_Name"].ToString(), reader["Date_Added"].ToString(), reader["Contact_Number"].ToString(), reader["Role"].ToString());
                    }
                }
                reader.Close();
                connect.Close();
            }
        }

        private void data_Grid_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
