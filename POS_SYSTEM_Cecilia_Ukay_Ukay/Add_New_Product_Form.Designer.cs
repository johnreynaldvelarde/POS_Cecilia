namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Add_New_Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Product_Form));
            cmd_Category = new ComboBox();
            btn_Clear = new Button();
            btn_Save = new Button();
            label6 = new Label();
            txt_Qyt = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txt_Product_Name = new TextBox();
            label2 = new Label();
            btn_Product_Image = new Button();
            picture_Product = new PictureBox();
            label1 = new Label();
            txt_ProductID = new TextBox();
            btnClose = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            txt_Description = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picture_Product).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmd_Category
            // 
            cmd_Category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_Category.FormattingEnabled = true;
            cmd_Category.Location = new Point(419, 477);
            cmd_Category.Name = "cmd_Category";
            cmd_Category.Size = new Size(400, 29);
            cmd_Category.TabIndex = 47;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(71, 81, 86);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(737, 546);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(145, 48);
            btn_Clear.TabIndex = 46;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(14, 159, 104);
            btn_Save.Cursor = Cursors.Hand;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(585, 546);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(145, 48);
            btn_Save.TabIndex = 45;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(419, 357);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 44;
            label6.Text = "Price *";
            // 
            // txt_Qyt
            // 
            txt_Qyt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Qyt.Location = new Point(419, 392);
            txt_Qyt.Name = "txt_Qyt";
            txt_Qyt.Size = new Size(400, 29);
            txt_Qyt.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(419, 442);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 42;
            label5.Text = "Category *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(419, 185);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 39;
            label3.Text = "Product Name *";
            // 
            // txt_Product_Name
            // 
            txt_Product_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Product_Name.Location = new Point(419, 220);
            txt_Product_Name.Name = "txt_Product_Name";
            txt_Product_Name.Size = new Size(400, 29);
            txt_Product_Name.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(419, 103);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 37;
            label2.Text = "Product ID *";
            // 
            // btn_Product_Image
            // 
            btn_Product_Image.BackColor = Color.FromArgb(14, 159, 104);
            btn_Product_Image.Cursor = Cursors.Hand;
            btn_Product_Image.FlatAppearance.BorderSize = 0;
            btn_Product_Image.FlatStyle = FlatStyle.Flat;
            btn_Product_Image.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Product_Image.ForeColor = Color.White;
            btn_Product_Image.Image = (Image)resources.GetObject("btn_Product_Image.Image");
            btn_Product_Image.Location = new Point(49, 409);
            btn_Product_Image.Name = "btn_Product_Image";
            btn_Product_Image.Size = new Size(300, 38);
            btn_Product_Image.TabIndex = 35;
            btn_Product_Image.Text = "Add product image";
            btn_Product_Image.TextAlign = ContentAlignment.MiddleRight;
            btn_Product_Image.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Product_Image.UseVisualStyleBackColor = false;
            btn_Product_Image.Click += btn_Product_Image_Click;
            // 
            // picture_Product
            // 
            picture_Product.BorderStyle = BorderStyle.FixedSingle;
            picture_Product.Location = new Point(49, 103);
            picture_Product.Name = "picture_Product";
            picture_Product.Size = new Size(300, 300);
            picture_Product.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_Product.TabIndex = 34;
            picture_Product.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 0;
            label1.Text = "Add new product";
            // 
            // txt_ProductID
            // 
            txt_ProductID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ProductID.Location = new Point(419, 138);
            txt_ProductID.Name = "txt_ProductID";
            txt_ProductID.Size = new Size(400, 29);
            txt_ProductID.TabIndex = 36;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(843, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 31;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 159, 104);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 3);
            panel2.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 45);
            panel1.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(419, 274);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 49;
            label4.Text = "Description ";
            // 
            // txt_Description
            // 
            txt_Description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Description.Location = new Point(419, 309);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(400, 29);
            txt_Description.TabIndex = 48;
            // 
            // Add_New_Product_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(txt_Description);
            Controls.Add(cmd_Category);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(label6);
            Controls.Add(txt_Qyt);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txt_Product_Name);
            Controls.Add(label2);
            Controls.Add(btn_Product_Image);
            Controls.Add(picture_Product);
            Controls.Add(txt_ProductID);
            Controls.Add(btnClose);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_New_Product_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)picture_Product).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmd_Category;
        private Button btn_Clear;
        private Button btn_Save;
        private Label label6;
        private TextBox txt_Qyt;
        private Label label5;
        private Label label3;
        private TextBox txt_Product_Name;
        private Label label2;
        private Button btn_Product_Image;
        private PictureBox picture_Product;
        private Label label1;
        private TextBox txt_ProductID;
        private Button btnClose;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private TextBox txt_Description;
    }
}