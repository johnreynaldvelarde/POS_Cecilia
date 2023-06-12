namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Add_New_Supplier_Form
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
            btn_Clear = new Button();
            btn_Save = new Button();
            label6 = new Label();
            txt_Email = new TextBox();
            label4 = new Label();
            txt_Contact_Number = new TextBox();
            label3 = new Label();
            txt_Address = new TextBox();
            label2 = new Label();
            label_title_supplier = new Label();
            txt_Supplier_Name = new TextBox();
            btnClose = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btn_Update = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btn_Clear.TabIndex = 48;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
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
            btn_Save.TabIndex = 47;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(258, 379);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 46;
            label6.Text = "Email Address *";
            // 
            // txt_Email
            // 
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Email.Location = new Point(258, 414);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(400, 29);
            txt_Email.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(258, 292);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 43;
            label4.Text = "Contact Number*";
            // 
            // txt_Contact_Number
            // 
            txt_Contact_Number.BorderStyle = BorderStyle.FixedSingle;
            txt_Contact_Number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contact_Number.Location = new Point(258, 327);
            txt_Contact_Number.Name = "txt_Contact_Number";
            txt_Contact_Number.Size = new Size(400, 29);
            txt_Contact_Number.TabIndex = 42;
            txt_Contact_Number.KeyPress += txt_Contact_Number_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(258, 207);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 41;
            label3.Text = "Location Address *";
            // 
            // txt_Address
            // 
            txt_Address.BorderStyle = BorderStyle.FixedSingle;
            txt_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Address.Location = new Point(258, 242);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(400, 29);
            txt_Address.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(258, 125);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 39;
            label2.Text = "Supplier Name *";
            // 
            // label_title_supplier
            // 
            label_title_supplier.AutoSize = true;
            label_title_supplier.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_title_supplier.ForeColor = Color.FromArgb(14, 159, 104);
            label_title_supplier.Location = new Point(12, 10);
            label_title_supplier.Name = "label_title_supplier";
            label_title_supplier.Size = new Size(187, 24);
            label_title_supplier.TabIndex = 0;
            label_title_supplier.Text = "Add new supplier";
            // 
            // txt_Supplier_Name
            // 
            txt_Supplier_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Supplier_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Supplier_Name.Location = new Point(258, 160);
            txt_Supplier_Name.Name = "txt_Supplier_Name";
            txt_Supplier_Name.Size = new Size(400, 29);
            txt_Supplier_Name.TabIndex = 38;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(845, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 3);
            panel2.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_title_supplier);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 45);
            panel1.TabIndex = 34;
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
            btn_Update.TabIndex = 95;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // Add_New_Supplier_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(btn_Update);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(label6);
            Controls.Add(txt_Email);
            Controls.Add(label4);
            Controls.Add(txt_Contact_Number);
            Controls.Add(label3);
            Controls.Add(txt_Address);
            Controls.Add(label2);
            Controls.Add(txt_Supplier_Name);
            Controls.Add(btnClose);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_New_Supplier_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Clear;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private Panel panel2;
        private Panel panel1;
        public Button btn_Update;
        public TextBox txt_Email;
        public TextBox txt_Contact_Number;
        public TextBox txt_Address;
        public Label label_title_supplier;
        public TextBox txt_Supplier_Name;
        public Button btn_Save;
    }
}