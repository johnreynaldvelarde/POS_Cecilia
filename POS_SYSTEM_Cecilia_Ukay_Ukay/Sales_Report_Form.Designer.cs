﻿namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Sales_Report_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Report_Form));
            label1 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            btn_Category_List = new Button();
            btn_Product_List = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(413, 33);
            label1.TabIndex = 0;
            label1.Text = "Sales Report and Performance";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 3);
            panel2.TabIndex = 20;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1033, -7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 60);
            panel1.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_Category_List);
            panel3.Controls.Add(btn_Product_List);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1080, 60);
            panel3.TabIndex = 21;
            // 
            // btn_Category_List
            // 
            btn_Category_List.BackColor = Color.FromArgb(14, 159, 104);
            btn_Category_List.Cursor = Cursors.Hand;
            btn_Category_List.FlatAppearance.BorderSize = 0;
            btn_Category_List.FlatStyle = FlatStyle.Flat;
            btn_Category_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Category_List.ForeColor = Color.White;
            btn_Category_List.Image = (Image)resources.GetObject("btn_Category_List.Image");
            btn_Category_List.Location = new Point(224, 11);
            btn_Category_List.Name = "btn_Category_List";
            btn_Category_List.Size = new Size(197, 38);
            btn_Category_List.TabIndex = 15;
            btn_Category_List.Text = "Mang Kanor";
            btn_Category_List.TextAlign = ContentAlignment.MiddleRight;
            btn_Category_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Category_List.UseVisualStyleBackColor = false;
            // 
            // btn_Product_List
            // 
            btn_Product_List.BackColor = Color.FromArgb(14, 159, 104);
            btn_Product_List.Cursor = Cursors.Hand;
            btn_Product_List.FlatAppearance.BorderSize = 0;
            btn_Product_List.FlatStyle = FlatStyle.Flat;
            btn_Product_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Product_List.ForeColor = Color.White;
            btn_Product_List.Image = (Image)resources.GetObject("btn_Product_List.Image");
            btn_Product_List.Location = new Point(12, 11);
            btn_Product_List.Name = "btn_Product_List";
            btn_Product_List.Size = new Size(184, 38);
            btn_Product_List.TabIndex = 14;
            btn_Product_List.Text = "BLAHHHH";
            btn_Product_List.TextAlign = ContentAlignment.MiddleRight;
            btn_Product_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Product_List.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 557);
            panel4.TabIndex = 22;
            // 
            // Sales_Report_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Sales_Report_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button btnClose;
        private Panel panel1;
        private Panel panel3;
        private Button btn_Category_List;
        public Button btn_Product_List;
        private Panel panel4;
    }
}