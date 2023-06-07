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
    public partial class Item_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Item_List_Form()
        {
            InitializeComponent();
            show_item_list();
        }

        private string ItemID, item_name, price, per_piece;

        public void show_item_list()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {

                int i = 0;
                connect.Open();
                string sql = "SELECT Item_ID, Item_Code, Item_Name, Price, Per_Piece, Date_Added, Archive FROM Item WHERE Archive = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Item.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "0")
                    {
                        i += 1;
                        data_Grid_Item.Rows.Add(i, reader["Item_ID"].ToString(), reader["Item_Code"].ToString(), reader["Item_Name"].ToString(),
                                                   reader["Price"].ToString(), reader["Per_Piece"].ToString(), reader["Date_Added"].ToString());
                    }
                }
                reader.Close();
                connect.Close();
            }
        }

        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            Add_New_Item_Form frm = new Add_New_Item_Form(this);
            frm.btn_Update.Enabled = false;
            frm.itemID = ItemID;
            frm.ShowDialog();
        }

        private void data_Grid_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_item = data_Grid_Item.Columns[e.ColumnIndex].Name;
            if (column_item == "Edit")
            {

            }
            else if (column_item == "Delete")
            {

            }
        }

        private void data_Grid_Item_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Grid_Item.CurrentRow != null)
            {
                int i = data_Grid_Item.CurrentRow.Index;
                ItemID = data_Grid_Item[1, i].Value.ToString();
                item_name = data_Grid_Item[2, i].Value.ToString();
                price = data_Grid_Item[3, i].Value.ToString();
                per_piece = data_Grid_Item[4, i].Value.ToString();
            }
        }
    }
}
