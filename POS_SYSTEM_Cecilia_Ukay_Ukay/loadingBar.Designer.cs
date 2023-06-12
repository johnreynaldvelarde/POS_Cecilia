namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class loadingBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadingBar));
            panel1 = new Panel();
            label_logo = new Label();
            progressPanel = new Panel();
            time01 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 241, 247);
            panel1.Controls.Add(label_logo);
            panel1.Controls.Add(progressPanel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 28);
            panel1.TabIndex = 0;
            // 
            // label_logo
            // 
            label_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_logo.AutoSize = true;
            label_logo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_logo.Location = new Point(249, 5);
            label_logo.Name = "label_logo";
            label_logo.Size = new Size(135, 17);
            label_logo.TabIndex = 1;
            label_logo.Text = "Starting application...";
            // 
            // progressPanel
            // 
            progressPanel.BackColor = Color.FromArgb(14, 159, 104);
            progressPanel.Location = new Point(0, 0);
            progressPanel.Name = "progressPanel";
            progressPanel.Size = new Size(50, 28);
            progressPanel.TabIndex = 0;
            // 
            // time01
            // 
            time01.Interval = 15;
            time01.Tick += time01_Tick;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 185);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(622, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loadingBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 213);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loadingBar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loadingBar";
            Load += loadingBar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel progressPanel;
        private System.Windows.Forms.Timer time01;
        private Panel panel2;
        private PictureBox pictureBox1;
        public Label label_logo;
    }
}