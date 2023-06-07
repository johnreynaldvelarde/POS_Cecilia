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
    public partial class Management_Transaction_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Management_Transaction_List_Form()
        {
            InitializeComponent();
            view_management_transction();
        }

        public void view_management_transction()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT p.Purchase_ID, s.Staff_Name, su.Supplier_Name, p.Purchase_Date, p.Total_Amount " +
                             "FROM Purchase_Transaction p " +
                             "JOIN Staff_Account s ON p.Staff_ID = s.Staff_ID " +
                             "JOIN Suppliers su ON p.Supplier_ID = su.Supplier_ID;";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Management.Rows.Clear();

                while (reader.Read())
                {


                    i += 1;
                    data_Grid_Management.Rows.Add(i, reader["Purchase_ID"].ToString(), reader["Staff_Name"].ToString(), reader["Supplier_Name"].ToString(),
                                                     reader["Purchase_Date"].ToString(), reader["Total_Amount"].ToString());


                }
                reader.Close();
                connect.Close();
            }
        }

        private void data_Grid_Management_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_transaction = data_Grid_Management.Columns[e.ColumnIndex].Name;
            if (column_transaction == "View")
            {
                int management_id = Convert.ToInt32(data_Grid_Management.Rows[e.RowIndex].Cells[1].Value);
                Show_Purchase_Item_Form frm = new Show_Purchase_Item_Form(management_id);
                frm.ShowDialog();
            }
        }
    }
}
