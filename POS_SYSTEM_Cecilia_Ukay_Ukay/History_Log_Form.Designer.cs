﻿namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class History_Log_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Log_Form));
            panel_center = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btn_Supplier_List = new Button();
            btn_Staff_List = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_center
            // 
            panel_center.Dock = DockStyle.Fill;
            panel_center.Location = new Point(10, 133);
            panel_center.Name = "panel_center";
            panel_center.Size = new Size(1080, 557);
            panel_center.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(155, 33);
            label1.TabIndex = 0;
            label1.Text = "History Log";
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btn_Supplier_List);
            panel3.Controls.Add(btn_Staff_List);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1080, 60);
            panel3.TabIndex = 23;
            // 
            // btn_Supplier_List
            // 
            btn_Supplier_List.BackColor = Color.FromArgb(14, 159, 104);
            btn_Supplier_List.Cursor = Cursors.Hand;
            btn_Supplier_List.FlatAppearance.BorderSize = 0;
            btn_Supplier_List.FlatStyle = FlatStyle.Flat;
            btn_Supplier_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Supplier_List.ForeColor = Color.White;
            btn_Supplier_List.Image = (Image)resources.GetObject("btn_Supplier_List.Image");
            btn_Supplier_List.Location = new Point(279, 11);
            btn_Supplier_List.Name = "btn_Supplier_List";
            btn_Supplier_List.Size = new Size(227, 38);
            btn_Supplier_List.TabIndex = 17;
            btn_Supplier_List.Text = "Order Transaction";
            btn_Supplier_List.TextAlign = ContentAlignment.MiddleRight;
            btn_Supplier_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Supplier_List.UseVisualStyleBackColor = false;
            // 
            // btn_Staff_List
            // 
            btn_Staff_List.BackColor = Color.FromArgb(14, 159, 104);
            btn_Staff_List.Cursor = Cursors.Hand;
            btn_Staff_List.FlatAppearance.BorderSize = 0;
            btn_Staff_List.FlatStyle = FlatStyle.Flat;
            btn_Staff_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Staff_List.ForeColor = Color.White;
            btn_Staff_List.Image = (Image)resources.GetObject("btn_Staff_List.Image");
            btn_Staff_List.Location = new Point(12, 11);
            btn_Staff_List.Name = "btn_Staff_List";
            btn_Staff_List.Size = new Size(249, 38);
            btn_Staff_List.TabIndex = 16;
            btn_Staff_List.Text = "Management Transaction";
            btn_Staff_List.TextAlign = ContentAlignment.MiddleRight;
            btn_Staff_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Staff_List.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 3);
            panel2.TabIndex = 22;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1044, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 60);
            panel1.TabIndex = 21;
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
            button1.Location = new Point(523, 11);
            button1.Name = "button1";
            button1.Size = new Size(184, 38);
            button1.TabIndex = 18;
            button1.Text = "Activity Log";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // History_Log_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            ControlBox = false;
            Controls.Add(panel_center);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "History_Log_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_center;
        private Label label1;
        private Panel panel3;
        private Button btn_Supplier_List;
        public Button btn_Staff_List;
        private Panel panel2;
        private Button btnClose;
        private Panel panel1;
        private Button button1;
    }
}