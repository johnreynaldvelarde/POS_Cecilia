﻿namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class View_Stock_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Stock_List_Form));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            data_Stock_Product = new DataGridView();
            panel1 = new Panel();
            btn_Create_Item = new Button();
            button1 = new Button();
            btn_Purchase = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewImageColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)data_Stock_Product).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // data_Stock_Product
            // 
            data_Stock_Product.AllowUserToAddRows = false;
            data_Stock_Product.AllowUserToOrderColumns = true;
            data_Stock_Product.AllowUserToResizeColumns = false;
            data_Stock_Product.AllowUserToResizeRows = false;
            data_Stock_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Stock_Product.BackgroundColor = Color.White;
            data_Stock_Product.BorderStyle = BorderStyle.None;
            data_Stock_Product.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Stock_Product.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Stock_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Stock_Product.ColumnHeadersHeight = 50;
            data_Stock_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Stock_Product.Columns.AddRange(new DataGridViewColumn[] { Column1, Column6, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Stock_Product.DefaultCellStyle = dataGridViewCellStyle2;
            data_Stock_Product.Dock = DockStyle.Fill;
            data_Stock_Product.EnableHeadersVisualStyles = false;
            data_Stock_Product.Location = new Point(0, 0);
            data_Stock_Product.Name = "data_Stock_Product";
            data_Stock_Product.ReadOnly = true;
            data_Stock_Product.RowHeadersVisible = false;
            data_Stock_Product.RowHeadersWidth = 50;
            data_Stock_Product.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Stock_Product.RowTemplate.Height = 40;
            data_Stock_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Stock_Product.Size = new Size(540, 442);
            data_Stock_Product.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Create_Item);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Purchase);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 4;
            // 
            // btn_Create_Item
            // 
            btn_Create_Item.BackColor = Color.FromArgb(14, 159, 104);
            btn_Create_Item.Cursor = Cursors.Hand;
            btn_Create_Item.FlatAppearance.BorderSize = 0;
            btn_Create_Item.FlatStyle = FlatStyle.Flat;
            btn_Create_Item.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Create_Item.ForeColor = Color.White;
            btn_Create_Item.Image = (Image)resources.GetObject("btn_Create_Item.Image");
            btn_Create_Item.Location = new Point(473, 9);
            btn_Create_Item.Name = "btn_Create_Item";
            btn_Create_Item.Size = new Size(199, 38);
            btn_Create_Item.TabIndex = 17;
            btn_Create_Item.Text = "Create new item";
            btn_Create_Item.TextAlign = ContentAlignment.MiddleRight;
            btn_Create_Item.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Create_Item.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 159, 104);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(908, 9);
            button1.Name = "button1";
            button1.Size = new Size(159, 38);
            button1.TabIndex = 16;
            button1.Text = "Excel Export";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_Purchase
            // 
            btn_Purchase.BackColor = Color.FromArgb(14, 159, 104);
            btn_Purchase.Cursor = Cursors.Hand;
            btn_Purchase.FlatAppearance.BorderSize = 0;
            btn_Purchase.FlatStyle = FlatStyle.Flat;
            btn_Purchase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Purchase.ForeColor = Color.White;
            btn_Purchase.Image = (Image)resources.GetObject("btn_Purchase.Image");
            btn_Purchase.Location = new Point(694, 9);
            btn_Purchase.Name = "btn_Purchase";
            btn_Purchase.Size = new Size(199, 38);
            btn_Purchase.TabIndex = 15;
            btn_Purchase.Text = "New purchase order";
            btn_Purchase.TextAlign = ContentAlignment.MiddleRight;
            btn_Purchase.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Purchase.UseVisualStyleBackColor = false;
            btn_Purchase.Click += btn_Purchase_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(218, 33);
            label1.TabIndex = 1;
            label1.Text = "Stock Inventory";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 50);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(564, 12);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 3;
            label3.Text = "Item Stock List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 2;
            label2.Text = "Product Stock List";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 138);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(data_Stock_Product);
            splitContainer1.Panel1.Padding = new Padding(0, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Padding = new Padding(10, 0, 0, 0);
            splitContainer1.Size = new Size(1088, 442);
            splitContainer1.SplitterDistance = 550;
            splitContainer1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column5, Column7, Column8, Column9 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(524, 442);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 60F;
            dataGridViewTextBoxColumn1.HeaderText = "#";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Item_ID";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // Column7
            // 
            Column7.HeaderText = "Name";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Stock Quantity";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 60F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Product_ID";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Stock Quantity";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // View_Stock_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "View_Stock_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)data_Stock_Product).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView data_Stock_Product;
        private Panel panel1;
        private Button btn_Create_Item;
        private Button button1;
        private Button btn_Purchase;
        private Label label1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewImageColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Column9;
    }
}