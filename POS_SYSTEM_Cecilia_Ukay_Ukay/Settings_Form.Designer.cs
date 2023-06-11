namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Settings_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Form));
            label1 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            panel_cent = new Panel();
            radioButton1 = new RadioButton();
            btn_Apply = new Button();
            setting_date = new Label();
            setting_time = new Label();
            btn_Change_DateTime = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel_cent.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(215, 33);
            label1.TabIndex = 0;
            label1.Text = "System Settings";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 3);
            panel2.TabIndex = 16;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1034, -9);
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
            panel1.TabIndex = 15;
            // 
            // panel_cent
            // 
            panel_cent.Controls.Add(radioButton1);
            panel_cent.Controls.Add(btn_Apply);
            panel_cent.Controls.Add(setting_date);
            panel_cent.Controls.Add(setting_time);
            panel_cent.Controls.Add(btn_Change_DateTime);
            panel_cent.Controls.Add(label6);
            panel_cent.Controls.Add(label5);
            panel_cent.Controls.Add(label4);
            panel_cent.Controls.Add(label3);
            panel_cent.Controls.Add(label2);
            panel_cent.Dock = DockStyle.Fill;
            panel_cent.Location = new Point(10, 73);
            panel_cent.Name = "panel_cent";
            panel_cent.Size = new Size(1080, 617);
            panel_cent.TabIndex = 19;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(204, 342);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 25);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btn_Apply
            // 
            btn_Apply.BackColor = Color.FromArgb(14, 159, 104);
            btn_Apply.Cursor = Cursors.Hand;
            btn_Apply.FlatAppearance.BorderSize = 0;
            btn_Apply.FlatStyle = FlatStyle.Flat;
            btn_Apply.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Apply.ForeColor = Color.White;
            btn_Apply.Image = (Image)resources.GetObject("btn_Apply.Image");
            btn_Apply.Location = new Point(204, 401);
            btn_Apply.Name = "btn_Apply";
            btn_Apply.Size = new Size(228, 38);
            btn_Apply.TabIndex = 26;
            btn_Apply.Text = " Apply the changes";
            btn_Apply.TextAlign = ContentAlignment.MiddleRight;
            btn_Apply.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Apply.UseVisualStyleBackColor = false;
            // 
            // setting_date
            // 
            setting_date.AutoSize = true;
            setting_date.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            setting_date.ForeColor = Color.Black;
            setting_date.Location = new Point(276, 141);
            setting_date.Name = "setting_date";
            setting_date.Size = new Size(61, 24);
            setting_date.TabIndex = 25;
            setting_date.Text = "Time:";
            // 
            // setting_time
            // 
            setting_time.AutoSize = true;
            setting_time.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            setting_time.ForeColor = Color.Black;
            setting_time.Location = new Point(276, 91);
            setting_time.Name = "setting_time";
            setting_time.Size = new Size(61, 24);
            setting_time.TabIndex = 24;
            setting_time.Text = "Time:";
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
            btn_Change_DateTime.Location = new Point(204, 186);
            btn_Change_DateTime.Name = "btn_Change_DateTime";
            btn_Change_DateTime.Size = new Size(228, 38);
            btn_Change_DateTime.TabIndex = 23;
            btn_Change_DateTime.Text = " Adjust date and time";
            btn_Change_DateTime.TextAlign = ContentAlignment.MiddleRight;
            btn_Change_DateTime.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Change_DateTime.UseVisualStyleBackColor = false;
            btn_Change_DateTime.Click += btn_Change_DateTime_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(204, 141);
            label6.Name = "label6";
            label6.Size = new Size(66, 24);
            label6.TabIndex = 19;
            label6.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(204, 91);
            label5.Name = "label5";
            label5.Size = new Size(61, 24);
            label5.TabIndex = 18;
            label5.Text = "Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(14, 159, 104);
            label4.Location = new Point(12, 471);
            label4.Name = "label4";
            label4.Size = new Size(325, 33);
            label4.TabIndex = 17;
            label4.Text = "Change data grid view";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 276);
            label3.Name = "label3";
            label3.Size = new Size(325, 33);
            label3.TabIndex = 16;
            label3.Text = "Change data grid view";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(322, 33);
            label2.TabIndex = 15;
            label2.Text = "Change date and time";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Settings_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            ControlBox = false;
            Controls.Add(panel_cent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Settings_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Settings_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_cent.ResumeLayout(false);
            panel_cent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button btnClose;
        private Panel panel1;
        private Panel panel_cent;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label setting_date;
        private Label setting_time;
        private Button btn_Change_DateTime;
        private System.Windows.Forms.Timer timer1;
        private Button btn_Apply;
        private RadioButton radioButton1;
    }
}