namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class History_Log_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Log_Form));
            panel_center = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btn_Transaction = new Button();
            btn_Retailer = new Button();
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
            label1.Size = new Size(155, 33);
            label1.TabIndex = 0;
            label1.Text = "History Log";
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_Transaction);
            panel3.Controls.Add(btn_Retailer);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1080, 60);
            panel3.TabIndex = 23;
            // 
            // btn_Transaction
            // 
            btn_Transaction.BackColor = Color.FromArgb(14, 159, 104);
            btn_Transaction.Cursor = Cursors.Hand;
            btn_Transaction.FlatAppearance.BorderSize = 0;
            btn_Transaction.FlatStyle = FlatStyle.Flat;
            btn_Transaction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Transaction.ForeColor = Color.White;
            btn_Transaction.Image = (Image)resources.GetObject("btn_Transaction.Image");
            btn_Transaction.Location = new Point(296, 11);
            btn_Transaction.Name = "btn_Transaction";
            btn_Transaction.Size = new Size(227, 38);
            btn_Transaction.TabIndex = 17;
            btn_Transaction.Text = " Order Transaction";
            btn_Transaction.TextAlign = ContentAlignment.MiddleRight;
            btn_Transaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Transaction.UseVisualStyleBackColor = false;
            btn_Transaction.Click += btn_Transaction_Click;
            // 
            // btn_Retailer
            // 
            btn_Retailer.BackColor = Color.FromArgb(14, 159, 104);
            btn_Retailer.Cursor = Cursors.Hand;
            btn_Retailer.FlatAppearance.BorderSize = 0;
            btn_Retailer.FlatStyle = FlatStyle.Flat;
            btn_Retailer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Retailer.ForeColor = Color.White;
            btn_Retailer.Image = (Image)resources.GetObject("btn_Retailer.Image");
            btn_Retailer.Location = new Point(12, 11);
            btn_Retailer.Name = "btn_Retailer";
            btn_Retailer.Size = new Size(269, 38);
            btn_Retailer.TabIndex = 16;
            btn_Retailer.Text = " Management Transaction";
            btn_Retailer.TextAlign = ContentAlignment.MiddleRight;
            btn_Retailer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Retailer.UseVisualStyleBackColor = false;
            btn_Retailer.Click += btn_Retailer_Click;
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
            btnClose.Location = new Point(1045, 0);
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
            // History_Log_Form
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
            Name = "History_Log_Form";
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
        private Button btn_Transaction;
        public Button btn_Retailer;
        private Panel panel2;
        private Button btnClose;
        private Panel panel1;
    }
}