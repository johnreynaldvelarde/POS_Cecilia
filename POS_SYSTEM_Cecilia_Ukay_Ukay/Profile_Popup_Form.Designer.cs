namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Profile_Popup_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Popup_Form));
            panel1 = new Panel();
            label5 = new Label();
            btn_View_Account = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btn_Sign_Out = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            btn_Close = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_View_Account);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 212);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(146, 99);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 5;
            label5.Text = "Time Remain";
            // 
            // btn_View_Account
            // 
            btn_View_Account.AutoSize = true;
            btn_View_Account.Cursor = Cursors.Hand;
            btn_View_Account.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_View_Account.ForeColor = Color.FromArgb(38, 134, 245);
            btn_View_Account.Location = new Point(146, 130);
            btn_View_Account.Name = "btn_View_Account";
            btn_View_Account.Size = new Size(85, 17);
            btn_View_Account.TabIndex = 4;
            btn_View_Account.Text = "View Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(146, 78);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(244, 246, 241);
            panel3.Controls.Add(btn_Sign_Out);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 35);
            panel3.TabIndex = 2;
            // 
            // btn_Sign_Out
            // 
            btn_Sign_Out.AutoSize = true;
            btn_Sign_Out.Cursor = Cursors.Hand;
            btn_Sign_Out.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sign_Out.Location = new Point(304, 7);
            btn_Sign_Out.Name = "btn_Sign_Out";
            btn_Sign_Out.Size = new Size(64, 20);
            btn_Sign_Out.TabIndex = 0;
            btn_Sign_Out.Text = "Sign out";
            btn_Sign_Out.Click += btn_Sign_Out_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 38);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 0;
            label1.Text = "Administrator Mode";
            // 
            // btn_Close
            // 
            btn_Close.Cursor = Cursors.Hand;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.Location = new Point(350, 2);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(48, 23);
            btn_Close.TabIndex = 6;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Profile_Popup_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 232);
            ControlBox = false;
            Controls.Add(btn_Close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Profile_Popup_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label btn_Sign_Out;
        private Label btn_View_Account;
        private Label label3;
        private Label label5;
        private Button btn_Close;
    }
}