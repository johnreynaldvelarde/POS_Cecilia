namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Delete_Item_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Item_List_Form));
            panel1 = new Panel();
            label1 = new Label();
            data_Delete_Item = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Item_ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Restore = new DataGridViewImageColumn();
            Total_Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Delete_Item).BeginInit();
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
            // data_Delete_Item
            // 
            data_Delete_Item.AllowUserToAddRows = false;
            data_Delete_Item.AllowUserToOrderColumns = true;
            data_Delete_Item.AllowUserToResizeColumns = false;
            data_Delete_Item.AllowUserToResizeRows = false;
            data_Delete_Item.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Delete_Item.BackgroundColor = Color.White;
            data_Delete_Item.BorderStyle = BorderStyle.None;
            data_Delete_Item.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Delete_Item.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Delete_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Delete_Item.ColumnHeadersHeight = 50;
            data_Delete_Item.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Delete_Item.Columns.AddRange(new DataGridViewColumn[] { Column1, Item_ID, Column2, Column5, Restore, Total_Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Delete_Item.DefaultCellStyle = dataGridViewCellStyle2;
            data_Delete_Item.Dock = DockStyle.Fill;
            data_Delete_Item.EnableHeadersVisualStyles = false;
            data_Delete_Item.Location = new Point(5, 88);
            data_Delete_Item.Name = "data_Delete_Item";
            data_Delete_Item.ReadOnly = true;
            data_Delete_Item.RowHeadersVisible = false;
            data_Delete_Item.RowHeadersWidth = 50;
            data_Delete_Item.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Delete_Item.RowTemplate.Height = 40;
            data_Delete_Item.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Delete_Item.Size = new Size(1088, 492);
            data_Delete_Item.TabIndex = 7;
            data_Delete_Item.CellContentClick += data_Delete_Item_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 108.199493F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Item_ID
            // 
            Item_ID.HeaderText = "Item_ID";
            Item_ID.Name = "Item_ID";
            Item_ID.ReadOnly = true;
            Item_ID.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 149.594437F;
            Column2.HeaderText = "Item Name";
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
            // Delete_Item_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Delete_Item);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Delete_Item_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Delete_Item).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView data_Delete_Item;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Item_ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Restore;
        private DataGridViewImageColumn Total_Delete;
    }
}