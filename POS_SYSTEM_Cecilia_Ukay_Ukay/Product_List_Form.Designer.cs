namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Product_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_List_Form));
            panel1 = new Panel();
            button1 = new Button();
            btn_Add_Product = new Button();
            label1 = new Label();
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
            btn_Discount = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Product).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Discount);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Add_Product);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1090, 68);
            panel1.TabIndex = 0;
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
            // btn_Add_Product
            // 
            btn_Add_Product.BackColor = Color.FromArgb(14, 159, 104);
            btn_Add_Product.Cursor = Cursors.Hand;
            btn_Add_Product.FlatAppearance.BorderSize = 0;
            btn_Add_Product.FlatStyle = FlatStyle.Flat;
            btn_Add_Product.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add_Product.ForeColor = Color.White;
            btn_Add_Product.Image = (Image)resources.GetObject("btn_Add_Product.Image");
            btn_Add_Product.Location = new Point(694, 9);
            btn_Add_Product.Name = "btn_Add_Product";
            btn_Add_Product.Size = new Size(199, 38);
            btn_Add_Product.TabIndex = 15;
            btn_Add_Product.Text = "Add new product";
            btn_Add_Product.TextAlign = ContentAlignment.MiddleRight;
            btn_Add_Product.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add_Product.UseVisualStyleBackColor = false;
            btn_Add_Product.Click += btn_Add_Product_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(207, 33);
            label1.TabIndex = 1;
            label1.Text = "List of Products";
            // 
            // panel2
            // 
            panel2.Controls.Add(data_Grid_Product);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1090, 494);
            panel2.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Grid_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Grid_Product.ColumnHeadersHeight = 50;
            data_Grid_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Product.Columns.AddRange(new DataGridViewColumn[] { Column1, Column6, Column3, Column2, Column4, Column5, Column7, Column8, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Grid_Product.DefaultCellStyle = dataGridViewCellStyle2;
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
            data_Grid_Product.Size = new Size(1090, 494);
            data_Grid_Product.TabIndex = 3;
            data_Grid_Product.CellContentClick += data_Grid_Product_CellContentClick;
            data_Grid_Product.SelectionChanged += data_Grid_Product_SelectionChanged;
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
            // btn_Discount
            // 
            btn_Discount.BackColor = Color.FromArgb(14, 159, 104);
            btn_Discount.Cursor = Cursors.Hand;
            btn_Discount.FlatAppearance.BorderSize = 0;
            btn_Discount.FlatStyle = FlatStyle.Flat;
            btn_Discount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Discount.ForeColor = Color.White;
            btn_Discount.Image = (Image)resources.GetObject("btn_Discount.Image");
            btn_Discount.Location = new Point(461, 9);
            btn_Discount.Name = "btn_Discount";
            btn_Discount.Size = new Size(210, 38);
            btn_Discount.TabIndex = 17;
            btn_Discount.Text = "Create new discount";
            btn_Discount.TextAlign = ContentAlignment.MiddleRight;
            btn_Discount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Discount.UseVisualStyleBackColor = false;
            // 
            // Product_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 587);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Grid_Product).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_Add_Product;
        private Button button1;
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
        private Button btn_Discount;
    }
}