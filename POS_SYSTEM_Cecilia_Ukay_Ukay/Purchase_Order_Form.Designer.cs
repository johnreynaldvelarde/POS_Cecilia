namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Purchase_Order_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Order_Form));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            cmd_Supplier = new ComboBox();
            txt_Date_Created = new TextBox();
            label3 = new Label();
            btn_Close = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            btn_Clear_All = new Button();
            label8 = new Label();
            btn_Add = new Button();
            label7 = new Label();
            cmd_quantity = new ComboBox();
            txt_ShowQyt = new TextBox();
            label5 = new Label();
            cmd_item_purchase = new ComboBox();
            btn_Clear = new Button();
            btn_Buy = new Button();
            panel1 = new Panel();
            data_Grid_Purchase = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            itemCode = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Cancel = new DataGridViewImageColumn();
            label_amount = new Label();
            label6 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Purchase).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 34);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 40;
            label2.Text = "Retailer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(450, 34);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 41;
            label1.Text = "Select a supplier *";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(166, 31);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 29);
            txtUsername.TabIndex = 42;
            // 
            // cmd_Supplier
            // 
            cmd_Supplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_Supplier.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_Supplier.FormattingEnabled = true;
            cmd_Supplier.Location = new Point(602, 32);
            cmd_Supplier.Name = "cmd_Supplier";
            cmd_Supplier.Size = new Size(240, 28);
            cmd_Supplier.TabIndex = 48;
            // 
            // txt_Date_Created
            // 
            txt_Date_Created.BorderStyle = BorderStyle.FixedSingle;
            txt_Date_Created.Enabled = false;
            txt_Date_Created.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Date_Created.Location = new Point(166, 83);
            txt_Date_Created.Name = "txt_Date_Created";
            txt_Date_Created.Size = new Size(240, 29);
            txt_Date_Created.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 85);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 49;
            label3.Text = "Date Created";
            // 
            // btn_Close
            // 
            btn_Close.Cursor = Cursors.Hand;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.Location = new Point(845, 1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(55, 27);
            btn_Close.TabIndex = 36;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 3);
            panel2.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 45);
            panel3.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(14, 159, 104);
            label4.Location = new Point(12, 10);
            label4.Name = "label4";
            label4.Size = new Size(222, 24);
            label4.TabIndex = 0;
            label4.Text = "New Purchase Order";
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_Clear_All);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(btn_Add);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(cmd_quantity);
            panel4.Controls.Add(txt_ShowQyt);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(cmd_item_purchase);
            panel4.Controls.Add(txt_Date_Created);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cmd_Supplier);
            panel4.Controls.Add(txtUsername);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 234);
            panel4.TabIndex = 39;
            // 
            // btn_Clear_All
            // 
            btn_Clear_All.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Clear_All.Cursor = Cursors.Hand;
            btn_Clear_All.FlatAppearance.BorderSize = 0;
            btn_Clear_All.FlatStyle = FlatStyle.Flat;
            btn_Clear_All.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear_All.ForeColor = Color.FromArgb(14, 159, 104);
            btn_Clear_All.Location = new Point(820, 194);
            btn_Clear_All.Name = "btn_Clear_All";
            btn_Clear_All.Size = new Size(57, 37);
            btn_Clear_All.TabIndex = 103;
            btn_Clear_All.Text = "Clear all";
            btn_Clear_All.UseVisualStyleBackColor = true;
            btn_Clear_All.Click += btn_Clear_All_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(294, 140);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 102;
            label8.Text = "Stock Qyt ";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(38, 134, 245);
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.ForeColor = Color.White;
            btn_Add.Image = (Image)resources.GetObject("btn_Add.Image");
            btn_Add.Location = new Point(628, 166);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 39);
            btn_Add.TabIndex = 101;
            btn_Add.Text = " Add";
            btn_Add.TextAlign = ContentAlignment.MiddleRight;
            btn_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(450, 140);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 54;
            label7.Text = "Select a quantity *";
            // 
            // cmd_quantity
            // 
            cmd_quantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_quantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_quantity.FormattingEnabled = true;
            cmd_quantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmd_quantity.Location = new Point(450, 173);
            cmd_quantity.Name = "cmd_quantity";
            cmd_quantity.Size = new Size(146, 28);
            cmd_quantity.TabIndex = 55;
            // 
            // txt_ShowQyt
            // 
            txt_ShowQyt.BorderStyle = BorderStyle.FixedSingle;
            txt_ShowQyt.Enabled = false;
            txt_ShowQyt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ShowQyt.Location = new Point(294, 173);
            txt_ShowQyt.Name = "txt_ShowQyt";
            txt_ShowQyt.Size = new Size(112, 29);
            txt_ShowQyt.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 140);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 51;
            label5.Text = "Select a item *";
            // 
            // cmd_item_purchase
            // 
            cmd_item_purchase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_item_purchase.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_item_purchase.FormattingEnabled = true;
            cmd_item_purchase.Location = new Point(39, 173);
            cmd_item_purchase.Name = "cmd_item_purchase";
            cmd_item_purchase.Size = new Size(249, 28);
            cmd_item_purchase.TabIndex = 52;
            cmd_item_purchase.SelectedIndexChanged += cmd_item_purchase_SelectedIndexChanged;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(71, 81, 86);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(745, 543);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(145, 48);
            btn_Clear.TabIndex = 96;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_Buy
            // 
            btn_Buy.BackColor = Color.FromArgb(14, 159, 104);
            btn_Buy.Cursor = Cursors.Hand;
            btn_Buy.FlatStyle = FlatStyle.Flat;
            btn_Buy.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Buy.ForeColor = Color.White;
            btn_Buy.Location = new Point(587, 543);
            btn_Buy.Name = "btn_Buy";
            btn_Buy.Size = new Size(145, 48);
            btn_Buy.TabIndex = 95;
            btn_Buy.Text = "Buy";
            btn_Buy.UseVisualStyleBackColor = false;
            btn_Buy.Click += btn_Buy_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(data_Grid_Purchase);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 234);
            panel1.TabIndex = 98;
            // 
            // data_Grid_Purchase
            // 
            data_Grid_Purchase.AllowUserToAddRows = false;
            data_Grid_Purchase.AllowUserToResizeColumns = false;
            data_Grid_Purchase.AllowUserToResizeRows = false;
            data_Grid_Purchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Purchase.BackgroundColor = Color.White;
            data_Grid_Purchase.BorderStyle = BorderStyle.None;
            data_Grid_Purchase.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Purchase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Grid_Purchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Grid_Purchase.ColumnHeadersHeight = 50;
            data_Grid_Purchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Purchase.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, itemCode, Column9, Column6, Column7, Column8, Column5, Cancel });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Grid_Purchase.DefaultCellStyle = dataGridViewCellStyle2;
            data_Grid_Purchase.Dock = DockStyle.Fill;
            data_Grid_Purchase.EnableHeadersVisualStyles = false;
            data_Grid_Purchase.Location = new Point(0, 0);
            data_Grid_Purchase.Name = "data_Grid_Purchase";
            data_Grid_Purchase.ReadOnly = true;
            data_Grid_Purchase.RowHeadersVisible = false;
            data_Grid_Purchase.RowHeadersWidth = 50;
            data_Grid_Purchase.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Purchase.RowTemplate.Height = 40;
            data_Grid_Purchase.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Purchase.Size = new Size(880, 234);
            data_Grid_Purchase.TabIndex = 4;
            data_Grid_Purchase.CellContentClick += data_Grid_Purchase_CellContentClick;
            data_Grid_Purchase.CellFormatting += data_Grid_Purchase_CellFormatting;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 25.6756935F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Item_ID";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            // 
            // itemCode
            // 
            itemCode.FillWeight = 84.35392F;
            itemCode.HeaderText = "Item Code";
            itemCode.Name = "itemCode";
            itemCode.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column9.FillWeight = 123.02478F;
            Column9.HeaderText = " Name";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.FillWeight = 94.55481F;
            Column6.HeaderText = " Price";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.FillWeight = 98.23745F;
            Column7.HeaderText = " Per each";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.FillWeight = 98.23745F;
            Column8.HeaderText = "Total Qyt";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 94.55481F;
            Column5.HeaderText = "Amount";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Cancel
            // 
            Cancel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Cancel.HeaderText = "";
            Cancel.Image = (Image)resources.GetObject("Cancel.Image");
            Cancel.Name = "Cancel";
            Cancel.ReadOnly = true;
            Cancel.Width = 5;
            // 
            // label_amount
            // 
            label_amount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_amount.AutoSize = true;
            label_amount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_amount.ForeColor = Color.FromArgb(211, 82, 48);
            label_amount.Location = new Point(158, 554);
            label_amount.Name = "label_amount";
            label_amount.Size = new Size(75, 25);
            label_amount.TabIndex = 100;
            label_amount.Text = "100000";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 554);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 99;
            label6.Text = "Total Amount:";
            // 
            // Purchase_Order_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(label_amount);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Buy);
            Controls.Add(panel4);
            Controls.Add(btn_Close);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Purchase_Order_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Purchase_Order_Form_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Grid_Purchase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private ComboBox cmd_Supplier;
        private TextBox txt_Date_Created;
        private Label label3;
        private Button btn_Close;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Button btn_Clear;
        private Button btn_Buy;
        private Panel panel1;
        private DataGridView data_Grid_Purchase;
        private Label label5;
        private ComboBox cmd_item_purchase;
        private TextBox txt_ShowQyt;
        private Label label_amount;
        private Label label6;
        private Label label7;
        private ComboBox cmd_quantity;
        private Button btn_Add;
        private Label label8;
        private Button btn_Clear_All;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn itemCode;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Cancel;
    }
}