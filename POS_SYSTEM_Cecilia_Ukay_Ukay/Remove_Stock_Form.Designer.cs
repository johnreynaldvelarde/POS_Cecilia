namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Remove_Stock_Form
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
            txt_Quantity = new TextBox();
            label3 = new Label();
            txt_Reduce_Quantity = new TextBox();
            label1 = new Label();
            btn_Clear = new Button();
            btn_Reduce = new Button();
            txt_Item_Code = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            txt_Item_Name = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Cursor = Cursors.Hand;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.Location = new Point(700, 0);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(55, 27);
            btn_Close.TabIndex = 72;
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
            panel2.Size = new Size(735, 3);
            panel2.TabIndex = 74;
            // 
            // title_category
            // 
            title_category.AutoSize = true;
            title_category.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title_category.ForeColor = Color.FromArgb(14, 159, 104);
            title_category.Location = new Point(12, 10);
            title_category.Name = "title_category";
            title_category.Size = new Size(154, 24);
            title_category.TabIndex = 0;
            title_category.Text = "Reduce Stock";
            // 
            // txt_Quantity
            // 
            txt_Quantity.BorderStyle = BorderStyle.FixedSingle;
            txt_Quantity.Enabled = false;
            txt_Quantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Quantity.Location = new Point(173, 129);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.Size = new Size(79, 33);
            txt_Quantity.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(522, 94);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 79;
            label3.Text = "Quantity *";
            // 
            // txt_Reduce_Quantity
            // 
            txt_Reduce_Quantity.BorderStyle = BorderStyle.FixedSingle;
            txt_Reduce_Quantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Reduce_Quantity.Location = new Point(522, 129);
            txt_Reduce_Quantity.Name = "txt_Reduce_Quantity";
            txt_Reduce_Quantity.Size = new Size(200, 33);
            txt_Reduce_Quantity.TabIndex = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 94);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 71;
            label1.Text = "Item Code";
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(71, 81, 86);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(592, 192);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(145, 48);
            btn_Clear.TabIndex = 77;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Reduce
            // 
            btn_Reduce.BackColor = Color.FromArgb(14, 159, 104);
            btn_Reduce.Cursor = Cursors.Hand;
            btn_Reduce.FlatStyle = FlatStyle.Flat;
            btn_Reduce.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Reduce.ForeColor = Color.White;
            btn_Reduce.Location = new Point(431, 192);
            btn_Reduce.Name = "btn_Reduce";
            btn_Reduce.Size = new Size(145, 48);
            btn_Reduce.TabIndex = 76;
            btn_Reduce.Text = "Reduce";
            btn_Reduce.UseVisualStyleBackColor = false;
            btn_Reduce.Click += btn_Reduce_Click;
            // 
            // txt_Item_Code
            // 
            txt_Item_Code.BorderStyle = BorderStyle.FixedSingle;
            txt_Item_Code.Enabled = false;
            txt_Item_Code.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Item_Code.Location = new Point(33, 129);
            txt_Item_Code.Name = "txt_Item_Code";
            txt_Item_Code.Size = new Size(134, 33);
            txt_Item_Code.TabIndex = 75;
            // 
            // panel1
            // 
            panel1.Controls.Add(title_category);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 45);
            panel1.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(288, 94);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 83;
            label2.Text = "Item Name";
            // 
            // txt_Item_Name
            // 
            txt_Item_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Item_Name.Enabled = false;
            txt_Item_Name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Item_Name.Location = new Point(288, 129);
            txt_Item_Name.Name = "txt_Item_Name";
            txt_Item_Name.Size = new Size(200, 33);
            txt_Item_Name.TabIndex = 84;
            // 
            // Remove_Stock_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 246);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(txt_Item_Name);
            Controls.Add(btn_Close);
            Controls.Add(panel2);
            Controls.Add(txt_Quantity);
            Controls.Add(label3);
            Controls.Add(txt_Reduce_Quantity);
            Controls.Add(label1);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Reduce);
            Controls.Add(txt_Item_Code);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Remove_Stock_Form";
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
        public TextBox txt_Quantity;
        public Label label3;
        public TextBox txt_Reduce_Quantity;
        public Label label1;
        private Button btn_Clear;
        public Button btn_Reduce;
        public TextBox txt_Item_Code;
        private Panel panel1;
        public Label label2;
        public TextBox txt_Item_Name;
    }
}