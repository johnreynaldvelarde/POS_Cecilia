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
using System.Diagnostics;

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

        private string staff_Id, staff_Name, staff_Password, c_Number, role;
        private Image u_profile;

        // button for adding new staff_account
        private void btn_Add_New_Staff_Click(object sender, EventArgs e)
        {
            User_Create_Account_Form frm = new User_Create_Account_Form(this);
            frm.btn_Update.Enabled = false;
            frm.ShowDialog();
        }

        // method to show data from database table Staff_Account to data_Grid_Staff
        public void view_user_account()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT * FROM Staff_Account WHERE Archive = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Staff.Rows.Clear();
                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "0")
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
            string column_staff = data_Grid_Staff.Columns[e.ColumnIndex].Name;
            if (column_staff == "Edit")
            {
                User_Create_Account_Form frm = new User_Create_Account_Form(this);
                frm.btn_Save.Enabled = false;
                frm.label_title_staff.Text = "Update the account";
                frm.staffID = staff_Id;
                frm.txtUsername.Text = staff_Name;
                frm.txtPassword.Text = staff_Password;
                frm.txtContact.Text = c_Number;
                frm.User_Profile.Image = u_profile;
                frm.cmdRole.SelectedItem = role;
            }
            else if (column_staff == "Delete")
            {
                if (e.ColumnIndex == data_Grid_Staff.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Do you want to delete this product?", "Delete the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                        {
                            connect.Open();
                            string sql = "UPDATE Staff_Account SET Archive = 1 WHERE Staff_ID = @Staff_ID";
                            SqlCommand command = new SqlCommand(sql, connect);
                            command.Parameters.AddWithValue("@Staff_ID", Convert.ToInt32(staff_Id));
                            command.ExecuteNonQuery();
                            connect.Close();

                        }

                        data_Grid_Staff.Rows.RemoveAt(e.RowIndex);
                        view_user_account() ;
                    }
                }
            }
        }

        private void data_Grid_Staff_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Grid_Staff.CurrentRow != null)
            {
                int i = data_Grid_Staff.CurrentRow.Index;
                staff_Id = data_Grid_Staff[1, i].Value.ToString();
                u_profile = (Image)data_Grid_Staff[2, i].Value;
                staff_Name = data_Grid_Staff[3, i].Value.ToString();
                //i = data_Grid_Staff[3, i].Value.ToString();
                c_Number = data_Grid_Staff[5, i].Value.ToString();
                role = data_Grid_Staff[6, i].Value.ToString();

            }
        }
    }
}
