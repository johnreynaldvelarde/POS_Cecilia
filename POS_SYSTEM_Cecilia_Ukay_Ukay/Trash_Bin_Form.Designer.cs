﻿namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Trash_Bin_Form
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
            panel_center = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btn_Supplier = new Button();
            btn_Staff = new Button();
            btn_Item = new Button();
            btn_Category_List = new Button();
            btn_Product_List = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
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
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "Archive";
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_Supplier);
            panel3.Controls.Add(btn_Staff);
            panel3.Controls.Add(btn_Item);
            panel3.Controls.Add(btn_Category_List);
            panel3.Controls.Add(btn_Product_List);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1080, 60);
            panel3.TabIndex = 23;
            // 
            // btn_Supplier
            // 
            btn_Supplier.BackColor = Color.FromArgb(14, 159, 104);
            btn_Supplier.Cursor = Cursors.Hand;
            btn_Supplier.FlatAppearance.BorderSize = 0;
            btn_Supplier.FlatStyle = FlatStyle.Flat;
            btn_Supplier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Supplier.ForeColor = Color.White;
            btn_Supplier.Location = new Point(749, 11);
            btn_Supplier.Name = "btn_Supplier";
            btn_Supplier.Size = new Size(163, 38);
            btn_Supplier.TabIndex = 20;
            btn_Supplier.Text = "Supplier";
            btn_Supplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Supplier.UseVisualStyleBackColor = false;
            btn_Supplier.Click += btn_Supplier_Click;
            // 
            // btn_Staff
            // 
            btn_Staff.BackColor = Color.FromArgb(14, 159, 104);
            btn_Staff.Cursor = Cursors.Hand;
            btn_Staff.FlatAppearance.BorderSize = 0;
            btn_Staff.FlatStyle = FlatStyle.Flat;
            btn_Staff.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Staff.ForeColor = Color.White;
            btn_Staff.Location = new Point(559, 11);
            btn_Staff.Name = "btn_Staff";
            btn_Staff.Size = new Size(175, 38);
            btn_Staff.TabIndex = 19;
            btn_Staff.Text = "Staff Account";
            btn_Staff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Staff.UseVisualStyleBackColor = false;
            btn_Staff.Click += btn_Staff_Click;
            // 
            // btn_Item
            // 
            btn_Item.BackColor = Color.FromArgb(14, 159, 104);
            btn_Item.Cursor = Cursors.Hand;
            btn_Item.FlatAppearance.BorderSize = 0;
            btn_Item.FlatStyle = FlatStyle.Flat;
            btn_Item.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Item.ForeColor = Color.White;
            btn_Item.Location = new Point(380, 11);
            btn_Item.Name = "btn_Item";
            btn_Item.Size = new Size(163, 38);
            btn_Item.TabIndex = 18;
            btn_Item.Text = "Item";
            btn_Item.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Item.UseVisualStyleBackColor = false;
            btn_Item.Click += btn_Item_Click;
            // 
            // btn_Category_List
            // 
            btn_Category_List.BackColor = Color.FromArgb(14, 159, 104);
            btn_Category_List.Cursor = Cursors.Hand;
            btn_Category_List.FlatAppearance.BorderSize = 0;
            btn_Category_List.FlatStyle = FlatStyle.Flat;
            btn_Category_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Category_List.ForeColor = Color.White;
            btn_Category_List.Location = new Point(200, 11);
            btn_Category_List.Name = "btn_Category_List";
            btn_Category_List.Size = new Size(163, 38);
            btn_Category_List.TabIndex = 17;
            btn_Category_List.Text = "Category";
            btn_Category_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Category_List.UseVisualStyleBackColor = false;
            btn_Category_List.Click += btn_Category_List_Click;
            // 
            // btn_Product_List
            // 
            btn_Product_List.BackColor = Color.FromArgb(14, 159, 104);
            btn_Product_List.Cursor = Cursors.Hand;
            btn_Product_List.FlatAppearance.BorderSize = 0;
            btn_Product_List.FlatStyle = FlatStyle.Flat;
            btn_Product_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Product_List.ForeColor = Color.White;
            btn_Product_List.Location = new Point(12, 11);
            btn_Product_List.Name = "btn_Product_List";
            btn_Product_List.Size = new Size(172, 38);
            btn_Product_List.TabIndex = 16;
            btn_Product_List.Text = "Product ";
            btn_Product_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Product_List.UseVisualStyleBackColor = false;
            btn_Product_List.Click += btn_Product_List_Click;
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
            btnClose.Location = new Point(1044, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
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
            // Trash_Bin_Form
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
            Name = "Trash_Bin_Form";
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
        private Button btn_Category_List;
        public Button btn_Product_List;
        private Panel panel2;
        private Button btnClose;
        private Panel panel1;
        private Button btn_Supplier;
        private Button btn_Staff;
        private Button btn_Item;
    }
}