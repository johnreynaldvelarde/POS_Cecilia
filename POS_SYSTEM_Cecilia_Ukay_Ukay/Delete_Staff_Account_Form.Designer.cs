namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Delete_Staff_Account_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Staff_Account_Form));
            panel1 = new Panel();
            label1 = new Label();
            data_Delete_Staff = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Staff_ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Restore = new DataGridViewImageColumn();
            Total_Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Delete_Staff).BeginInit();
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
            // data_Delete_Staff
            // 
            data_Delete_Staff.AllowUserToAddRows = false;
            data_Delete_Staff.AllowUserToOrderColumns = true;
            data_Delete_Staff.AllowUserToResizeColumns = false;
            data_Delete_Staff.AllowUserToResizeRows = false;
            data_Delete_Staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Delete_Staff.BackgroundColor = Color.White;
            data_Delete_Staff.BorderStyle = BorderStyle.None;
            data_Delete_Staff.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Delete_Staff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Delete_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Delete_Staff.ColumnHeadersHeight = 50;
            data_Delete_Staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Delete_Staff.Columns.AddRange(new DataGridViewColumn[] { Column1, Staff_ID, Column2, Column5, Restore, Total_Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Delete_Staff.DefaultCellStyle = dataGridViewCellStyle2;
            data_Delete_Staff.Dock = DockStyle.Fill;
            data_Delete_Staff.EnableHeadersVisualStyles = false;
            data_Delete_Staff.Location = new Point(5, 88);
            data_Delete_Staff.Name = "data_Delete_Staff";
            data_Delete_Staff.ReadOnly = true;
            data_Delete_Staff.RowHeadersVisible = false;
            data_Delete_Staff.RowHeadersWidth = 50;
            data_Delete_Staff.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Delete_Staff.RowTemplate.Height = 40;
            data_Delete_Staff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Delete_Staff.Size = new Size(1088, 492);
            data_Delete_Staff.TabIndex = 7;
            data_Delete_Staff.CellContentClick += data_Delete_Staff_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 108.199493F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Staff_ID
            // 
            Staff_ID.HeaderText = "Staff_ID";
            Staff_ID.Name = "Staff_ID";
            Staff_ID.ReadOnly = true;
            Staff_ID.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 149.594437F;
            Column2.HeaderText = "Staff Name";
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
            // Total_Delete
            // 
            Total_Delete.FillWeight = 54.4025269F;
            Total_Delete.HeaderText = "";
            Total_Delete.Image = (Image)resources.GetObject("Total_Delete.Image");
            Total_Delete.MinimumWidth = 50;
            Total_Delete.Name = "Total_Delete";
            Total_Delete.ReadOnly = true;
            Total_Delete.Visible = false;
            // 
            // Delete_Staff_Account_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Delete_Staff);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Delete_Staff_Account_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Delete_Staff).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView data_Delete_Staff;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Staff_ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Restore;
        private DataGridViewImageColumn Total_Delete;
    }
}