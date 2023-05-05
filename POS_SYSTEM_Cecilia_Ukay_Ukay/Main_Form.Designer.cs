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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_User = new Button();
            btn_Warehouse = new Button();
            btn_Inventory = new Button();
            btn_Settings = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            side_Panel = new Panel();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            product_Show1 = new Product_Show();
            product_Show2 = new Product_Show();
            panel4 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 159, 104);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_User);
            panel1.Controls.Add(btn_Warehouse);
            panel1.Controls.Add(btn_Inventory);
            panel1.Controls.Add(btn_Settings);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 63);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1130, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
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
            btn_User.Location = new Point(718, 0);
            btn_User.Name = "btn_User";
            btn_User.Size = new Size(112, 63);
            btn_User.TabIndex = 14;
            btn_User.Text = "User Management";
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
            btn_Warehouse.Location = new Point(632, 0);
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
            btn_Inventory.Location = new Point(556, 0);
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
            btn_Settings.Location = new Point(488, 0);
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
            label2.Location = new Point(172, 20);
            label2.Name = "label2";
            label2.Size = new Size(185, 22);
            label2.TabIndex = 1;
            label2.Text = "Cecilia's Ukay-Ukay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 0;
            label1.Text = "POS SYSTEM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 575);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 25);
            panel2.TabIndex = 4;
            // 
            // side_Panel
            // 
            side_Panel.BackColor = SystemColors.Control;
            side_Panel.Dock = DockStyle.Left;
            side_Panel.Location = new Point(0, 63);
            side_Panel.Name = "side_Panel";
            side_Panel.Size = new Size(74, 512);
            side_Panel.TabIndex = 5;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(74, 63);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(panel4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new Size(1126, 512);
            splitContainer1.SplitterDistance = 655;
            splitContainer1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(product_Show1);
            flowLayoutPanel1.Controls.Add(product_Show2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 53);
            flowLayoutPanel1.Margin = new Padding(30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(655, 459);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // product_Show1
            // 
            product_Show1.BackColor = Color.White;
            product_Show1.Location = new Point(10, 10);
            product_Show1.Margin = new Padding(10);
            product_Show1.Name = "product_Show1";
            product_Show1.Padding = new Padding(10);
            product_Show1.Size = new Size(306, 357);
            product_Show1.TabIndex = 0;
            // 
            // product_Show2
            // 
            product_Show2.BackColor = Color.White;
            product_Show2.Location = new Point(329, 3);
            product_Show2.Name = "product_Show2";
            product_Show2.Padding = new Padding(10);
            product_Show2.Size = new Size(306, 357);
            product_Show2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(655, 53);
            panel4.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(15, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 31);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 492);
            panel3.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(447, 43);
            panel6.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(14, 159, 104);
            label3.Location = new Point(5, 6);
            label3.Name = "label3";
            label3.Size = new Size(167, 30);
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
            panel5.Size = new Size(447, 45);
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
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(side_Panel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label1;
        private Panel panel2;
        private Button btn_Warehouse;
        private Button btn_Inventory;
        private Button btn_Settings;
        private Button btn_User;
        private PictureBox pictureBox1;
        private Panel side_Panel;
        private SplitContainer splitContainer1;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private Product_Show product_Show1;
        private Product_Show product_Show2;
    }
}