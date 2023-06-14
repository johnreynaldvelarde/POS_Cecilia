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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            center_panel = new Panel();
            text_itm = new TextBox();
            text_pdt = new TextBox();
            label7 = new Label();
            Nproduct_Stock = new TextBox();
            label6 = new Label();
            Nitem_Stock = new TextBox();
            label5 = new Label();
            btn_view_monthly = new Button();
            label4 = new Label();
            chart_sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel11 = new Panel();
            btn_Product = new Button();
            label_product_sold = new Label();
            label23 = new Label();
            panel10 = new Panel();
            btn_Annual = new Button();
            label_annual = new Label();
            label19 = new Label();
            label20 = new Label();
            panel9 = new Panel();
            label_deduct = new Label();
            label_net = new Label();
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
            picture_product = new PictureBox();
            picture_item = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            center_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_sales).BeginInit();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_item).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // center_panel
            // 
            center_panel.Controls.Add(text_itm);
            center_panel.Controls.Add(text_pdt);
            center_panel.Controls.Add(label7);
            center_panel.Controls.Add(Nproduct_Stock);
            center_panel.Controls.Add(label6);
            center_panel.Controls.Add(Nitem_Stock);
            center_panel.Controls.Add(label5);
            center_panel.Controls.Add(btn_view_monthly);
            center_panel.Controls.Add(label4);
            center_panel.Controls.Add(chart_sales);
            center_panel.Controls.Add(panel11);
            center_panel.Controls.Add(panel10);
            center_panel.Controls.Add(panel9);
            center_panel.Controls.Add(panel8);
            center_panel.Controls.Add(panel4);
            center_panel.Controls.Add(picture_product);
            center_panel.Controls.Add(picture_item);
            center_panel.Dock = DockStyle.Fill;
            center_panel.Font = new Font("Century Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            center_panel.Location = new Point(10, 73);
            center_panel.Name = "center_panel";
            center_panel.Padding = new Padding(5, 20, 0, 0);
            center_panel.Size = new Size(1243, 617);
            center_panel.TabIndex = 24;
            // 
            // text_itm
            // 
            text_itm.BorderStyle = BorderStyle.None;
            text_itm.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            text_itm.Location = new Point(961, 491);
            text_itm.Name = "text_itm";
            text_itm.Size = new Size(258, 16);
            text_itm.TabIndex = 21;
            text_itm.TextAlign = HorizontalAlignment.Center;
            // 
            // text_pdt
            // 
            text_pdt.BorderStyle = BorderStyle.None;
            text_pdt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_pdt.Location = new Point(648, 576);
            text_pdt.Name = "text_pdt";
            text_pdt.Size = new Size(299, 20);
            text_pdt.TabIndex = 20;
            text_pdt.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(1035, 231);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 19;
            label7.Text = "Product Stock";
            // 
            // Nproduct_Stock
            // 
            Nproduct_Stock.BorderStyle = BorderStyle.None;
            Nproduct_Stock.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Nproduct_Stock.ForeColor = Color.FromArgb(14, 159, 104);
            Nproduct_Stock.Location = new Point(1022, 343);
            Nproduct_Stock.Name = "Nproduct_Stock";
            Nproduct_Stock.Size = new Size(139, 59);
            Nproduct_Stock.TabIndex = 18;
            Nproduct_Stock.Text = "0";
            Nproduct_Stock.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(754, 254);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 17;
            label6.Text = "Item Stock";
            // 
            // Nitem_Stock
            // 
            Nitem_Stock.BorderStyle = BorderStyle.None;
            Nitem_Stock.Font = new Font("Century Gothic", 50.25F, FontStyle.Regular, GraphicsUnit.Point);
            Nitem_Stock.ForeColor = Color.FromArgb(14, 159, 104);
            Nitem_Stock.Location = new Point(709, 385);
            Nitem_Stock.Name = "Nitem_Stock";
            Nitem_Stock.Size = new Size(175, 83);
            Nitem_Stock.TabIndex = 16;
            Nitem_Stock.Text = "0";
            Nitem_Stock.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(648, 195);
            label5.Name = "label5";
            label5.Size = new Size(181, 21);
            label5.TabIndex = 11;
            label5.Text = "Stock Quantity Monitor";
            // 
            // btn_view_monthly
            // 
            btn_view_monthly.BackColor = Color.White;
            btn_view_monthly.Cursor = Cursors.Hand;
            btn_view_monthly.FlatAppearance.BorderSize = 0;
            btn_view_monthly.FlatStyle = FlatStyle.Flat;
            btn_view_monthly.Image = (Image)resources.GetObject("btn_view_monthly.Image");
            btn_view_monthly.Location = new Point(177, 189);
            btn_view_monthly.Name = "btn_view_monthly";
            btn_view_monthly.Size = new Size(33, 32);
            btn_view_monthly.TabIndex = 4;
            btn_view_monthly.UseVisualStyleBackColor = false;
            btn_view_monthly.Click += btn_view_monthly_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 4;
            label4.Text = "Top Sales By Month";
            // 
            // chart_sales
            // 
            chartArea1.Name = "ChartArea1";
            chart_sales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_sales.Legends.Add(legend1);
            chart_sales.Location = new Point(17, 219);
            chart_sales.Name = "chart_sales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Monthly Sales";
            chart_sales.Series.Add(series1);
            chart_sales.Size = new Size(576, 383);
            chart_sales.TabIndex = 8;
            chart_sales.Text = "chart1";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(196, 111, 212);
            panel11.Controls.Add(btn_Product);
            panel11.Controls.Add(label_product_sold);
            panel11.Controls.Add(label23);
            panel11.Location = new Point(747, 23);
            panel11.Name = "panel11";
            panel11.Size = new Size(240, 109);
            panel11.TabIndex = 7;
            // 
            // btn_Product
            // 
            btn_Product.BackColor = Color.FromArgb(196, 111, 212);
            btn_Product.Cursor = Cursors.Hand;
            btn_Product.FlatAppearance.BorderSize = 0;
            btn_Product.FlatStyle = FlatStyle.Flat;
            btn_Product.Image = (Image)resources.GetObject("btn_Product.Image");
            btn_Product.Location = new Point(207, 3);
            btn_Product.Name = "btn_Product";
            btn_Product.Size = new Size(22, 26);
            btn_Product.TabIndex = 3;
            btn_Product.UseVisualStyleBackColor = false;
            btn_Product.Click += btn_Product_Click;
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
            panel10.BackColor = Color.FromArgb(14, 159, 104);
            panel10.Controls.Add(btn_Annual);
            panel10.Controls.Add(label_annual);
            panel10.Controls.Add(label19);
            panel10.Controls.Add(label20);
            panel10.Location = new Point(501, 23);
            panel10.Name = "panel10";
            panel10.Size = new Size(240, 109);
            panel10.TabIndex = 6;
            // 
            // btn_Annual
            // 
            btn_Annual.BackColor = Color.FromArgb(14, 159, 104);
            btn_Annual.Cursor = Cursors.Hand;
            btn_Annual.FlatAppearance.BorderSize = 0;
            btn_Annual.FlatStyle = FlatStyle.Flat;
            btn_Annual.Image = (Image)resources.GetObject("btn_Annual.Image");
            btn_Annual.Location = new Point(207, 3);
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
            label_annual.Location = new Point(96, 45);
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
            label19.Location = new Point(46, 45);
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
            panel9.BackColor = Color.FromArgb(250, 250, 250);
            panel9.Controls.Add(label_deduct);
            panel9.Controls.Add(label_net);
            panel9.Controls.Add(label16);
            panel9.Controls.Add(label17);
            panel9.Location = new Point(993, 23);
            panel9.Name = "panel9";
            panel9.Size = new Size(240, 109);
            panel9.TabIndex = 5;
            // 
            // label_deduct
            // 
            label_deduct.AutoSize = true;
            label_deduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_deduct.ForeColor = Color.FromArgb(234, 67, 53);
            label_deduct.Location = new Point(108, 74);
            label_deduct.Name = "label_deduct";
            label_deduct.Size = new Size(32, 21);
            label_deduct.TabIndex = 4;
            label_deduct.Text = "0.0";
            // 
            // label_net
            // 
            label_net.AutoSize = true;
            label_net.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_net.ForeColor = Color.FromArgb(7, 124, 214);
            label_net.Location = new Point(96, 42);
            label_net.Name = "label_net";
            label_net.Size = new Size(39, 25);
            label_net.TabIndex = 2;
            label_net.Text = "0.0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(46, 42);
            label16.Name = "label16";
            label16.Size = new Size(48, 25);
            label16.TabIndex = 1;
            label16.Text = "PHP";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(8, 9);
            label17.Name = "label17";
            label17.Size = new Size(88, 20);
            label17.TabIndex = 0;
            label17.Text = "Net Income";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(14, 159, 104);
            panel8.Controls.Add(btn_Weekly);
            panel8.Controls.Add(label_weekly);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(255, 23);
            panel8.Name = "panel8";
            panel8.Size = new Size(240, 109);
            panel8.TabIndex = 4;
            // 
            // btn_Weekly
            // 
            btn_Weekly.BackColor = Color.FromArgb(14, 159, 104);
            btn_Weekly.Cursor = Cursors.Hand;
            btn_Weekly.FlatAppearance.BorderSize = 0;
            btn_Weekly.FlatStyle = FlatStyle.Flat;
            btn_Weekly.Image = (Image)resources.GetObject("btn_Weekly.Image");
            btn_Weekly.Location = new Point(207, 3);
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
            label_weekly.Location = new Point(96, 45);
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
            label13.Location = new Point(46, 45);
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
            panel4.BackColor = Color.FromArgb(14, 159, 104);
            panel4.Controls.Add(btn_todaySales);
            panel4.Controls.Add(label_today);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(9, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 109);
            panel4.TabIndex = 0;
            // 
            // btn_todaySales
            // 
            btn_todaySales.BackColor = Color.FromArgb(14, 159, 104);
            btn_todaySales.Cursor = Cursors.Hand;
            btn_todaySales.FlatAppearance.BorderSize = 0;
            btn_todaySales.FlatStyle = FlatStyle.Flat;
            btn_todaySales.Image = (Image)resources.GetObject("btn_todaySales.Image");
            btn_todaySales.Location = new Point(207, 3);
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
            label_today.Location = new Point(96, 45);
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
            label3.Location = new Point(46, 45);
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
            // picture_product
            // 
            picture_product.Location = new Point(961, 261);
            picture_product.Name = "picture_product";
            picture_product.Size = new Size(258, 224);
            picture_product.SizeMode = PictureBoxSizeMode.Zoom;
            picture_product.TabIndex = 14;
            picture_product.TabStop = false;
            // 
            // picture_item
            // 
            picture_item.Location = new Point(648, 284);
            picture_item.Name = "picture_item";
            picture_item.Size = new Size(299, 286);
            picture_item.SizeMode = PictureBoxSizeMode.Zoom;
            picture_item.TabIndex = 15;
            picture_item.TabStop = false;
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
            panel2.Size = new Size(1243, 3);
            panel2.TabIndex = 22;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1208, 0);
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
            panel1.Size = new Size(1243, 60);
            panel1.TabIndex = 21;
            // 
            // Sales_Report_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1263, 700);
            ControlBox = false;
            Controls.Add(center_panel);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Sales_Report_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Sales_Report_Form_Load;
            center_panel.ResumeLayout(false);
            center_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_sales).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)picture_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_item).EndInit();
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
        private Button btn_Product;
        private Label label_product_sold;
        private Label label23;
        private Panel panel10;
        private Button btn_Annual;
        private Label label_annual;
        private Label label19;
        private Label label20;
        private Panel panel9;
        private Label label_net;
        private Label label16;
        private Label label17;
        private Panel panel8;
        private Button btn_Weekly;
        private Label label_weekly;
        private Label label13;
        private Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sales;
        private Label label4;
        private Button btn_view_monthly;
        private Label label5;
        private Label Nitem_stock;
        private PictureBox picture_product;
        private PictureBox picture_item;
        private TextBox Nitem_Stock;
        private Label label6;
        private TextBox Nproduct_Stock;
        private Label label7;
        private TextBox text_pdt;
        private TextBox text_itm;
        private Label label_deduct;
    }
}