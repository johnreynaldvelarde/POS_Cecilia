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
using Microsoft.Office.Interop.Excel;
using System.IO;


namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public partial class Category_List_Form : Form
    {
        DB_Connection database = new DB_Connection();
        
        public Category_List_Form()
        {
            InitializeComponent();
            view_category();
        }

        string category_name, category_id;

        private void btn_Add_Category_Click(object sender, EventArgs e)
        {
            Add_New_Category_Form frm = new Add_New_Category_Form(this);
            frm.btn_Update.Enabled = false;
            frm.ShowDialog();
            frm.Dispose();
        }

        public void view_category()
        {
            using (SqlConnection connect = new SqlConnection(database.MyConnection()))
            {
                int i = 0;
                connect.Open();
                string sql = "SELECT Category_ID, Category_Name, Date_Added, Deleted FROM Categories WHERE Deleted = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Category.Rows.Clear();

                while (reader.Read())
                {
                    if (reader["Deleted"].ToString() == "0")
                    {
                        i += 1;
                        data_Grid_Category.Rows.Add(i, reader["Category_Name"].ToString(), reader["Date_Added"].ToString(), reader["Category_ID"].ToString());
                    }

                }
                reader.Close();
                connect.Close();
            }
        }


        private void data_Grid_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_category = data_Grid_Category.Columns[e.ColumnIndex].Name;
           

            if (column_category == "Edit")
            {
                Add_New_Category_Form frm = new Add_New_Category_Form(this);
                frm.title_category.Text = "Update the category";
                frm.btn_Save.Enabled = false;
                frm.btn_Update.Enabled = true;
                frm.txt_Category.Text = category_name;
                frm.categoryID = category_id.ToString();
                frm.ShowDialog();
            }
            else if (column_category == "Delete") 
            {
                if (e.ColumnIndex == data_Grid_Category.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    //int id = Convert.ToInt32(data_Grid_Category.Rows[e.RowIndex].Cells["Category_ID"].Value);
                    if (MessageBox.Show("Do you want to delete this product?", "Delete the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    {
                        using (SqlConnection connect = new SqlConnection(database.MyConnection()))
                        {
                            connect.Open();
                            string sql = "UPDATE Categories SET Deleted = 1 WHERE Category_ID = @Category_ID";
                            SqlCommand command = new SqlCommand(sql, connect);
                            command.Parameters.AddWithValue("@Category_ID", Convert.ToInt32(category_id));
                            command.ExecuteNonQuery();
                            connect.Close();
                            
                        }

                        data_Grid_Category.Rows.RemoveAt(e.RowIndex);
                        view_category();

                    }
                }
            }
        }

        private void data_Grid_Category_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Grid_Category.CurrentRow != null)
            {
                int i = data_Grid_Category.CurrentRow.Index;
                category_name = data_Grid_Category[1, i].Value.ToString();
                category_id = data_Grid_Category[3, i].Value.ToString();
            }
            //int i = data_Grid_Category.CurrentRow.Index;
            
        }

        // export in excel
        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Create a new Excel workbook
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Add();

            // Create a new worksheet
            var worksheet = workbook.Sheets.Add() as Worksheet;
            worksheet.Name = "Categories";

            // Export the DataGridView contents to the worksheet
            for (int i = 1; i <= data_Grid_Category.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = data_Grid_Category.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < data_Grid_Category.Rows.Count; i++)
            {
                for (int j = 0; j < data_Grid_Category.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = data_Grid_Category.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Save the workbook
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook|*.xlsx";
            saveFileDialog.Title = "Save as Excel Workbook";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }

            // Clean up
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }


    }
}
