namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class User_Create_Account_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Create_Account_Form));
            btnClose = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            User_Profile = new PictureBox();
            btn_Add_Profile = new Button();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtRetype = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtContact = new TextBox();
            btn_Save = new Button();
            btn_Clear = new Button();
            cmdRole = new ComboBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)User_Profile).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(845, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 11;
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
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 45);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 0;
            label1.Text = "Create new account";
            // 
            // User_Profile
            // 
            User_Profile.BorderStyle = BorderStyle.FixedSingle;
            User_Profile.Location = new Point(54, 96);
            User_Profile.Name = "User_Profile";
            User_Profile.Size = new Size(300, 300);
            User_Profile.SizeMode = PictureBoxSizeMode.StretchImage;
            User_Profile.TabIndex = 16;
            User_Profile.TabStop = false;
            // 
            // btn_Add_Profile
            // 
            btn_Add_Profile.BackColor = Color.FromArgb(14, 159, 104);
            btn_Add_Profile.Cursor = Cursors.Hand;
            btn_Add_Profile.FlatAppearance.BorderSize = 0;
            btn_Add_Profile.FlatStyle = FlatStyle.Flat;
            btn_Add_Profile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add_Profile.ForeColor = Color.White;
            btn_Add_Profile.Image = (Image)resources.GetObject("btn_Add_Profile.Image");
            btn_Add_Profile.Location = new Point(54, 402);
            btn_Add_Profile.Name = "btn_Add_Profile";
            btn_Add_Profile.Size = new Size(300, 38);
            btn_Add_Profile.TabIndex = 17;
            btn_Add_Profile.Text = "Add profile picture";
            btn_Add_Profile.TextAlign = ContentAlignment.MiddleRight;
            btn_Add_Profile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add_Profile.UseVisualStyleBackColor = false;
            btn_Add_Profile.Click += btn_Add_Profile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 96);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 19;
            label2.Text = "Staff Name *";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(424, 131);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 29);
            txtUsername.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(424, 178);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 21;
            label3.Text = "Password *";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(424, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 29);
            txtPassword.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(424, 263);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 23;
            label4.Text = "Retype Password *";
            // 
            // txtRetype
            // 
            txtRetype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRetype.Location = new Point(424, 298);
            txtRetype.Name = "txtRetype";
            txtRetype.Size = new Size(400, 29);
            txtRetype.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(424, 435);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 25;
            label5.Text = "Role *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(424, 350);
            label6.Name = "label6";
            label6.Size = new Size(155, 21);
            label6.TabIndex = 27;
            label6.Text = "Contact Number *";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(424, 385);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(400, 29);
            txtContact.TabIndex = 26;
            txtContact.KeyPress += txtContact_KeyPress;
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
            btn_Save.TabIndex = 28;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
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
            btn_Clear.TabIndex = 29;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // cmdRole
            // 
            cmdRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmdRole.FormattingEnabled = true;
            cmdRole.Items.AddRange(new object[] { "Manager", "Cashier" });
            cmdRole.Location = new Point(424, 470);
            cmdRole.Name = "cmdRole";
            cmdRole.Size = new Size(400, 29);
            cmdRole.TabIndex = 30;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(830, 298);
            button1.Name = "button1";
            button1.Size = new Size(57, 29);
            button1.TabIndex = 31;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // User_Create_Account_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(button1);
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
            Controls.Add(btn_Add_Profile);
            Controls.Add(User_Profile);
            Controls.Add(btnClose);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "User_Create_Account_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)User_Profile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private PictureBox User_Profile;
        private Button btn_Add_Profile;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtRetype;
        private Label label5;
        private Label label6;
        private TextBox txtContact;
        private Button btn_Save;
        private Button btn_Clear;
        private ComboBox cmdRole;
        private Button button1;
    }
}