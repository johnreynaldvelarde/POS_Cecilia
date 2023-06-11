namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Login_Form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            btnClear = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            btnClose = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label_date = new Label();
            label_time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_Change_DateTime = new Button();
            passhide1 = new CheckBox();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(448, 374);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(300, 48);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(14, 159, 104);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(448, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 48);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(448, 209);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 13;
            label2.Text = "Password *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(448, 105);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 11;
            label1.Text = "Staff Name*";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(448, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 29);
            txtUsername.TabIndex = 10;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(745, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 600);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 600);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(425, 479);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 18;
            label3.Text = "Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(425, 507);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 19;
            label4.Text = "Time :";
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_date.Location = new Point(479, 479);
            label_date.Name = "label_date";
            label_date.Size = new Size(48, 17);
            label_date.TabIndex = 20;
            label_date.Text = "Date :";
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_time.Location = new Point(479, 507);
            label_time.Name = "label_time";
            label_time.Size = new Size(45, 17);
            label_time.TabIndex = 21;
            label_time.Text = "Time :";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btn_Change_DateTime
            // 
            btn_Change_DateTime.BackColor = Color.FromArgb(14, 159, 104);
            btn_Change_DateTime.Cursor = Cursors.Hand;
            btn_Change_DateTime.FlatAppearance.BorderSize = 0;
            btn_Change_DateTime.FlatStyle = FlatStyle.Flat;
            btn_Change_DateTime.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Change_DateTime.ForeColor = Color.White;
            btn_Change_DateTime.Image = (Image)resources.GetObject("btn_Change_DateTime.Image");
            btn_Change_DateTime.Location = new Point(425, 536);
            btn_Change_DateTime.Name = "btn_Change_DateTime";
            btn_Change_DateTime.Size = new Size(228, 38);
            btn_Change_DateTime.TabIndex = 22;
            btn_Change_DateTime.Text = "  Change date and time";
            btn_Change_DateTime.TextAlign = ContentAlignment.MiddleRight;
            btn_Change_DateTime.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Change_DateTime.UseVisualStyleBackColor = false;
            btn_Change_DateTime.Click += btn_Change_DateTime_Click;
            // 
            // passhide1
            // 
            passhide1.Appearance = Appearance.Button;
            passhide1.AutoSize = true;
            passhide1.Cursor = Cursors.Hand;
            passhide1.FlatAppearance.BorderSize = 0;
            passhide1.FlatStyle = FlatStyle.Flat;
            passhide1.Image = (Image)resources.GetObject("passhide1.Image");
            passhide1.Location = new Point(754, 243);
            passhide1.Name = "passhide1";
            passhide1.Size = new Size(30, 30);
            passhide1.TabIndex = 33;
            passhide1.UseVisualStyleBackColor = true;
            passhide1.CheckedChanged += passhide1_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(448, 244);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 29);
            txtPassword.TabIndex = 34;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            ControlBox = false;
            Controls.Add(txtPassword);
            Controls.Add(passhide1);
            Controls.Add(btn_Change_DateTime);
            Controls.Add(label_time);
            Controls.Add(label_date);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Form_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private Button btnClose;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label_date;
        private Label label_time;
        private System.Windows.Forms.Timer timer1;
        private Button btn_Change_DateTime;
        private CheckBox passhide1;
        public TextBox txtPassword;
    }
}