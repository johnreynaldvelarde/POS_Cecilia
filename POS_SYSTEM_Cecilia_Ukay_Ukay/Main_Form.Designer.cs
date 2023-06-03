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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            user_profile = new CircularPictureBox();
            pictureBox2 = new PictureBox();
            btn_Sales_Report = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            btn_History = new Button();
            btn_User = new Button();
            btn_Archive = new Button();
            btn_Inventory = new Button();
            btn_Settings = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label_Date = new Label();
            label_Time = new Label();
            splitContainer1 = new SplitContainer();
            center_panel = new Panel();
            data_Grid_Available = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Product_ID = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Minus = new DataGridViewImageColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Add = new DataGridViewImageColumn();
            Sell = new DataGridViewImageColumn();
            upper_panel = new Panel();
            label6 = new Label();
            cmd_Category = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            data_Grid_Transaction = new DataGridView();
            down_panel = new Panel();
            txt_Product_Code = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label_amount = new Label();
            label1 = new Label();
            btn_Sell = new Button();
            panel6 = new Panel();
            btn_Clear_All = new Button();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Column1 = new DataGridViewTextBoxColumn();
            productID = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            orderQuantity = new DataGridViewTextBoxColumn();
            totalAmount = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_profile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            center_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Available).BeginInit();
            upper_panel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Transaction).BeginInit();
            down_panel.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 159, 104);
            panel1.Controls.Add(user_profile);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_Sales_Report);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_History);
            panel1.Controls.Add(btn_User);
            panel1.Controls.Add(btn_Archive);
            panel1.Controls.Add(btn_Inventory);
            panel1.Controls.Add(btn_Settings);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 63);
            panel1.TabIndex = 3;
            // 
            // user_profile
            // 
            user_profile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            user_profile.Cursor = Cursors.Hand;
            user_profile.Image = (Image)resources.GetObject("user_profile.Image");
            user_profile.Location = new Point(1133, 4);
            user_profile.Name = "user_profile";
            user_profile.Size = new Size(55, 53);
            user_profile.SizeMode = PictureBoxSizeMode.StretchImage;
            user_profile.TabIndex = 51;
            user_profile.TabStop = false;
            user_profile.Click += user_profile_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(258, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
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
            textBox1.Location = new Point(296, 17);
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
            // btn_History
            // 
            btn_History.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_History.BackColor = Color.FromArgb(14, 159, 104);
            btn_History.Cursor = Cursors.Hand;
            btn_History.FlatAppearance.BorderSize = 0;
            btn_History.FlatStyle = FlatStyle.Flat;
            btn_History.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_History.ForeColor = Color.White;
            btn_History.Image = (Image)resources.GetObject("btn_History.Image");
            btn_History.Location = new Point(980, 0);
            btn_History.Name = "btn_History";
            btn_History.Size = new Size(76, 63);
            btn_History.TabIndex = 16;
            btn_History.Text = "History Log";
            btn_History.TextAlign = ContentAlignment.BottomCenter;
            btn_History.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_History.UseVisualStyleBackColor = false;
            btn_History.Click += btn_History_Click;
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
            // btn_Archive
            // 
            btn_Archive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Archive.BackColor = Color.FromArgb(14, 159, 104);
            btn_Archive.Cursor = Cursors.Hand;
            btn_Archive.FlatAppearance.BorderSize = 0;
            btn_Archive.FlatStyle = FlatStyle.Flat;
            btn_Archive.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Archive.ForeColor = Color.White;
            btn_Archive.Image = (Image)resources.GetObject("btn_Archive.Image");
            btn_Archive.Location = new Point(804, 0);
            btn_Archive.Name = "btn_Archive";
            btn_Archive.Size = new Size(80, 63);
            btn_Archive.TabIndex = 13;
            btn_Archive.Text = "  Archive";
            btn_Archive.TextAlign = ContentAlignment.BottomCenter;
            btn_Archive.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Archive.UseVisualStyleBackColor = false;
            btn_Archive.Click += btn_Trash_Click;
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
            btn_Inventory.Text = " Inventory";
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 63);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(center_panel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Padding = new Padding(5, 10, 10, 10);
            splitContainer1.Size = new Size(1200, 512);
            splitContainer1.SplitterDistance = 813;
            splitContainer1.TabIndex = 7;
            // 
            // center_panel
            // 
            center_panel.Controls.Add(data_Grid_Available);
            center_panel.Controls.Add(upper_panel);
            center_panel.Dock = DockStyle.Fill;
            center_panel.Location = new Point(0, 0);
            center_panel.Name = "center_panel";
            center_panel.Padding = new Padding(10);
            center_panel.Size = new Size(813, 512);
            center_panel.TabIndex = 1;
            // 
            // data_Grid_Available
            // 
            data_Grid_Available.AllowUserToAddRows = false;
            data_Grid_Available.AllowUserToOrderColumns = true;
            data_Grid_Available.AllowUserToResizeColumns = false;
            data_Grid_Available.AllowUserToResizeRows = false;
            data_Grid_Available.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Available.BackgroundColor = Color.White;
            data_Grid_Available.BorderStyle = BorderStyle.None;
            data_Grid_Available.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Available.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Grid_Available.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Grid_Available.ColumnHeadersHeight = 50;
            data_Grid_Available.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Available.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Product_ID, Product_Name, Category, Price, Size, Discount, Minus, Quantity, Add, Sell });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Grid_Available.DefaultCellStyle = dataGridViewCellStyle2;
            data_Grid_Available.Dock = DockStyle.Fill;
            data_Grid_Available.EnableHeadersVisualStyles = false;
            data_Grid_Available.Location = new Point(10, 78);
            data_Grid_Available.Name = "data_Grid_Available";
            data_Grid_Available.RowHeadersVisible = false;
            data_Grid_Available.RowHeadersWidth = 50;
            data_Grid_Available.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Available.RowTemplate.Height = 40;
            data_Grid_Available.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Available.Size = new Size(793, 424);
            data_Grid_Available.TabIndex = 8;
            data_Grid_Available.CellContentClick += data_Grid_Available_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 70.62577F;
            dataGridViewTextBoxColumn1.HeaderText = "#";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Product_ID
            // 
            Product_ID.HeaderText = "Product_ID";
            Product_ID.Name = "Product_ID";
            Product_ID.Visible = false;
            // 
            // Product_Name
            // 
            Product_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Product_Name.FillWeight = 153.369919F;
            Product_Name.HeaderText = "Name";
            Product_Name.Name = "Product_Name";
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.FillWeight = 111.979416F;
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.Visible = false;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.FillWeight = 120.537521F;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Size
            // 
            Size.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Size.FillWeight = 129.478317F;
            Size.HeaderText = "Size";
            Size.Name = "Size";
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.Name = "Discount";
            // 
            // Minus
            // 
            Minus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Minus.FillWeight = 53.5013351F;
            Minus.HeaderText = "";
            Minus.Image = (Image)resources.GetObject("Minus.Image");
            Minus.Name = "Minus";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.FillWeight = 90.62495F;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Add
            // 
            Add.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Add.FillWeight = 47.9555626F;
            Add.HeaderText = "";
            Add.Image = (Image)resources.GetObject("Add.Image");
            Add.Name = "Add";
            // 
            // Sell
            // 
            Sell.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Sell.HeaderText = "";
            Sell.Image = (Image)resources.GetObject("Sell.Image");
            Sell.MinimumWidth = 50;
            Sell.Name = "Sell";
            Sell.Width = 50;
            // 
            // upper_panel
            // 
            upper_panel.BackColor = Color.White;
            upper_panel.Controls.Add(label6);
            upper_panel.Controls.Add(cmd_Category);
            upper_panel.Controls.Add(label4);
            upper_panel.Dock = DockStyle.Top;
            upper_panel.Location = new Point(10, 10);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(793, 68);
            upper_panel.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(494, 23);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 49;
            label6.Text = "Category by";
            // 
            // cmd_Category
            // 
            cmd_Category.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmd_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_Category.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_Category.FormattingEnabled = true;
            cmd_Category.Location = new Point(608, 21);
            cmd_Category.Name = "cmd_Category";
            cmd_Category.Size = new Size(165, 28);
            cmd_Category.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(14, 159, 104);
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(262, 33);
            label4.TabIndex = 1;
            label4.Text = "Available Products";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(data_Grid_Transaction);
            panel3.Controls.Add(down_panel);
            panel3.Controls.Add(btn_Sell);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 492);
            panel3.TabIndex = 0;
            // 
            // data_Grid_Transaction
            // 
            data_Grid_Transaction.AllowUserToAddRows = false;
            data_Grid_Transaction.AllowUserToOrderColumns = true;
            data_Grid_Transaction.AllowUserToResizeColumns = false;
            data_Grid_Transaction.AllowUserToResizeRows = false;
            data_Grid_Transaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Transaction.BackgroundColor = Color.White;
            data_Grid_Transaction.BorderStyle = BorderStyle.None;
            data_Grid_Transaction.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Transaction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Grid_Transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Grid_Transaction.ColumnHeadersHeight = 30;
            data_Grid_Transaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Transaction.Columns.AddRange(new DataGridViewColumn[] { Column1, productID, productName, Column5, orderQuantity, totalAmount, Remove });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            data_Grid_Transaction.DefaultCellStyle = dataGridViewCellStyle4;
            data_Grid_Transaction.Dock = DockStyle.Fill;
            data_Grid_Transaction.EnableHeadersVisualStyles = false;
            data_Grid_Transaction.Location = new Point(0, 37);
            data_Grid_Transaction.Name = "data_Grid_Transaction";
            data_Grid_Transaction.ReadOnly = true;
            data_Grid_Transaction.RowHeadersVisible = false;
            data_Grid_Transaction.RowHeadersWidth = 30;
            data_Grid_Transaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Transaction.RowTemplate.Height = 40;
            data_Grid_Transaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Transaction.Size = new Size(368, 196);
            data_Grid_Transaction.TabIndex = 7;
            data_Grid_Transaction.CellFormatting += data_Grid_Transaction_CellFormatting;
            // 
            // down_panel
            // 
            down_panel.Controls.Add(txt_Product_Code);
            down_panel.Controls.Add(label7);
            down_panel.Controls.Add(label5);
            down_panel.Controls.Add(label_amount);
            down_panel.Controls.Add(label1);
            down_panel.Dock = DockStyle.Bottom;
            down_panel.Location = new Point(0, 233);
            down_panel.Name = "down_panel";
            down_panel.Size = new Size(368, 212);
            down_panel.TabIndex = 5;
            // 
            // txt_Product_Code
            // 
            txt_Product_Code.BorderStyle = BorderStyle.FixedSingle;
            txt_Product_Code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Product_Code.Location = new Point(13, 47);
            txt_Product_Code.Name = "txt_Product_Code";
            txt_Product_Code.Size = new Size(240, 29);
            txt_Product_Code.TabIndex = 51;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 12);
            label7.Name = "label7";
            label7.Size = new Size(176, 21);
            label7.TabIndex = 3;
            label7.Text = "Select Payment Method:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 140);
            label5.Name = "label5";
            label5.Size = new Size(176, 21);
            label5.TabIndex = 2;
            label5.Text = "Select Payment Method:";
            // 
            // label_amount
            // 
            label_amount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_amount.AutoSize = true;
            label_amount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_amount.ForeColor = Color.FromArgb(211, 82, 48);
            label_amount.Location = new Point(149, 171);
            label_amount.Name = "label_amount";
            label_amount.Size = new Size(75, 25);
            label_amount.TabIndex = 1;
            label_amount.Text = "100000";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 171);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Total Amount:";
            // 
            // btn_Sell
            // 
            btn_Sell.BackColor = Color.FromArgb(14, 159, 104);
            btn_Sell.Cursor = Cursors.Hand;
            btn_Sell.Dock = DockStyle.Bottom;
            btn_Sell.FlatAppearance.BorderSize = 0;
            btn_Sell.FlatStyle = FlatStyle.Flat;
            btn_Sell.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sell.ForeColor = Color.White;
            btn_Sell.Location = new Point(0, 445);
            btn_Sell.Name = "btn_Sell";
            btn_Sell.Size = new Size(368, 47);
            btn_Sell.TabIndex = 4;
            btn_Sell.Text = "Sell";
            btn_Sell.UseVisualStyleBackColor = false;
            btn_Sell.Click += btn_Sell_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(14, 159, 104);
            panel6.Controls.Add(btn_Clear_All);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(368, 37);
            panel6.TabIndex = 2;
            // 
            // btn_Clear_All
            // 
            btn_Clear_All.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Clear_All.Cursor = Cursors.Hand;
            btn_Clear_All.FlatAppearance.BorderSize = 0;
            btn_Clear_All.FlatStyle = FlatStyle.Flat;
            btn_Clear_All.ForeColor = Color.White;
            btn_Clear_All.Location = new Point(311, 0);
            btn_Clear_All.Name = "btn_Clear_All";
            btn_Clear_All.Size = new Size(57, 37);
            btn_Clear_All.TabIndex = 0;
            btn_Clear_All.Text = "Clear all";
            btn_Clear_All.UseVisualStyleBackColor = true;
            btn_Clear_All.Click += btn_Clear_All_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 9);
            label3.Name = "label3";
            label3.Size = new Size(151, 19);
            label3.TabIndex = 0;
            label3.Text = "Transaction Details";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 34.9684563F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // productID
            // 
            productID.HeaderText = "Product_ID";
            productID.Name = "productID";
            productID.ReadOnly = true;
            productID.Visible = false;
            // 
            // productName
            // 
            productName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productName.FillWeight = 183.248428F;
            productName.HeaderText = "Name";
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 93.83203F;
            Column5.HeaderText = "Price";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // orderQuantity
            // 
            orderQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderQuantity.FillWeight = 54.8579F;
            orderQuantity.HeaderText = "Qyt";
            orderQuantity.Name = "orderQuantity";
            orderQuantity.ReadOnly = true;
            // 
            // totalAmount
            // 
            totalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalAmount.FillWeight = 91.07616F;
            totalAmount.HeaderText = "Amount";
            totalAmount.Name = "totalAmount";
            totalAmount.ReadOnly = true;
            // 
            // Remove
            // 
            Remove.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Remove.HeaderText = "";
            Remove.Image = (Image)resources.GetObject("Remove.Image");
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            Remove.Width = 5;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
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
            ((System.ComponentModel.ISupportInitialize)user_profile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            center_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Grid_Available).EndInit();
            upper_panel.ResumeLayout(false);
            upper_panel.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Grid_Transaction).EndInit();
            down_panel.ResumeLayout(false);
            down_panel.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button btn_Archive;
        private Button btn_Inventory;
        private Button btn_Settings;
        private Button btn_User;
        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private Button btn_History;
        private PictureBox pictureBox1;
        private Button btn_Sales_Report;
        private Label label_Time;
        private Label label_Date;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel6;
        private Label label3;
        private Panel center_panel;
        private Button btn_Sell;
        private Button btn_Clear_All;
        private Panel down_panel;
        private Label label1;
        private Label label_amount;
        private DataGridView data_Grid_Transaction;
        private DataGridView data_Grid_Available;
        private Panel upper_panel;
        private Label label4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewImageColumn Minus;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewImageColumn Add;
        private DataGridViewImageColumn Sell;
        private Label label5;
        private Label label6;
        private ComboBox cmd_Category;
        private Label label7;
        public TextBox txt_Product_Code;
        private CircularPictureBox user_profile;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn orderQuantity;
        private DataGridViewTextBoxColumn totalAmount;
        private DataGridViewImageColumn Remove;
    }
}