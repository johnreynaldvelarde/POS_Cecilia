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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Supplier_Form));
            passhide1 = new CheckBox();
            passhide2 = new CheckBox();
            cmdRole = new ComboBox();
            btn_Clear = new Button();
            btn_Save = new Button();
            label6 = new Label();
            txtContact = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtRetype = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            btnClose = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passhide1
            // 
            passhide1.Appearance = Appearance.Button;
            passhide1.AutoSize = true;
            passhide1.Cursor = Cursors.Hand;
            passhide1.FlatAppearance.BorderSize = 0;
            passhide1.FlatStyle = FlatStyle.Flat;
            passhide1.Image = (Image)resources.GetObject("passhide1.Image");
            passhide1.Location = new Point(646, 208);
            passhide1.Name = "passhide1";
            passhide1.Size = new Size(30, 30);
            passhide1.TabIndex = 51;
            passhide1.UseVisualStyleBackColor = true;
            // 
            // passhide2
            // 
            passhide2.Appearance = Appearance.Button;
            passhide2.AutoSize = true;
            passhide2.Cursor = Cursors.Hand;
            passhide2.FlatAppearance.BorderSize = 0;
            passhide2.FlatStyle = FlatStyle.Flat;
            passhide2.Image = (Image)resources.GetObject("passhide2.Image");
            passhide2.Location = new Point(646, 293);
            passhide2.Name = "passhide2";
            passhide2.Size = new Size(30, 30);
            passhide2.TabIndex = 50;
            passhide2.UseVisualStyleBackColor = true;
            // 
            // cmdRole
            // 
            cmdRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmdRole.FormattingEnabled = true;
            cmdRole.Items.AddRange(new object[] { "Manager", "Cashier" });
            cmdRole.Location = new Point(240, 466);
            cmdRole.Name = "cmdRole";
            cmdRole.Size = new Size(400, 29);
            cmdRole.TabIndex = 49;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(71, 81, 86);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(742, 539);
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
            btn_Save.Location = new Point(590, 539);
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
            label6.Location = new Point(240, 346);
            label6.Name = "label6";
            label6.Size = new Size(155, 21);
            label6.TabIndex = 46;
            label6.Text = "Contact Number *";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(240, 381);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(400, 29);
            txtContact.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(240, 431);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 44;
            label5.Text = "Role *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(240, 259);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 43;
            label4.Text = "Retype Password *";
            // 
            // txtRetype
            // 
            txtRetype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRetype.Location = new Point(240, 294);
            txtRetype.Multiline = true;
            txtRetype.Name = "txtRetype";
            txtRetype.PasswordChar = '●';
            txtRetype.Size = new Size(400, 29);
            txtRetype.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(240, 174);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 41;
            label3.Text = "Password *";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(240, 209);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(400, 29);
            txtPassword.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(240, 92);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 39;
            label2.Text = "Supplier Name *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(187, 24);
            label1.TabIndex = 0;
            label1.Text = "Add new supplier";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(240, 127);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 29);
            txtUsername.TabIndex = 38;
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
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 45);
            panel1.TabIndex = 34;
            // 
            // Add_New_Supplier_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(passhide1);
            Controls.Add(passhide2);
            Controls.Add(cmdRole);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(label6);
            Controls.Add(txtContact);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRetype);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
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

        private CheckBox passhide1;
        private CheckBox passhide2;
        private ComboBox cmdRole;
        private Button btn_Clear;
        private Button btn_Save;
        private Label label6;
        private TextBox txtContact;
        private Label label5;
        private Label label4;
        private TextBox txtRetype;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private Button btnClose;
        private Panel panel2;
        private Panel panel1;
    }
}