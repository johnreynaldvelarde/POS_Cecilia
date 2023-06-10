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


    public partial class Delete_Staff_Account_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Delete_Staff_Account_Form()
        {
            InitializeComponent();
            show_delete_staff();
        }

        public void show_delete_staff()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {

                int i = 0;
                connect.Open();
                string sql = "SELECT Staff_ID, Staff_Name, Date_Added, Archive FROM Staff_Account WHERE Archive = 1 ";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Delete_Staff.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "1")
                    {
                        i += 1;
                        data_Delete_Staff.Rows.Add(i, reader["Staff_ID"].ToString(), reader["Staff_Name"].ToString(), reader["Date_Added"].ToString());
                    }

                }
                reader.Close();
                connect.Close();
            }
        }
    }
}
