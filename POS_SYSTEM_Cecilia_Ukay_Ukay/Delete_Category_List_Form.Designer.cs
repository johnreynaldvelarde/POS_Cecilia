namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Delete_Category_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Category_List_Form));
            data_Delete_Category = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Category_ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Restore = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)data_Delete_Category).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // data_Delete_Category
            // 
            data_Delete_Category.AllowUserToAddRows = false;
            data_Delete_Category.AllowUserToOrderColumns = true;
            data_Delete_Category.AllowUserToResizeColumns = false;
            data_Delete_Category.AllowUserToResizeRows = false;
            data_Delete_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Delete_Category.BackgroundColor = Color.White;
            data_Delete_Category.BorderStyle = BorderStyle.None;
            data_Delete_Category.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Delete_Category.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Delete_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Delete_Category.ColumnHeadersHeight = 50;
            data_Delete_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Delete_Category.Columns.AddRange(new DataGridViewColumn[] { Column1, Category_ID, Column2, Column5, Restore });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Delete_Category.DefaultCellStyle = dataGridViewCellStyle2;
            data_Delete_Category.Dock = DockStyle.Fill;
            data_Delete_Category.EnableHeadersVisualStyles = false;
            data_Delete_Category.Location = new Point(5, 88);
            data_Delete_Category.Name = "data_Delete_Category";
            data_Delete_Category.ReadOnly = true;
            data_Delete_Category.RowHeadersVisible = false;
            data_Delete_Category.RowHeadersWidth = 50;
            data_Delete_Category.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Delete_Category.RowTemplate.Height = 40;
            data_Delete_Category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Delete_Category.Size = new Size(1088, 492);
            data_Delete_Category.TabIndex = 4;
            data_Delete_Category.CellContentClick += data_Delete_Category_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 3;
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
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 108.199493F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Category_ID
            // 
            Category_ID.HeaderText = "Category_ID";
            Category_ID.Name = "Category_ID";
            Category_ID.ReadOnly = true;
            Category_ID.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 149.594437F;
            Column2.HeaderText = "Category Name";
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
            // Delete_Category_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Delete_Category);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Delete_Category_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)data_Delete_Category).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_Delete_Category;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Category_ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Restore;
    }
}