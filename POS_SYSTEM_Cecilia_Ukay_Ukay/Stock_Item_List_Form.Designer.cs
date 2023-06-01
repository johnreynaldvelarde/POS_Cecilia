namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Stock_Item_List_Form
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Item_List_Form));
            panel2 = new Panel();
            data_Grid_Product = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            btn_Create_Item = new Button();
            button1 = new Button();
            btn_Purchase = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Product).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(data_Grid_Product);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 492);
            panel2.TabIndex = 3;
            // 
            // data_Grid_Product
            // 
            data_Grid_Product.AllowUserToAddRows = false;
            data_Grid_Product.AllowUserToOrderColumns = true;
            data_Grid_Product.AllowUserToResizeColumns = false;
            data_Grid_Product.AllowUserToResizeRows = false;
            data_Grid_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Product.BackgroundColor = Color.White;
            data_Grid_Product.BorderStyle = BorderStyle.None;
            data_Grid_Product.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Product.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Grid_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Grid_Product.ColumnHeadersHeight = 50;
            data_Grid_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Product.Columns.AddRange(new DataGridViewColumn[] { Column1, Column6, Column3, Column2, Column4, Column5, Column7, Column8, Edit, Delete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            data_Grid_Product.DefaultCellStyle = dataGridViewCellStyle4;
            data_Grid_Product.Dock = DockStyle.Fill;
            data_Grid_Product.EnableHeadersVisualStyles = false;
            data_Grid_Product.Location = new Point(0, 0);
            data_Grid_Product.Name = "data_Grid_Product";
            data_Grid_Product.ReadOnly = true;
            data_Grid_Product.RowHeadersVisible = false;
            data_Grid_Product.RowHeadersWidth = 50;
            data_Grid_Product.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Product.RowTemplate.Height = 40;
            data_Grid_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Product.Size = new Size(1088, 492);
            data_Grid_Product.TabIndex = 3;
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
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Product Code";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Product Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Quantity";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Size";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Date Added";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 50;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 50;
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
            panel1.TabIndex = 2;
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
            btn_Create_Item.Click += btn_Create_Item_Click;
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
            label1.Size = new Size(242, 33);
            label1.TabIndex = 1;
            label1.Text = "List of Stock Items";
            // 
            // Stock_Item_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Stock_Item_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Grid_Product).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView data_Grid_Product;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Panel panel1;
        private Button button1;
        private Button btn_Purchase;
        private Label label1;
        private Button btn_Create_Item;
    }
}