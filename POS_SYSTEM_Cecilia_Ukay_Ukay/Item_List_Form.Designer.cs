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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_List_Form));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            btn_Add_Item = new Button();
            label1 = new Label();
            panel2 = new Panel();
            data_Grid_Item = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewImageColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Item).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Add_Item);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1090, 68);
            panel1.TabIndex = 2;
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
            // btn_Add_Item
            // 
            btn_Add_Item.BackColor = Color.FromArgb(14, 159, 104);
            btn_Add_Item.Cursor = Cursors.Hand;
            btn_Add_Item.FlatAppearance.BorderSize = 0;
            btn_Add_Item.FlatStyle = FlatStyle.Flat;
            btn_Add_Item.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add_Item.ForeColor = Color.White;
            btn_Add_Item.Image = (Image)resources.GetObject("btn_Add_Item.Image");
            btn_Add_Item.Location = new Point(706, 9);
            btn_Add_Item.Name = "btn_Add_Item";
            btn_Add_Item.Size = new Size(187, 38);
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
            label1.Size = new Size(163, 33);
            label1.TabIndex = 1;
            label1.Text = "List of Items";
            // 
            // panel2
            // 
            panel2.Controls.Add(data_Grid_Item);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1090, 494);
            panel2.TabIndex = 3;
            // 
            // data_Grid_Item
            // 
            data_Grid_Item.AllowUserToAddRows = false;
            data_Grid_Item.AllowUserToOrderColumns = true;
            data_Grid_Item.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Item.BackgroundColor = Color.White;
            data_Grid_Item.BorderStyle = BorderStyle.None;
            data_Grid_Item.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Item.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Grid_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Grid_Item.ColumnHeadersHeight = 40;
            data_Grid_Item.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Item.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            data_Grid_Item.DefaultCellStyle = dataGridViewCellStyle4;
            data_Grid_Item.Dock = DockStyle.Fill;
            data_Grid_Item.EnableHeadersVisualStyles = false;
            data_Grid_Item.Location = new Point(0, 0);
            data_Grid_Item.Name = "data_Grid_Item";
            data_Grid_Item.RowHeadersVisible = false;
            data_Grid_Item.RowHeadersWidth = 50;
            data_Grid_Item.RowTemplate.Height = 25;
            data_Grid_Item.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Item.Size = new Size(1090, 494);
            data_Grid_Item.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Product Image";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Product Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Description";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Quantity";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Category";
            Column6.Name = "Column6";
            // 
            // Item_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 587);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Item_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Grid_Item).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Button btn_Add_Item;
        private Label label1;
        private Panel panel2;
        private DataGridView data_Grid_Item;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewImageColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}