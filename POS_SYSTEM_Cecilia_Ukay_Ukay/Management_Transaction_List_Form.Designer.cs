﻿namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Management_Transaction_List_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management_Transaction_List_Form));
            data_Grid_Category = new DataGridView();
            panel1 = new Panel();
            btn_Export = new Button();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Category).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // data_Grid_Category
            // 
            data_Grid_Category.AllowUserToAddRows = false;
            data_Grid_Category.AllowUserToOrderColumns = true;
            data_Grid_Category.AllowUserToResizeColumns = false;
            data_Grid_Category.AllowUserToResizeRows = false;
            data_Grid_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Category.BackgroundColor = Color.White;
            data_Grid_Category.BorderStyle = BorderStyle.None;
            data_Grid_Category.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Category.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Grid_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Grid_Category.ColumnHeadersHeight = 50;
            data_Grid_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Category.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3, Column5, Column4, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Grid_Category.DefaultCellStyle = dataGridViewCellStyle2;
            data_Grid_Category.Dock = DockStyle.Fill;
            data_Grid_Category.EnableHeadersVisualStyles = false;
            data_Grid_Category.Location = new Point(5, 88);
            data_Grid_Category.Name = "data_Grid_Category";
            data_Grid_Category.ReadOnly = true;
            data_Grid_Category.RowHeadersVisible = false;
            data_Grid_Category.RowHeadersWidth = 50;
            data_Grid_Category.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Category.RowTemplate.Height = 40;
            data_Grid_Category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Category.Size = new Size(1088, 492);
            data_Grid_Category.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Export);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 3;
            // 
            // btn_Export
            // 
            btn_Export.BackColor = Color.FromArgb(14, 159, 104);
            btn_Export.Cursor = Cursors.Hand;
            btn_Export.FlatAppearance.BorderSize = 0;
            btn_Export.FlatStyle = FlatStyle.Flat;
            btn_Export.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Export.ForeColor = Color.White;
            btn_Export.Image = (Image)resources.GetObject("btn_Export.Image");
            btn_Export.Location = new Point(908, 9);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(159, 38);
            btn_Export.TabIndex = 16;
            btn_Export.Text = "Excel Export";
            btn_Export.TextAlign = ContentAlignment.MiddleRight;
            btn_Export.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Export.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(353, 33);
            label1.TabIndex = 1;
            label1.Text = "Management Transaction";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 60F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Retailer Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Supplier Name";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Related Item";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Date ";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total Amount";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 50;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 50;
            // 
            // Management_Transaction_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Grid_Category);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Management_Transaction_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)data_Grid_Category).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_Grid_Category;
        private Panel panel1;
        private Button btn_Export;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Delete;
    }
}