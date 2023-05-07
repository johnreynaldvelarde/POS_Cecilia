namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Category_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_List_Form));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            btn_Add_Category = new Button();
            label1 = new Label();
            data_Grid_Category = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            Column4 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Category).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Add_Category);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 1;
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
            // btn_Add_Category
            // 
            btn_Add_Category.BackColor = Color.FromArgb(14, 159, 104);
            btn_Add_Category.Cursor = Cursors.Hand;
            btn_Add_Category.FlatAppearance.BorderSize = 0;
            btn_Add_Category.FlatStyle = FlatStyle.Flat;
            btn_Add_Category.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add_Category.ForeColor = Color.White;
            btn_Add_Category.Image = (Image)resources.GetObject("btn_Add_Category.Image");
            btn_Add_Category.Location = new Point(694, 9);
            btn_Add_Category.Name = "btn_Add_Category";
            btn_Add_Category.Size = new Size(199, 38);
            btn_Add_Category.TabIndex = 15;
            btn_Add_Category.Text = "Add new category";
            btn_Add_Category.TextAlign = ContentAlignment.MiddleRight;
            btn_Add_Category.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add_Category.UseVisualStyleBackColor = false;
            btn_Add_Category.Click += btn_Add_Category_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(239, 33);
            label1.TabIndex = 1;
            label1.Text = "List of Categories";
            // 
            // data_Grid_Category
            // 
            data_Grid_Category.AllowUserToAddRows = false;
            data_Grid_Category.AllowUserToOrderColumns = true;
            data_Grid_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Category.BackgroundColor = Color.White;
            data_Grid_Category.BorderStyle = BorderStyle.None;
            data_Grid_Category.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Category.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Grid_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Grid_Category.ColumnHeadersHeight = 40;
            data_Grid_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Category.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Grid_Category.DefaultCellStyle = dataGridViewCellStyle2;
            data_Grid_Category.Dock = DockStyle.Fill;
            data_Grid_Category.EnableHeadersVisualStyles = false;
            data_Grid_Category.Location = new Point(5, 88);
            data_Grid_Category.Name = "data_Grid_Category";
            data_Grid_Category.RowHeadersVisible = false;
            data_Grid_Category.RowHeadersWidth = 50;
            data_Grid_Category.RowTemplate.Height = 25;
            data_Grid_Category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Category.Size = new Size(1088, 492);
            data_Grid_Category.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Category Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "";
            Column4.Name = "Column4";
            // 
            // Category_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Grid_Category);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Category_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Category).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btn_Add_Category;
        private Label label1;
        private DataGridView data_Grid_Category;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private DataGridViewButtonColumn Column4;
    }
}