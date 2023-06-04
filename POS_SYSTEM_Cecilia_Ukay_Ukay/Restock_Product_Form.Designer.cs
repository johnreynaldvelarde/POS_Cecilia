namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Restock_Product_Form
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
            btn_Close = new Button();
            panel2 = new Panel();
            title_category = new Label();
            btn_Clear = new Button();
            btn_Restock = new Button();
            txt_Category = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            cmd_Stock = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Cursor = Cursors.Hand;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.Location = new Point(634, 0);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(55, 27);
            btn_Close.TabIndex = 50;
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
            panel2.Size = new Size(669, 3);
            panel2.TabIndex = 52;
            // 
            // title_category
            // 
            title_category.AutoSize = true;
            title_category.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title_category.ForeColor = Color.FromArgb(14, 159, 104);
            title_category.Location = new Point(12, 10);
            title_category.Name = "title_category";
            title_category.Size = new Size(177, 24);
            title_category.TabIndex = 0;
            title_category.Text = "Restock Product";
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(71, 81, 86);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(531, 185);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(145, 48);
            btn_Clear.TabIndex = 55;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Restock
            // 
            btn_Restock.BackColor = Color.FromArgb(14, 159, 104);
            btn_Restock.Cursor = Cursors.Hand;
            btn_Restock.FlatStyle = FlatStyle.Flat;
            btn_Restock.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Restock.ForeColor = Color.White;
            btn_Restock.Location = new Point(370, 185);
            btn_Restock.Name = "btn_Restock";
            btn_Restock.Size = new Size(145, 48);
            btn_Restock.TabIndex = 54;
            btn_Restock.Text = "Restock";
            btn_Restock.UseVisualStyleBackColor = false;
            btn_Restock.Click += btn_Restock_Click;
            // 
            // txt_Category
            // 
            txt_Category.BorderStyle = BorderStyle.FixedSingle;
            txt_Category.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Category.Location = new Point(22, 122);
            txt_Category.Name = "txt_Category";
            txt_Category.Size = new Size(200, 33);
            txt_Category.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.Controls.Add(title_category);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 45);
            panel1.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 87);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(248, 87);
            label2.Name = "label2";
            label2.Size = new Size(190, 21);
            label2.TabIndex = 56;
            label2.Text = "Select available stock *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(471, 87);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 58;
            label3.Text = "Quantity *";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(471, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 33);
            textBox2.TabIndex = 59;
            // 
            // cmd_Stock
            // 
            cmd_Stock.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_Stock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_Stock.FormattingEnabled = true;
            cmd_Stock.Location = new Point(248, 122);
            cmd_Stock.Name = "cmd_Stock";
            cmd_Stock.Size = new Size(200, 33);
            cmd_Stock.TabIndex = 69;
            // 
            // Restock_Product_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 246);
            ControlBox = false;
            Controls.Add(cmd_Stock);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Close);
            Controls.Add(panel2);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Restock);
            Controls.Add(txt_Category);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Restock_Product_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Close;
        private Panel panel2;
        public Label title_category;
        private Button btn_Clear;
        public Button btn_Restock;
        public TextBox txt_Category;
        private Panel panel1;
        public Label label1;
        public Label label2;
        public Label label3;
        public TextBox textBox2;
        private ComboBox cmd_Stock;
    }
}