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
        }

        private Color defaultColor = Color.FromArgb(14, 159, 104);
        private Color settingsColor = Color.FromArgb(242, 197, 70);

        public void button_highligted()
        {
            btn_Add_Product.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 197, 70);
            btn_Add_Product.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 197, 70);

        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            btn_Add_Product.BackColor = settingsColor;

            Add_New_Product_Form frm = new Add_New_Product_Form();
            frm.btn_Update.Enabled = false;
            frm.ShowDialog();
            frm.Dispose();
            btn_Add_Product.BackColor = defaultColor;
        }

        public void view_product_list()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT Product_ID, Product_Code, Product_Name, Price, Quantity, Date_Added,Unit_Measurement, Deleted FROM Product WHERE Deleted = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Product.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Deleted"].ToString() == "0")
                    {
                        i += 1;
                        data_Grid_Product.Rows.Add(i, reader["Product_ID"].ToString(), reader["Product_Code"].ToString(), reader["Product_Name"].ToString(),
                                                      reader["Price"].ToString(), reader["Quantity"].ToString(), reader["Unit_Measurement"].ToString(),
                                                      reader["Date_Added"].ToString());
                    }

                }
                reader.Close();
                connect.Close();
            }
        }
    }
}
