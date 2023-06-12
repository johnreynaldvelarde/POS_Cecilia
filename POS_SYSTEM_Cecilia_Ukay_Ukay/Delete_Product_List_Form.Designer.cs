namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Delete_Product_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Product_List_Form));
            panel1 = new Panel();
            label1 = new Label();
            data_Delete_Product = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Product_ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Restore = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Delete_Product).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 33);
            label1.TabIndex = 1;
            // 
            // data_Delete_Product
            // 
            data_Delete_Product.AllowUserToAddRows = false;
            data_Delete_Product.AllowUserToOrderColumns = true;
            data_Delete_Product.AllowUserToResizeColumns = false;
            data_Delete_Product.AllowUserToResizeRows = false;
            data_Delete_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Delete_Product.BackgroundColor = Color.White;
            data_Delete_Product.BorderStyle = BorderStyle.None;
            data_Delete_Product.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Delete_Product.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Delete_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Delete_Product.ColumnHeadersHeight = 50;
            data_Delete_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Delete_Product.Columns.AddRange(new DataGridViewColumn[] { Column1, Product_ID, Column2, Column5, Restore });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Delete_Product.DefaultCellStyle = dataGridViewCellStyle2;
            data_Delete_Product.Dock = DockStyle.Fill;
            data_Delete_Product.EnableHeadersVisualStyles = false;
            data_Delete_Product.Location = new Point(5, 88);
            data_Delete_Product.Name = "data_Delete_Product";
            data_Delete_Product.ReadOnly = true;
            data_Delete_Product.RowHeadersVisible = false;
            data_Delete_Product.RowHeadersWidth = 50;
            data_Delete_Product.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Delete_Product.RowTemplate.Height = 40;
            data_Delete_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Delete_Product.Size = new Size(1088, 492);
            data_Delete_Product.TabIndex = 6;
            data_Delete_Product.CellContentClick += data_Delete_Product_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 108.199493F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Product_ID
            // 
            Product_ID.DataPropertyName = "Product_ID";
            Product_ID.HeaderText = "Product_ID";
            Product_ID.Name = "Product_ID";
            Product_ID.ReadOnly = true;
            Product_ID.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 149.594437F;
            Column2.HeaderText = "Product Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 93.4010239F;
            Column5.HeaderText = "Date Added";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Restore
            // 
            Restore.FillWeight = 54.4025269F;
            Restore.HeaderText = "";
            Restore.Image = (Image)resources.GetObject("Restore.Image");
            Restore.MinimumWidth = 50;
            Restore.Name = "Restore";
            Restore.ReadOnly = true;
            // 
            // Delete_Product_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Delete_Product);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Delete_Product_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Delete_Product).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView data_Delete_Product;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Restore;
    }
}