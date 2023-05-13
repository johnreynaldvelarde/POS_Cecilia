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

        string category_name;
        public int category_id;

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
                string sql = "SELECT Category_ID, Category_Name, Date_Added FROM Categories WHERE Deleted = 0";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                data_Grid_Category.Rows.Clear();

                while (reader.Read())
                {
                    i += 1;
                    data_Grid_Category.Rows.Add(i, reader["Category_ID"].ToString(), reader["Category_Name"].ToString(), reader["Date_Added"].ToString());
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
                frm.ShowDialog();

            }
        }

        private void data_Grid_Category_SelectionChanged(object sender, EventArgs e)
        {
            int i = data_Grid_Category.CurrentRow.Index;
            category_name = data_Grid_Category[1, i].Value.ToString();
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
