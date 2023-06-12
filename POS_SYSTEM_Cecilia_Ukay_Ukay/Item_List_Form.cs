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

        private string ItemID, item_code, item_name, price, per_piece;

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
                Add_New_Item_Form frm = new Add_New_Item_Form(this);
                frm.label_item.Text = "Update the item";
                frm.btn_Save.Enabled = false;
                frm.btn_Update.Enabled = true;
                frm.txt_Item_Code.Enabled = false;
                frm.itemID = ItemID.ToString();
                frm.txt_Item_Code.Text = item_code;
                frm.txt_Item_Name.Text = item_name;
                frm.txt_Price.Text = price;
                frm.cmd_Piece.SelectedItem = per_piece;
                frm.ShowDialog();


            }
            else if (column_item == "Delete")
            {
                if (e.ColumnIndex == data_Grid_Item.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int itemID = Convert.ToInt32(data_Grid_Item.Rows[e.RowIndex].Cells["Item_ID"].Value);

                    bool hasExistingStock = CheckExistingItemStock(itemID);

                    if (hasExistingStock)
                    {
                        MessageBox.Show("Cannot delete the item because it has existing stock.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Do you want to delete this product?", "Delete the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                            {
                                connect.Open();
                                string sql = "UPDATE Item SET Archive = 1 WHERE Item_ID = @Item_ID";
                                SqlCommand command = new SqlCommand(sql, connect);
                                command.Parameters.AddWithValue("@Item_ID", Convert.ToInt32(ItemID));
                                command.ExecuteNonQuery();
                                connect.Close();

                            }
                            data_Grid_Item.Rows.RemoveAt(e.RowIndex);
                            show_item_list();
                        }
                    }
                }
            }
        }

        private bool CheckExistingItemStock(int itemID)
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT COUNT(*) FROM Item_Stock WHERE Item_ID = @Item_ID AND ItemStock_Qyt > 0";
                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@Item_ID", itemID);

                int count = Convert.ToInt32(command.ExecuteScalar());
                connect.Close();

                return count > 0;
            }
        }

        private void data_Grid_Item_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Grid_Item.CurrentRow != null)
            {
                int i = data_Grid_Item.CurrentRow.Index;
                ItemID = data_Grid_Item[1, i].Value.ToString();
                item_code = data_Grid_Item[2, i].Value.ToString();
                item_name = data_Grid_Item[3, i].Value.ToString();
                price = data_Grid_Item[4, i].Value.ToString();
                per_piece = data_Grid_Item[5, i].Value.ToString();

            }
        }
    }
}
