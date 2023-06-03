using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Order_Transaction_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Order_Transaction_List_Form()
        {
            InitializeComponent();
        }

        public void order_transaction_list()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Order_Transaction.Rows.Clear();

            }
        }
    }
}
