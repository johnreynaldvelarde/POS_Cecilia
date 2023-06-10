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
                string sql = "SELECT ps.ProductStock_ID, p.Product_Code, p.Product_Name, ps.ProductStock_Qyt, p.Archive " +
                             "FROM Product_Stock ps " +
                             "INNER JOIN Product p ON ps.Product_ID = p.Product_ID  " +
                             "WHERE p.Archive = 0";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Stock_Product.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Archive"].ToString() == "0")
                    {
                        i += 1;
                        data_Stock_Product.Rows.Add(i, reader["ProductStock_ID"].ToString(), reader["Product_Code"].ToString(), reader["Product_Name"].ToString(),
                                                       reader["ProductStock_Qyt"].ToString());

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
                string sql = "SELECT s.ItemStock_ID, i.Item_Code, i.Item_Name, s.ItemStock_Qyt FROM Item_Stock s JOIN Item i ON s.Item_ID = i.Item_ID;";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Stock_Item.Rows.Clear();
                while (reader.Read())
                {
                    i += 1;
                    data_Stock_Item.Rows.Add(i, reader["ItemStock_ID"].ToString(), reader["Item_Code"].ToString(), reader["Item_Name"].ToString(),
                                                reader["ItemStock_Qyt"].ToString());
                }
                reader.Close();
                connect.Close();
            }
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            Purchase_Order_Form frm = new Purchase_Order_Form(this);
            frm.ShowDialog();
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
            if (stock_item == "Defect")
            {
                Remove_Stock_Form frm = new Remove_Stock_Form(this);
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

        private void filter_data_product(string filterText)
        {
            foreach (DataGridViewRow row in data_Stock_Product.Rows)
            {
                string p_code = row.Cells[2].Value?.ToString();
                string p_name = row.Cells[3].Value?.ToString();

                if (p_code != null && p_code.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p_name != null && p_name.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void filter_data_item(string filterText)
        {
            foreach (DataGridViewRow row in data_Stock_Item.Rows)
            {
                string i_code = row.Cells[2].Value?.ToString();
                string i_name = row.Cells[3].Value?.ToString();

                if (i_code != null && i_code.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    i_name != null && i_name.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void txt_search_product_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_search_product.Text;
            filter_data_product(filterText);
        }

        private void txt_search_item_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_search_item.Text;
            filter_data_item(filterText);
        }
    }
}
