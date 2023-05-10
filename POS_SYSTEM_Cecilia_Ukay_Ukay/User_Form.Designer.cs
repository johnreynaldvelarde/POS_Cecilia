namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Form));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_Category_List = new Button();
            btn_Product_List = new Button();
            panel_center = new Panel();
            data_Grid_Product = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewImageColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Product).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(258, 33);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1044, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 60);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 3);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_Category_List);
            panel3.Controls.Add(btn_Product_List);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1080, 60);
            panel3.TabIndex = 13;
            // 
            // btn_Category_List
            // 
            btn_Category_List.BackColor = Color.FromArgb(14, 159, 104);
            btn_Category_List.Cursor = Cursors.Hand;
            btn_Category_List.FlatAppearance.BorderSize = 0;
            btn_Category_List.FlatStyle = FlatStyle.Flat;
            btn_Category_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Category_List.ForeColor = Color.White;
            btn_Category_List.Image = (Image)resources.GetObject("btn_Category_List.Image");
            btn_Category_List.Location = new Point(226, 11);
            btn_Category_List.Name = "btn_Category_List";
            btn_Category_List.Size = new Size(197, 38);
            btn_Category_List.TabIndex = 17;
            btn_Category_List.Text = "List of Customer";
            btn_Category_List.TextAlign = ContentAlignment.MiddleRight;
            btn_Category_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Category_List.UseVisualStyleBackColor = false;
            // 
            // btn_Product_List
            // 
            btn_Product_List.BackColor = Color.FromArgb(14, 159, 104);
            btn_Product_List.Cursor = Cursors.Hand;
            btn_Product_List.FlatAppearance.BorderSize = 0;
            btn_Product_List.FlatStyle = FlatStyle.Flat;
            btn_Product_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Product_List.ForeColor = Color.White;
            btn_Product_List.Image = (Image)resources.GetObject("btn_Product_List.Image");
            btn_Product_List.Location = new Point(12, 11);
            btn_Product_List.Name = "btn_Product_List";
            btn_Product_List.Size = new Size(197, 38);
            btn_Product_List.TabIndex = 16;
            btn_Product_List.Text = "List of Employee";
            btn_Product_List.TextAlign = ContentAlignment.MiddleRight;
            btn_Product_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Product_List.UseVisualStyleBackColor = false;
            // 
            // panel_center
            // 
            panel_center.Controls.Add(data_Grid_Product);
            panel_center.Dock = DockStyle.Fill;
            panel_center.Location = new Point(10, 133);
            panel_center.Name = "panel_center";
            panel_center.Size = new Size(1080, 557);
            panel_center.TabIndex = 19;
            // 
            // data_Grid_Product
            // 
            data_Grid_Product.AllowUserToAddRows = false;
            data_Grid_Product.AllowUserToOrderColumns = true;
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
            data_Grid_Product.ColumnHeadersHeight = 40;
            data_Grid_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Product.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Grid_Product.DefaultCellStyle = dataGridViewCellStyle2;
            data_Grid_Product.Dock = DockStyle.Fill;
            data_Grid_Product.EnableHeadersVisualStyles = false;
            data_Grid_Product.Location = new Point(0, 0);
            data_Grid_Product.Name = "data_Grid_Product";
            data_Grid_Product.RowHeadersVisible = false;
            data_Grid_Product.RowHeadersWidth = 50;
            data_Grid_Product.RowTemplate.Height = 25;
            data_Grid_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Product.Size = new Size(1080, 557);
            data_Grid_Product.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Employee Image";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Employee Name";
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.HeaderText = "Role";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Date Added";
            Column7.Name = "Column7";
            // 
            // User_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            ControlBox = false;
            Controls.Add(panel_center);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "User_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Grid_Product).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_Category_List;
        public Button btn_Product_List;
        private Panel panel_center;
        private DataGridView data_Grid_Product;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewImageColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}