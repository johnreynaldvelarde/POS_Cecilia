namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Sales_Report_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Report_Form));
            center_panel = new Panel();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            panel11 = new Panel();
            btn_Psold = new Button();
            label_product_sold = new Label();
            label23 = new Label();
            panel10 = new Panel();
            btn_Annual = new Button();
            label_annual = new Label();
            label19 = new Label();
            label20 = new Label();
            panel9 = new Panel();
            btn_Monthly = new Button();
            label_monthly = new Label();
            label16 = new Label();
            label17 = new Label();
            panel8 = new Panel();
            btn_Weekly = new Button();
            label_weekly = new Label();
            label13 = new Label();
            label14 = new Label();
            panel4 = new Panel();
            btn_todaySales = new Button();
            label_today = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            center_panel.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // center_panel
            // 
            center_panel.Controls.Add(cartesianChart1);
            center_panel.Controls.Add(panel11);
            center_panel.Controls.Add(panel10);
            center_panel.Controls.Add(panel9);
            center_panel.Controls.Add(panel8);
            center_panel.Controls.Add(panel4);
            center_panel.Dock = DockStyle.Fill;
            center_panel.Location = new Point(10, 73);
            center_panel.Name = "center_panel";
            center_panel.Padding = new Padding(5, 20, 0, 0);
            center_panel.Size = new Size(1080, 617);
            center_panel.TabIndex = 24;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(289, 23);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(348, 229);
            cartesianChart1.TabIndex = 8;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(78, 181, 234);
            panel11.Controls.Add(btn_Psold);
            panel11.Controls.Add(label_product_sold);
            panel11.Controls.Add(label23);
            panel11.Location = new Point(12, 502);
            panel11.Name = "panel11";
            panel11.Size = new Size(271, 109);
            panel11.TabIndex = 7;
            // 
            // btn_Psold
            // 
            btn_Psold.BackColor = Color.FromArgb(78, 181, 234);
            btn_Psold.Cursor = Cursors.Hand;
            btn_Psold.FlatAppearance.BorderSize = 0;
            btn_Psold.FlatStyle = FlatStyle.Flat;
            btn_Psold.Image = (Image)resources.GetObject("btn_Psold.Image");
            btn_Psold.Location = new Point(242, 3);
            btn_Psold.Name = "btn_Psold";
            btn_Psold.Size = new Size(22, 26);
            btn_Psold.TabIndex = 3;
            btn_Psold.UseVisualStyleBackColor = false;
            btn_Psold.Click += btn_Psold_Click;
            // 
            // label_product_sold
            // 
            label_product_sold.AutoSize = true;
            label_product_sold.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_product_sold.ForeColor = Color.White;
            label_product_sold.Location = new Point(102, 45);
            label_product_sold.Name = "label_product_sold";
            label_product_sold.Size = new Size(25, 30);
            label_product_sold.TabIndex = 2;
            label_product_sold.Text = "0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(8, 9);
            label23.Name = "label23";
            label23.Size = new Size(105, 20);
            label23.TabIndex = 0;
            label23.Text = "Products Sold";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(78, 181, 234);
            panel10.Controls.Add(btn_Annual);
            panel10.Controls.Add(label_annual);
            panel10.Controls.Add(label19);
            panel10.Controls.Add(label20);
            panel10.Location = new Point(12, 382);
            panel10.Name = "panel10";
            panel10.Size = new Size(271, 109);
            panel10.TabIndex = 6;
            // 
            // btn_Annual
            // 
            btn_Annual.BackColor = Color.FromArgb(78, 181, 234);
            btn_Annual.Cursor = Cursors.Hand;
            btn_Annual.FlatAppearance.BorderSize = 0;
            btn_Annual.FlatStyle = FlatStyle.Flat;
            btn_Annual.Image = (Image)resources.GetObject("btn_Annual.Image");
            btn_Annual.Location = new Point(242, 3);
            btn_Annual.Name = "btn_Annual";
            btn_Annual.Size = new Size(22, 26);
            btn_Annual.TabIndex = 3;
            btn_Annual.UseVisualStyleBackColor = false;
            btn_Annual.Click += btn_Annual_Click;
            // 
            // label_annual
            // 
            label_annual.AutoSize = true;
            label_annual.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_annual.ForeColor = Color.White;
            label_annual.Location = new Point(102, 45);
            label_annual.Name = "label_annual";
            label_annual.Size = new Size(42, 30);
            label_annual.TabIndex = 2;
            label_annual.Text = "0.0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(52, 45);
            label19.Name = "label19";
            label19.Size = new Size(52, 30);
            label19.TabIndex = 1;
            label19.Text = "PHP";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(8, 9);
            label20.Name = "label20";
            label20.Size = new Size(98, 20);
            label20.TabIndex = 0;
            label20.Text = "Annual Sales";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(78, 181, 234);
            panel9.Controls.Add(btn_Monthly);
            panel9.Controls.Add(label_monthly);
            panel9.Controls.Add(label16);
            panel9.Controls.Add(label17);
            panel9.Location = new Point(12, 263);
            panel9.Name = "panel9";
            panel9.Size = new Size(271, 109);
            panel9.TabIndex = 5;
            // 
            // btn_Monthly
            // 
            btn_Monthly.BackColor = Color.FromArgb(78, 181, 234);
            btn_Monthly.Cursor = Cursors.Hand;
            btn_Monthly.FlatAppearance.BorderSize = 0;
            btn_Monthly.FlatStyle = FlatStyle.Flat;
            btn_Monthly.Image = (Image)resources.GetObject("btn_Monthly.Image");
            btn_Monthly.Location = new Point(242, 3);
            btn_Monthly.Name = "btn_Monthly";
            btn_Monthly.Size = new Size(22, 26);
            btn_Monthly.TabIndex = 3;
            btn_Monthly.UseVisualStyleBackColor = false;
            btn_Monthly.Click += btn_Monthly_Click;
            // 
            // label_monthly
            // 
            label_monthly.AutoSize = true;
            label_monthly.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_monthly.ForeColor = Color.White;
            label_monthly.Location = new Point(102, 45);
            label_monthly.Name = "label_monthly";
            label_monthly.Size = new Size(42, 30);
            label_monthly.TabIndex = 2;
            label_monthly.Text = "0.0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(52, 45);
            label16.Name = "label16";
            label16.Size = new Size(52, 30);
            label16.TabIndex = 1;
            label16.Text = "PHP";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(8, 9);
            label17.Name = "label17";
            label17.Size = new Size(107, 20);
            label17.TabIndex = 0;
            label17.Text = "Monthly Sales";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(78, 181, 234);
            panel8.Controls.Add(btn_Weekly);
            panel8.Controls.Add(label_weekly);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(12, 143);
            panel8.Name = "panel8";
            panel8.Size = new Size(271, 109);
            panel8.TabIndex = 4;
            // 
            // btn_Weekly
            // 
            btn_Weekly.BackColor = Color.FromArgb(78, 181, 234);
            btn_Weekly.Cursor = Cursors.Hand;
            btn_Weekly.FlatAppearance.BorderSize = 0;
            btn_Weekly.FlatStyle = FlatStyle.Flat;
            btn_Weekly.Image = (Image)resources.GetObject("btn_Weekly.Image");
            btn_Weekly.Location = new Point(242, 3);
            btn_Weekly.Name = "btn_Weekly";
            btn_Weekly.Size = new Size(22, 26);
            btn_Weekly.TabIndex = 3;
            btn_Weekly.UseVisualStyleBackColor = false;
            btn_Weekly.Click += btn_Weekly_Click;
            // 
            // label_weekly
            // 
            label_weekly.AutoSize = true;
            label_weekly.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_weekly.ForeColor = Color.White;
            label_weekly.Location = new Point(102, 45);
            label_weekly.Name = "label_weekly";
            label_weekly.Size = new Size(42, 30);
            label_weekly.TabIndex = 2;
            label_weekly.Text = "0.0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(52, 45);
            label13.Name = "label13";
            label13.Size = new Size(52, 30);
            label13.TabIndex = 1;
            label13.Text = "PHP";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(8, 9);
            label14.Name = "label14";
            label14.Size = new Size(99, 20);
            label14.TabIndex = 0;
            label14.Text = "Weekly Sales";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(78, 181, 234);
            panel4.Controls.Add(btn_todaySales);
            panel4.Controls.Add(label_today);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(12, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(271, 109);
            panel4.TabIndex = 0;
            // 
            // btn_todaySales
            // 
            btn_todaySales.BackColor = Color.FromArgb(78, 181, 234);
            btn_todaySales.Cursor = Cursors.Hand;
            btn_todaySales.FlatAppearance.BorderSize = 0;
            btn_todaySales.FlatStyle = FlatStyle.Flat;
            btn_todaySales.Image = (Image)resources.GetObject("btn_todaySales.Image");
            btn_todaySales.Location = new Point(242, 3);
            btn_todaySales.Name = "btn_todaySales";
            btn_todaySales.Size = new Size(22, 26);
            btn_todaySales.TabIndex = 3;
            btn_todaySales.UseVisualStyleBackColor = false;
            btn_todaySales.Click += btn_todaySales_Click;
            // 
            // label_today
            // 
            label_today.AutoSize = true;
            label_today.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_today.ForeColor = Color.White;
            label_today.Location = new Point(102, 45);
            label_today.Name = "label_today";
            label_today.Size = new Size(42, 30);
            label_today.TabIndex = 2;
            label_today.Text = "0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 45);
            label3.Name = "label3";
            label3.Size = new Size(52, 30);
            label3.TabIndex = 1;
            label3.Text = "PHP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 0;
            label2.Text = "Today's Sales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(392, 33);
            label1.TabIndex = 0;
            label1.Text = "Sales Report and Stock Level";
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
            // Sales_Report_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            ControlBox = false;
            Controls.Add(center_panel);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Sales_Report_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            center_panel.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel center_panel;
        private Label label1;
        private Panel panel2;
        private Button btnClose;
        private Panel panel1;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label_today;
        private Button btn_todaySales;
        private Panel panel11;
        private Button btn_Psold;
        private Label label_product_sold;
        private Label label23;
        private Panel panel10;
        private Button btn_Annual;
        private Label label_annual;
        private Label label19;
        private Label label20;
        private Panel panel9;
        private Button btn_Monthly;
        private Label label_monthly;
        private Label label16;
        private Label label17;
        private Panel panel8;
        private Button btn_Weekly;
        private Label label_weekly;
        private Label label13;
        private Label label14;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}