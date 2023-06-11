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
            popup_role = new Label();
            label1 = new Label();
            popup_picture = new CircularPictureBox();
            label5 = new Label();
            popup_staff_name = new Label();
            panel3 = new Panel();
            btn_Sign_Out = new Label();
            panel2 = new Panel();
            lblupper_role = new Label();
            btn_Close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)popup_picture).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(popup_role);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(popup_picture);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(popup_staff_name);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 212);
            panel1.TabIndex = 0;
            // 
            // popup_role
            // 
            popup_role.AutoSize = true;
            popup_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            popup_role.ForeColor = Color.FromArgb(234, 67, 53);
            popup_role.Location = new Point(207, 116);
            popup_role.Name = "popup_role";
            popup_role.Size = new Size(44, 21);
            popup_role.TabIndex = 8;
            popup_role.Text = "Role:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 78);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // popup_picture
            // 
            popup_picture.Image = (Image)resources.GetObject("popup_picture.Image");
            popup_picture.Location = new Point(24, 58);
            popup_picture.Name = "popup_picture";
            popup_picture.Size = new Size(103, 103);
            popup_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            popup_picture.TabIndex = 6;
            popup_picture.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(146, 116);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 5;
            label5.Text = "Role:";
            // 
            // popup_staff_name
            // 
            popup_staff_name.AutoSize = true;
            popup_staff_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            popup_staff_name.Location = new Point(207, 78);
            popup_staff_name.Name = "popup_staff_name";
            popup_staff_name.Size = new Size(52, 21);
            popup_staff_name.TabIndex = 3;
            popup_staff_name.Text = "Name";
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
            // panel2
            // 
            panel2.Controls.Add(lblupper_role);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 38);
            panel2.TabIndex = 0;
            // 
            // lblupper_role
            // 
            lblupper_role.AutoSize = true;
            lblupper_role.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblupper_role.ForeColor = Color.FromArgb(14, 159, 104);
            lblupper_role.Location = new Point(8, 10);
            lblupper_role.Name = "lblupper_role";
            lblupper_role.Size = new Size(152, 18);
            lblupper_role.TabIndex = 0;
            lblupper_role.Text = "Administrator Mode";
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
            ((System.ComponentModel.ISupportInitialize)popup_picture).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label btn_Sign_Out;
        private Label label5;
        private Button btn_Close;
        public Label popup_staff_name;
        public CircularPictureBox popup_picture;
        public Label lblupper_role;
        public Label label1;
        public Label popup_role;
    }
}