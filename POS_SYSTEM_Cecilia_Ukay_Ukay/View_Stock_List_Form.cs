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
                    data_Stock_Item.Rows.Add(1, reader["StockItem_ID"].ToString(), reader["Item_Code"].ToString(), reader["Item_Name"].ToString(),
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
                Restock_Product_Form frm = new Restock_Product_Form();
                frm.ShowDialog();
            }
        }

        private void data_Stock_Product_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void data_Stock_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string stock_item = data_Stock_Item.Columns[e.ColumnIndex].Name;
            if (stock_item == "ReStock")
            {
                MessageBox.Show("Cardo Cana");
            }
        }

        private void data_Stock_Item_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
