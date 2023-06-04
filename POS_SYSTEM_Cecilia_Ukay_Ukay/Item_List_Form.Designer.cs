namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Item_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_List_Form));
            data_Grid_Item = new DataGridView();
            panel1 = new Panel();
            btn_Export = new Button();
            btn_Add_Item = new Button();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Item).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // data_Grid_Item
            // 
            data_Grid_Item.AllowUserToAddRows = false;
            data_Grid_Item.AllowUserToOrderColumns = true;
            data_Grid_Item.AllowUserToResizeColumns = false;
            data_Grid_Item.AllowUserToResizeRows = false;
            data_Grid_Item.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Item.BackgroundColor = Color.White;
            data_Grid_Item.BorderStyle = BorderStyle.None;
            data_Grid_Item.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Item.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Grid_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Grid_Item.ColumnHeadersHeight = 50;
            data_Grid_Item.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Item.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column7, Column2, Column6, Column3, Column5, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Grid_Item.DefaultCellStyle = dataGridViewCellStyle2;
            data_Grid_Item.Dock = DockStyle.Fill;
            data_Grid_Item.EnableHeadersVisualStyles = false;
            data_Grid_Item.Location = new Point(5, 88);
            data_Grid_Item.Name = "data_Grid_Item";
            data_Grid_Item.ReadOnly = true;
            data_Grid_Item.RowHeadersVisible = false;
            data_Grid_Item.RowHeadersWidth = 50;
            data_Grid_Item.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Item.RowTemplate.Height = 40;
            data_Grid_Item.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Item.Size = new Size(1088, 492);
            data_Grid_Item.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Export);
            panel1.Controls.Add(btn_Add_Item);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 3;
            // 
            // btn_Export
            // 
            btn_Export.BackColor = Color.FromArgb(14, 159, 104);
            btn_Export.Cursor = Cursors.Hand;
            btn_Export.FlatAppearance.BorderSize = 0;
            btn_Export.FlatStyle = FlatStyle.Flat;
            btn_Export.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Export.ForeColor = Color.White;
            btn_Export.Image = (Image)resources.GetObject("btn_Export.Image");
            btn_Export.Location = new Point(908, 9);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(159, 38);
            btn_Export.TabIndex = 16;
            btn_Export.Text = "Excel Export";
            btn_Export.TextAlign = ContentAlignment.MiddleRight;
            btn_Export.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Export.UseVisualStyleBackColor = false;
            // 
            // btn_Add_Item
            // 
            btn_Add_Item.BackColor = Color.FromArgb(14, 159, 104);
            btn_Add_Item.Cursor = Cursors.Hand;
            btn_Add_Item.FlatAppearance.BorderSize = 0;
            btn_Add_Item.FlatStyle = FlatStyle.Flat;
            btn_Add_Item.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add_Item.ForeColor = Color.White;
            btn_Add_Item.Image = (Image)resources.GetObject("btn_Add_Item.Image");
            btn_Add_Item.Location = new Point(708, 9);
            btn_Add_Item.Name = "btn_Add_Item";
            btn_Add_Item.Size = new Size(185, 38);
            btn_Add_Item.TabIndex = 15;
            btn_Add_Item.Text = "Add new item";
            btn_Add_Item.TextAlign = ContentAlignment.MiddleRight;
            btn_Add_Item.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add_Item.UseVisualStyleBackColor = false;
            btn_Add_Item.Click += btn_Add_Item_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(153, 33);
            label1.TabIndex = 1;
            label1.Text = "List of Item";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 54.53607F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Item_ID";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Item Code";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 132.783478F;
            Column2.HeaderText = "Item Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.FillWeight = 90.89347F;
            Column6.HeaderText = "Price";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 90.89347F;
            Column3.HeaderText = "Per Piece";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 90.89347F;
            Column5.HeaderText = "Date Added";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
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
            // Item_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Grid_Item);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Item_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)data_Grid_Item).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_Grid_Item;
        private Panel panel1;
        private Button btn_Export;
        private Button btn_Add_Item;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}