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
    public partial class Product_Show : UserControl
    {
        //DB_Connection database = new DB_Connection();

        public Product_Show()
        {
            InitializeComponent();
        }

        public void LoadProduct(Product product)
        {

            product_name.Text = product.Name;
            product_category.Text = product.category;
            product_price.Text = product.price.ToString();
            product_quantity.Text = product.quantity.ToString();

            /*
            if (product.product_image != null)
            {
                picture_product.Image = product.product_image;
            }
            else
            {

                // Load the image from the database
               
                using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                {
                    string query = "SELECT Product_Image FROM Product_List WHERE Product_Name = @Product_Name";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@Product_Name", product.Name);

                    connect.Open();
                    byte[] imageBytes = (byte[])command.ExecuteScalar();
                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            product.product_image = Image.FromStream(ms);
                            picture_product.Image = product.product_image;
                        }
                    }
                    else
                    {
                        // Use a default image if the product does not have an image in the database
                        //  product.product_image = Properties.Resources.default_image;
                        product.product_image = new Bitmap(1, 1);
                        picture_product.Image = product.product_image;
                    }

                }
                */

        }

    }
}

