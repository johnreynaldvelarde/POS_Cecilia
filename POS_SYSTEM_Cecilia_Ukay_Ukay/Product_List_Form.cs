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
    public partial class Product_List_Form : Form
    {
        DB_Connection database = new DB_Connection();

        public Product_List_Form()
        {
            InitializeComponent();
            button_highligted();
            view_product_list();
            load_category();
        }

        private Color defaultColor = Color.FromArgb(14, 159, 104);
        private Color settingsColor = Color.FromArgb(242, 197, 70);

        private string product_id, product_code, product_name, cate_type, price, quantity, size;
        private int category_id;

        public void button_highligted()
        {
            //  btn_Add_Product.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            //  btn_Add_Product.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            // btn_Add_Product.BackColor = settingsColor;

            Add_New_Product_Form frm = new Add_New_Product_Form(this);
            frm.btn_Update.Enabled = false;
            frm.ShowDialog();
            frm.Dispose();
            // btn_Add_Product.BackColor = defaultColor;
        }

        public void view_product_list()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();

                string sql = "SELECT P.Product_ID, P.Product_Code, P.Product_Name, P.Price, P.Date_Added, P.Size, C.Category_Name " +
                             "FROM Product P " +
                             "INNER JOIN Categories C ON P.Category_ID = C.Category_ID " +
                             "WHERE P.Archive = 0";

                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Product.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Grid_Product.Rows.Add(i, reader["Product_ID"].ToString(), reader["Product_Code"].ToString(), reader["Product_Name"].ToString(),
                                                  reader["Category_Name"].ToString(), reader["Price"].ToString(), reader["Size"].ToString(), reader["Date_Added"].ToString());
                }
                reader.Close();
                connect.Close();
            }
        }

        private void data_Grid_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_product = data_Grid_Product.Columns[e.ColumnIndex].Name;

            if (column_product == "Edit")
            {
                Add_New_Product_Form frm = new Add_New_Product_Form(this);
                frm.title_product.Text = "Update the product";
                frm.btn_Save.Enabled = false;
                frm.btn_Update.Enabled = true;
                frm.txt_Product_Code.Enabled = false;
                frm.productID = product_id.ToString();
                frm.txt_Product_Code.Text = product_code;
                frm.txt_Product_Name.Text = product_name;
                frm.txt_Price.Text = price;
                frm.cmd_Measurement.SelectedItem = size;
                frm.cmd_Category.SelectedItem = cate_type;

                frm.ShowDialog();
            }
            else if (column_product == "Delete")
            {
                if (e.ColumnIndex == data_Grid_Product.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int productID = Convert.ToInt32(data_Grid_Product.Rows[e.RowIndex].Cells["productID"].Value);

                    bool hasExistingStock = CheckExistingProductStock(productID);

                    if (hasExistingStock)
                    {
                        MessageBox.Show("Cannot delete the product because it has existing stock.", "Delete product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Do you want to delete this product?", "Delete the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                            {
                                connect.Open();
                                string sql = "UPDATE Product SET Archive = 1 WHERE Product_ID = @Product_ID";
                                SqlCommand command = new SqlCommand(sql, connect);
                                command.Parameters.AddWithValue("@Product_ID", Convert.ToInt32(product_id));
                                command.ExecuteNonQuery();
                                connect.Close();
                            }
                            data_Grid_Product.Rows.RemoveAt(e.RowIndex);
                            view_product_list();
                        }
                    }
                }
            }
        }

        private bool CheckExistingProductStock(int productID)
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT COUNT(*) FROM Product_Stock WHERE Product_ID = @Product_ID AND ProductStock_Qyt > 0";
                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@Product_ID", productID);

                int count = Convert.ToInt32(command.ExecuteScalar());
                connect.Close();

                return count > 0;
            }
        }

        private void data_Grid_Product_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Grid_Product.CurrentRow != null)
            {
                int i = data_Grid_Product.CurrentRow.Index;
                product_id = data_Grid_Product[1, i].Value.ToString();
                product_code = data_Grid_Product[2, i].Value.ToString();
                product_name = data_Grid_Product[3, i].Value.ToString();
                cate_type = data_Grid_Product[4, i].Value.ToString();
                price = data_Grid_Product[5, i].Value.ToString();
                size = data_Grid_Product[6, i].Value.ToString();
            }
        }

        public void load_category()
        {
            cmd_Category.Items.Add("All");

            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                connect.Open();
                string sql = "SELECT Category_Name FROM Categories WHERE Archive = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string categoryName = reader.GetString(0);
                    cmd_Category.Items.Add(categoryName);
                }

                reader.Close();
                connect.Close();
            }
            cmd_Category.SelectedItem = "All";

        }

        private void cmd_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmd_Category.SelectedItem?.ToString();
            if (selectedCategory == "All")
            {
                view_product_list();
                txt_search_product.Clear();
                cmd_OrderBy.SelectedIndex = -1;
            }
            else
            {
                filter_data_cmdCategory(selectedCategory);
                txt_search_product.Clear();
                cmd_OrderBy.SelectedIndex = -1;
            }

        }

        private void filter_data_cmdCategory(string filterText)
        {
            int rowNumber = 0;

            foreach (DataGridViewRow row in data_Grid_Product.Rows)
            {
                string category = row.Cells[4].Value?.ToString();

                if (category.Equals(filterText, StringComparison.OrdinalIgnoreCase))
                {
                    rowNumber++;
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }

                row.Cells[0].Value = rowNumber.ToString();
            }

        }

        private void txt_search_product_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_search_product.Text;
            string selectedCategory = cmd_Category.SelectedItem?.ToString();

            filter_data_product(filterText, selectedCategory);
            ResetRowNumbers();
        }

        private void filter_data_product(string filterText, string selectedCategory)
        {
            int rowNumber = 0;

            foreach (DataGridViewRow row in data_Grid_Product.Rows)
            {
                string p_code = row.Cells[2].Value?.ToString();
                string p_name = row.Cells[3].Value?.ToString();
                string c_tegory = row.Cells[4].Value?.ToString();

                bool categoryMatches = selectedCategory == "All" || c_tegory.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase);

                if (categoryMatches && (p_code != null && p_code.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p_name != null && p_name.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    rowNumber++;
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }

                row.Cells[1].Value = rowNumber.ToString();
            }
        }

        private void ResetRowNumbers()
        {
            int rowNumber = 0;

            foreach (DataGridViewRow row in data_Grid_Product.Rows)
            {
                if (row.Visible)
                {
                    rowNumber++;
                    row.Cells[0].Value = rowNumber.ToString();
                }
                else
                {
                    row.Cells[0].Value = "";
                }
            }
        }

        private void cmd_OrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cmd_OrderBy.SelectedItem?.ToString();

            if (selectedOption == "A-z")
            {
                SortDataGrid("Product_Name", ListSortDirection.Ascending);
                ResetRowNumbers();

            }
            else if (selectedOption == "Z-a")
            {
                SortDataGrid("Product_Name", ListSortDirection.Descending);
                ResetRowNumbers();
            }
        }

        private void SortDataGrid(string columnName, ListSortDirection direction)
        {
            data_Grid_Product.Sort(data_Grid_Product.Columns[3], ListSortDirection.Ascending);
            
            DataGridViewColumn column = data_Grid_Product.Columns[3];
            data_Grid_Product.Sort(column, direction);

            for (int i = 0; i < data_Grid_Product.Rows.Count; i++)
            {
                DataGridViewRow row = data_Grid_Product.Rows[i];
                row.Cells[0].Value = (i + 1).ToString();
            }
            
        }
    }
}
