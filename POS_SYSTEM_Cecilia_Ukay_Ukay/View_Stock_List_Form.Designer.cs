namespace POS_SYSTEM_Cecilia_Ukay_Ukay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Stock_List_Form));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_Create_Item = new Button();
            button1 = new Button();
            btn_Purchase = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txt_Item_Name = new TextBox();
            splitContainer1 = new SplitContainer();
            data_Stock_Product = new DataGridView();
            data_Stock_Item = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ReStock = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Stock_Product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_Stock_Item).BeginInit();
            SuspendLayout();
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
            label1.Size = new Size(218, 33);
            label1.TabIndex = 1;
            label1.Text = "Stock Inventory";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 50);
            panel2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(564, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(524, 50);
            panel4.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(317, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 31);
            pictureBox2.TabIndex = 99;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 3;
            label3.Text = "Item Stock List";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(351, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 25);
            textBox1.TabIndex = 98;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txt_Item_Name);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 50);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 31);
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
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
            // txt_Item_Name
            // 
            txt_Item_Name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_Item_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Item_Name.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Item_Name.Location = new Point(358, 12);
            txt_Item_Name.Name = "txt_Item_Name";
            txt_Item_Name.Size = new Size(170, 25);
            txt_Item_Name.TabIndex = 96;
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
            splitContainer1.Panel2.Controls.Add(data_Stock_Item);
            splitContainer1.Panel2.Padding = new Padding(10, 0, 0, 0);
            splitContainer1.Size = new Size(1088, 442);
            splitContainer1.SplitterDistance = 550;
            splitContainer1.TabIndex = 6;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            data_Stock_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            data_Stock_Product.ColumnHeadersHeight = 50;
            data_Stock_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Stock_Product.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column1, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, ReStock });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            data_Stock_Product.DefaultCellStyle = dataGridViewCellStyle9;
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
            data_Stock_Product.TabIndex = 5;
            data_Stock_Product.CellContentClick += data_Stock_Product_CellContentClick;
            data_Stock_Product.SelectionChanged += data_Stock_Product_SelectionChanged;
            // 
            // data_Stock_Item
            // 
            data_Stock_Item.AllowUserToAddRows = false;
            data_Stock_Item.AllowUserToOrderColumns = true;
            data_Stock_Item.AllowUserToResizeColumns = false;
            data_Stock_Item.AllowUserToResizeRows = false;
            data_Stock_Item.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Stock_Item.BackgroundColor = Color.White;
            data_Stock_Item.BorderStyle = BorderStyle.None;
            data_Stock_Item.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Stock_Item.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            data_Stock_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            data_Stock_Item.ColumnHeadersHeight = 50;
            data_Stock_Item.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Stock_Item.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewImageColumn1 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            data_Stock_Item.DefaultCellStyle = dataGridViewCellStyle12;
            data_Stock_Item.Dock = DockStyle.Fill;
            data_Stock_Item.EnableHeadersVisualStyles = false;
            data_Stock_Item.Location = new Point(10, 0);
            data_Stock_Item.Name = "data_Stock_Item";
            data_Stock_Item.ReadOnly = true;
            data_Stock_Item.RowHeadersVisible = false;
            data_Stock_Item.RowHeadersWidth = 50;
            data_Stock_Item.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Stock_Item.RowTemplate.Height = 40;
            data_Stock_Item.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Stock_Item.Size = new Size(524, 442);
            data_Stock_Item.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.FillWeight = 46.70051F;
            dataGridViewTextBoxColumn2.HeaderText = "#";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Product_ID";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Visible = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 124.240204F;
            Column1.HeaderText = "Product Code";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.FillWeight = 104.868011F;
            dataGridViewTextBoxColumn4.HeaderText = "Name";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn5.FillWeight = 92.09565F;
            dataGridViewTextBoxColumn5.HeaderText = "Stock Qyt";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ReStock
            // 
            ReStock.FillWeight = 92.09565F;
            ReStock.HeaderText = "";
            ReStock.Image = (Image)resources.GetObject("ReStock.Image");
            ReStock.Name = "ReStock";
            ReStock.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 32.7746048F;
            dataGridViewTextBoxColumn1.HeaderText = "#";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "StockItem_ID";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.FillWeight = 128.426392F;
            dataGridViewTextBoxColumn7.HeaderText = "Item Code";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.FillWeight = 108.4015F;
            dataGridViewTextBoxColumn8.HeaderText = "Name";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn9.FillWeight = 95.19876F;
            dataGridViewTextBoxColumn9.HeaderText = "Stock Qyt";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.FillWeight = 95.19876F;
            dataGridViewImageColumn1.HeaderText = "";
            dataGridViewImageColumn1.Image = (Image)resources.GetObject("dataGridViewImageColumn1.Image");
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Stock_Product).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_Stock_Item).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btn_Create_Item;
        private Button button1;
        private Button btn_Purchase;
        private Label label1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private DataGridView data_Stock_Product;
        private TextBox txt_Item_Name;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private DataGridView data_Stock_Item;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewImageColumn ReStock;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewImageColumn dataGridViewImageColumn1;
    }
}