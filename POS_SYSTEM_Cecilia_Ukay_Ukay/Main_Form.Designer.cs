namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            panel1 = new Panel();
            btn_Sales_Report = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            picture_account = new PictureBox();
            btn_User = new Button();
            btn_Warehouse = new Button();
            btn_Inventory = new Button();
            btn_Settings = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label_Date = new Label();
            label_Time = new Label();
            btn_All_Category = new Button();
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            flow_list_product = new FlowLayoutPanel();
            upper_panel = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            product_Show1 = new Product_Show();
            product_Show2 = new Product_Show();
            product_Show3 = new Product_Show();
            product_Show4 = new Product_Show();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_account).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            flow_list_product.SuspendLayout();
            upper_panel.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 159, 104);
            panel1.Controls.Add(btn_Sales_Report);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(picture_account);
            panel1.Controls.Add(btn_User);
            panel1.Controls.Add(btn_Warehouse);
            panel1.Controls.Add(btn_Inventory);
            panel1.Controls.Add(btn_Settings);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 63);
            panel1.TabIndex = 3;
            // 
            // btn_Sales_Report
            // 
            btn_Sales_Report.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Sales_Report.BackColor = Color.FromArgb(14, 159, 104);
            btn_Sales_Report.Cursor = Cursors.Hand;
            btn_Sales_Report.FlatAppearance.BorderSize = 0;
            btn_Sales_Report.FlatStyle = FlatStyle.Flat;
            btn_Sales_Report.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sales_Report.ForeColor = Color.White;
            btn_Sales_Report.Image = (Image)resources.GetObject("btn_Sales_Report.Image");
            btn_Sales_Report.Location = new Point(642, 0);
            btn_Sales_Report.Name = "btn_Sales_Report";
            btn_Sales_Report.Size = new Size(80, 63);
            btn_Sales_Report.TabIndex = 18;
            btn_Sales_Report.Text = "Sales Report";
            btn_Sales_Report.TextAlign = ContentAlignment.BottomCenter;
            btn_Sales_Report.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Sales_Report.UseVisualStyleBackColor = false;
            btn_Sales_Report.Click += btn_Sales_Report_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(277, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 31);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(14, 159, 104);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(980, 0);
            button1.Name = "button1";
            button1.Size = new Size(76, 63);
            button1.TabIndex = 16;
            button1.Text = "History Log";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // picture_account
            // 
            picture_account.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picture_account.Cursor = Cursors.Hand;
            picture_account.Image = (Image)resources.GetObject("picture_account.Image");
            picture_account.Location = new Point(1130, 3);
            picture_account.Name = "picture_account";
            picture_account.Size = new Size(57, 55);
            picture_account.SizeMode = PictureBoxSizeMode.Zoom;
            picture_account.TabIndex = 15;
            picture_account.TabStop = false;
            picture_account.Click += picture_account_Click;
            // 
            // btn_User
            // 
            btn_User.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_User.BackColor = Color.FromArgb(14, 159, 104);
            btn_User.Cursor = Cursors.Hand;
            btn_User.FlatAppearance.BorderSize = 0;
            btn_User.FlatStyle = FlatStyle.Flat;
            btn_User.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_User.ForeColor = Color.White;
            btn_User.Image = (Image)resources.GetObject("btn_User.Image");
            btn_User.Location = new Point(890, 0);
            btn_User.Name = "btn_User";
            btn_User.Size = new Size(84, 63);
            btn_User.TabIndex = 14;
            btn_User.Text = "Manage User";
            btn_User.TextAlign = ContentAlignment.BottomCenter;
            btn_User.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_User.UseVisualStyleBackColor = false;
            btn_User.Click += btn_User_Click;
            // 
            // btn_Warehouse
            // 
            btn_Warehouse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Warehouse.BackColor = Color.FromArgb(14, 159, 104);
            btn_Warehouse.Cursor = Cursors.Hand;
            btn_Warehouse.FlatAppearance.BorderSize = 0;
            btn_Warehouse.FlatStyle = FlatStyle.Flat;
            btn_Warehouse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Warehouse.ForeColor = Color.White;
            btn_Warehouse.Image = (Image)resources.GetObject("btn_Warehouse.Image");
            btn_Warehouse.Location = new Point(804, 0);
            btn_Warehouse.Name = "btn_Warehouse";
            btn_Warehouse.Size = new Size(80, 63);
            btn_Warehouse.TabIndex = 13;
            btn_Warehouse.Text = "Warehouse";
            btn_Warehouse.TextAlign = ContentAlignment.BottomCenter;
            btn_Warehouse.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Warehouse.UseVisualStyleBackColor = false;
            // 
            // btn_Inventory
            // 
            btn_Inventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Inventory.BackColor = Color.FromArgb(14, 159, 104);
            btn_Inventory.Cursor = Cursors.Hand;
            btn_Inventory.FlatAppearance.BorderSize = 0;
            btn_Inventory.FlatStyle = FlatStyle.Flat;
            btn_Inventory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Inventory.ForeColor = Color.White;
            btn_Inventory.Image = (Image)resources.GetObject("btn_Inventory.Image");
            btn_Inventory.Location = new Point(728, 0);
            btn_Inventory.Name = "btn_Inventory";
            btn_Inventory.Size = new Size(70, 63);
            btn_Inventory.TabIndex = 12;
            btn_Inventory.Text = "Inventory";
            btn_Inventory.TextAlign = ContentAlignment.BottomCenter;
            btn_Inventory.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Inventory.UseVisualStyleBackColor = false;
            btn_Inventory.Click += btn_Inventory_Click;
            // 
            // btn_Settings
            // 
            btn_Settings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Settings.BackColor = Color.FromArgb(14, 159, 104);
            btn_Settings.Cursor = Cursors.Hand;
            btn_Settings.FlatAppearance.BorderSize = 0;
            btn_Settings.FlatStyle = FlatStyle.Flat;
            btn_Settings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Settings.ForeColor = Color.White;
            btn_Settings.Image = (Image)resources.GetObject("btn_Settings.Image");
            btn_Settings.Location = new Point(1062, 0);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(62, 63);
            btn_Settings.TabIndex = 11;
            btn_Settings.Text = "Settings";
            btn_Settings.TextAlign = ContentAlignment.BottomCenter;
            btn_Settings.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Settings.UseVisualStyleBackColor = false;
            btn_Settings.Click += btn_Settings_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(68, 21);
            label2.Name = "label2";
            label2.Size = new Size(185, 22);
            label2.TabIndex = 1;
            label2.Text = "Cecilia's Ukay-Ukay";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Controls.Add(label_Date);
            panel2.Controls.Add(label_Time);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 575);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 25);
            panel2.TabIndex = 4;
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Date.ForeColor = Color.White;
            label_Date.Location = new Point(834, 5);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(36, 17);
            label_Date.TabIndex = 1;
            label_Date.Text = "Date";
            // 
            // label_Time
            // 
            label_Time.AutoSize = true;
            label_Time.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Time.ForeColor = Color.White;
            label_Time.Location = new Point(593, 5);
            label_Time.Name = "label_Time";
            label_Time.Size = new Size(37, 17);
            label_Time.TabIndex = 0;
            label_Time.Text = "Time";
            // 
            // btn_All_Category
            // 
            btn_All_Category.BackColor = Color.FromArgb(14, 159, 104);
            btn_All_Category.Cursor = Cursors.Hand;
            btn_All_Category.FlatAppearance.BorderSize = 0;
            btn_All_Category.FlatStyle = FlatStyle.Flat;
            btn_All_Category.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_All_Category.ForeColor = Color.White;
            btn_All_Category.Location = new Point(13, 6);
            btn_All_Category.Name = "btn_All_Category";
            btn_All_Category.Size = new Size(80, 47);
            btn_All_Category.TabIndex = 1;
            btn_All_Category.Text = "All";
            btn_All_Category.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 63);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(upper_panel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new Size(1200, 512);
            splitContainer1.SplitterDistance = 782;
            splitContainer1.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(flow_list_product);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 60);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 0, 10, 10);
            panel4.Size = new Size(782, 452);
            panel4.TabIndex = 1;
            // 
            // flow_list_product
            // 
            flow_list_product.AutoScroll = true;
            flow_list_product.Controls.Add(product_Show1);
            flow_list_product.Controls.Add(product_Show2);
            flow_list_product.Controls.Add(product_Show3);
            flow_list_product.Controls.Add(product_Show4);
            flow_list_product.Dock = DockStyle.Fill;
            flow_list_product.Location = new Point(10, 0);
            flow_list_product.Name = "flow_list_product";
            flow_list_product.Size = new Size(762, 442);
            flow_list_product.TabIndex = 0;
            // 
            // upper_panel
            // 
            upper_panel.Controls.Add(btn_All_Category);
            upper_panel.Dock = DockStyle.Top;
            upper_panel.Location = new Point(0, 0);
            upper_panel.Name = "upper_panel";
            upper_panel.Padding = new Padding(10, 0, 0, 0);
            upper_panel.Size = new Size(782, 60);
            upper_panel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 492);
            panel3.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(394, 43);
            panel6.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(14, 159, 104);
            label3.Location = new Point(5, 6);
            label3.Name = "label3";
            label3.Size = new Size(139, 30);
            label3.TabIndex = 0;
            label3.Text = "Order Details";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(66, 85, 125);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 447);
            panel5.Name = "panel5";
            panel5.Size = new Size(394, 45);
            panel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 11);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 2;
            label4.Text = "Total";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // product_Show1
            // 
            product_Show1.BackColor = Color.White;
            product_Show1.Location = new Point(3, 3);
            product_Show1.Name = "product_Show1";
            product_Show1.Padding = new Padding(10);
            product_Show1.Size = new Size(420, 175);
            product_Show1.TabIndex = 0;
            // 
            // product_Show2
            // 
            product_Show2.BackColor = Color.White;
            product_Show2.Location = new Point(3, 184);
            product_Show2.Name = "product_Show2";
            product_Show2.Padding = new Padding(10);
            product_Show2.Size = new Size(420, 175);
            product_Show2.TabIndex = 1;
            // 
            // product_Show3
            // 
            product_Show3.BackColor = Color.White;
            product_Show3.Location = new Point(3, 365);
            product_Show3.Name = "product_Show3";
            product_Show3.Padding = new Padding(10);
            product_Show3.Size = new Size(420, 175);
            product_Show3.TabIndex = 2;
            // 
            // product_Show4
            // 
            product_Show4.BackColor = Color.White;
            product_Show4.Location = new Point(3, 546);
            product_Show4.Name = "product_Show4";
            product_Show4.Padding = new Padding(10);
            product_Show4.Size = new Size(420, 175);
            product_Show4.TabIndex = 3;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Main_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_account).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            flow_list_product.ResumeLayout(false);
            upper_panel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button btn_Warehouse;
        private Button btn_Inventory;
        private Button btn_Settings;
        private Button btn_User;
        private PictureBox picture_account;
        private SplitContainer splitContainer1;
        private Label label3;
        private Panel panel3;
        private TextBox textBox1;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private Button button1;
        private Button btn_All_Category;
        private PictureBox pictureBox1;
        private Panel upper_panel;
        private Panel panel4;
        private FlowLayoutPanel flow_list_product;
        private Button btn_Sales_Report;
        private Label label_Time;
        private Label label_Date;
        private System.Windows.Forms.Timer timer1;
        private Product_Show product_Show1;
        private Product_Show product_Show2;
        private Product_Show product_Show3;
        private Product_Show product_Show4;
    }
}