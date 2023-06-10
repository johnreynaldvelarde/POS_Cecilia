namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class User_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_List_Form));
            data_Grid_Staff = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewImageColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            btn_Add_New_Staff = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Staff).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // data_Grid_Staff
            // 
            data_Grid_Staff.AllowUserToAddRows = false;
            data_Grid_Staff.AllowUserToOrderColumns = true;
            data_Grid_Staff.AllowUserToResizeColumns = false;
            data_Grid_Staff.AllowUserToResizeRows = false;
            data_Grid_Staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Staff.BackgroundColor = Color.White;
            data_Grid_Staff.BorderStyle = BorderStyle.None;
            data_Grid_Staff.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Staff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Grid_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Grid_Staff.ColumnHeadersHeight = 50;
            data_Grid_Staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Staff.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column5, Column4, Column6, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Grid_Staff.DefaultCellStyle = dataGridViewCellStyle2;
            data_Grid_Staff.Dock = DockStyle.Fill;
            data_Grid_Staff.EnableHeadersVisualStyles = false;
            data_Grid_Staff.Location = new Point(5, 88);
            data_Grid_Staff.Name = "data_Grid_Staff";
            data_Grid_Staff.ReadOnly = true;
            data_Grid_Staff.RowHeadersVisible = false;
            data_Grid_Staff.RowHeadersWidth = 50;
            data_Grid_Staff.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Staff.RowTemplate.Height = 50;
            data_Grid_Staff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Staff.Size = new Size(1088, 492);
            data_Grid_Staff.TabIndex = 4;
            data_Grid_Staff.CellContentClick += data_Grid_Staff_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 60F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Profile Picture";
            Column3.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Staff Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Date Added";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Contact Number";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Role";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
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
            panel1.Controls.Add(btn_Add_New_Staff);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 3;
            // 
            // btn_Add_New_Staff
            // 
            btn_Add_New_Staff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Add_New_Staff.BackColor = Color.FromArgb(14, 159, 104);
            btn_Add_New_Staff.Cursor = Cursors.Hand;
            btn_Add_New_Staff.FlatAppearance.BorderSize = 0;
            btn_Add_New_Staff.FlatStyle = FlatStyle.Flat;
            btn_Add_New_Staff.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add_New_Staff.ForeColor = Color.White;
            btn_Add_New_Staff.Image = (Image)resources.GetObject("btn_Add_New_Staff.Image");
            btn_Add_New_Staff.Location = new Point(883, 9);
            btn_Add_New_Staff.Name = "btn_Add_New_Staff";
            btn_Add_New_Staff.Size = new Size(204, 38);
            btn_Add_New_Staff.TabIndex = 15;
            btn_Add_New_Staff.Text = "Add new staff";
            btn_Add_New_Staff.TextAlign = ContentAlignment.MiddleRight;
            btn_Add_New_Staff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add_New_Staff.UseVisualStyleBackColor = false;
            btn_Add_New_Staff.Click += btn_Add_New_Staff_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(150, 33);
            label1.TabIndex = 1;
            label1.Text = "List of Staff";
            // 
            // User_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Grid_Staff);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "User_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)data_Grid_Staff).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_Grid_Staff;
        private Panel panel1;
        private Button btn_Add_New_Staff;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewImageColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}