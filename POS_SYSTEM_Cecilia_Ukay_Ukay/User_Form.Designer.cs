namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Form));
            label1 = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_Supplier_List = new Button();
            btn_Staff_List = new Button();
            panel_center = new Panel();
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
            label1.Size = new Size(258, 33);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1045, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 10;
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
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 3);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_Supplier_List);
            panel3.Controls.Add(btn_Staff_List);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1080, 60);
            panel3.TabIndex = 13;
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
            btn_Supplier_List.Location = new Point(226, 11);
            btn_Supplier_List.Name = "btn_Supplier_List";
            btn_Supplier_List.Size = new Size(197, 38);
            btn_Supplier_List.TabIndex = 17;
            btn_Supplier_List.Text = "List of Supplier";
            btn_Supplier_List.TextAlign = ContentAlignment.MiddleRight;
            btn_Supplier_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Supplier_List.UseVisualStyleBackColor = false;
            btn_Supplier_List.Click += btn_Supplier_List_Click;
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
            btn_Staff_List.Size = new Size(197, 38);
            btn_Staff_List.TabIndex = 16;
            btn_Staff_List.Text = "List of Staff";
            btn_Staff_List.TextAlign = ContentAlignment.MiddleRight;
            btn_Staff_List.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Staff_List.UseVisualStyleBackColor = false;
            btn_Staff_List.Click += btn_Employee_List_Click;
            // 
            // panel_center
            // 
            panel_center.Dock = DockStyle.Fill;
            panel_center.Location = new Point(10, 133);
            panel_center.Name = "panel_center";
            panel_center.Size = new Size(1080, 557);
            panel_center.TabIndex = 19;
            // 
            // User_Form
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
            Name = "User_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_Supplier_List;
        public Button btn_Staff_List;
        private Panel panel_center;
    }
}