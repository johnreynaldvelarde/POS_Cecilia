﻿namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Purchase_Order_Form
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
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            cmd_Category = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            btn_Close = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            btn_Update = new Button();
            btn_Clear = new Button();
            btn_Save = new Button();
            panel1 = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 46);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 40;
            label2.Text = "Select a Supplier ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 103);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 41;
            label1.Text = "Select a Supplier ";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(187, 44);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 29);
            txtUsername.TabIndex = 42;
            // 
            // cmd_Category
            // 
            cmd_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_Category.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_Category.FormattingEnabled = true;
            cmd_Category.Location = new Point(187, 101);
            cmd_Category.Name = "cmd_Category";
            cmd_Category.Size = new Size(400, 28);
            cmd_Category.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(187, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 29);
            textBox1.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 158);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 49;
            label3.Text = "Date Created";
            // 
            // btn_Close
            // 
            btn_Close.Cursor = Cursors.Hand;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.Location = new Point(845, 1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(55, 27);
            btn_Close.TabIndex = 36;
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
            panel2.Size = new Size(880, 3);
            panel2.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 45);
            panel3.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(14, 159, 104);
            label4.Location = new Point(12, 10);
            label4.Name = "label4";
            label4.Size = new Size(222, 24);
            label4.TabIndex = 0;
            label4.Text = "New Purchase Order";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cmd_Category);
            panel4.Controls.Add(txtUsername);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 227);
            panel4.TabIndex = 39;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(14, 159, 104);
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(587, 543);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(145, 48);
            btn_Update.TabIndex = 97;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(71, 81, 86);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(745, 543);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(145, 48);
            btn_Clear.TabIndex = 96;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(14, 159, 104);
            btn_Save.Cursor = Cursors.Hand;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(426, 543);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(145, 48);
            btn_Save.TabIndex = 95;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 285);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 234);
            panel1.TabIndex = 98;
            // 
            // Purchase_Order_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btn_Update);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(panel4);
            Controls.Add(btn_Close);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Purchase_Order_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private ComboBox cmd_Category;
        private TextBox textBox1;
        private Label label3;
        private Button btn_Close;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        public Button btn_Update;
        private Button btn_Clear;
        private Button btn_Save;
        private Panel panel1;
    }
}