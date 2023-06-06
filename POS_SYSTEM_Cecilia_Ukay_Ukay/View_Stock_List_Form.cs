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
    public partial class View_Stock_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public View_Stock_List_Form()
        {
            InitializeComponent();
            show_product_stock();
            show_item_stock();
        }

        private string stock_productID, stock_productName;
        private string stock_itemID, stock_itemCode, stock_itemName, stock_quantity;


        public void show_product_stock()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT Product_ID, Product_Code, Product_Name, Quantity, Archive FROM Product WHERE Archive = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Stock_Product.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "0")
                    {
                        i += 1;
                        data_Stock_Product.Rows.Add(i, reader["Product_ID"].ToString(), reader["Product_Code"].ToString(), reader["Product_Name"].ToString(),
                                                       reader["Quantity"].ToString());

                    }

                }
                reader.Close();
                connect.Close();
            }
        }

        public void show_item_stock()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {

                int i = 0;
                connect.Open();
                string sql = "SELECT s.StockItem_ID, i.Item_Code, i.Item_Name, s.Stock_Quantity FROM Stock_Item s JOIN Item i ON s.Item_ID = i.Item_ID;";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Stock_Item.Rows.Clear();
                while (reader.Read())
                {
                    i += 1;
                    data_Stock_Item.Rows.Add(i, reader["StockItem_ID"].ToString(), reader["Item_Code"].ToString(), reader["Item_Name"].ToString(),
                                                reader["Stock_Quantity"].ToString());
                }
                reader.Close();
                connect.Close();
            }
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            Purchase_Order_Form frm = new Purchase_Order_Form();
            frm.ShowDialog();
        }

        private void btn_Create_Item_Click(object sender, EventArgs e)
        {
            // Add_New_Item_Form frm = new Add_New_Item_Form();
            // frm.ShowDialog();
        }

        private void data_Stock_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string stock_product = data_Stock_Product.Columns[e.ColumnIndex].Name;
            if (stock_product == "ReStock")
            {
                Restock_Product_Form frm = new Restock_Product_Form(this);
                frm.txt_stock_name.Text = stock_productName;
                frm.stock_ProductID = stock_productID;
                frm.ShowDialog();
            }
        }

        private void data_Stock_Product_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Stock_Product.CurrentRow != null)
            {
                int i = data_Stock_Product.CurrentRow.Index;
                stock_productID = data_Stock_Product[1, i].Value.ToString();
                stock_productName = data_Stock_Product[3, i].Value.ToString();
            }
        }

        private void data_Stock_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string stock_item = data_Stock_Item.Columns[e.ColumnIndex].Name;
            if (stock_item == "Remove")
            {
                Remove_Stock_Form frm = new Remove_Stock_Form();
                frm.txt_Item_Code.Text = stock_itemCode;
                frm.txt_Item_Name.Text = stock_itemName;
                frm.txt_Quantity.Text = stock_quantity;
                frm.stock_ItemID = stock_itemID;
                frm.ShowDialog();
            }
        }

        private void data_Stock_Item_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Stock_Item.CurrentRow != null)
            {
                int i = data_Stock_Item.CurrentRow.Index;
                stock_itemID = data_Stock_Item[1, i].Value.ToString();
                stock_itemCode = data_Stock_Item[2, i].Value.ToString();
                stock_itemName = data_Stock_Item[3, i].Value.ToString();
                stock_quantity = data_Stock_Item[4, i].Value.ToString();
            }
        }
    }
}
