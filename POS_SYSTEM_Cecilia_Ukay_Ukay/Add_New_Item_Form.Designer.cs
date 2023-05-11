namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Add_New_Item_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Item_Form));
            btn_Update = new Button();
            date_expiration = new DateTimePicker();
            label11 = new Label();
            label6 = new Label();
            txt_Availability = new TextBox();
            label10 = new Label();
            txt_Date_Added = new TextBox();
            cmd_Measurement = new ComboBox();
            label9 = new Label();
            label4 = new Label();
            txt_Price = new TextBox();
            label8 = new Label();
            txt_Product_Name = new TextBox();
            label7 = new Label();
            txt_Product_Code = new TextBox();
            txt_ProductID = new TextBox();
            btnClose = new Button();
            panel2 = new Panel();
            label1 = new Label();
            cmd_Category = new ComboBox();
            btn_Clear = new Button();
            btn_Save = new Button();
            label5 = new Label();
            label3 = new Label();
            txt_Description = new TextBox();
            label2 = new Label();
            btn_Product_Image = new Button();
            picture_Product = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picture_Product).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(14, 159, 104);
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(583, 547);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(145, 48);
            btn_Update.TabIndex = 94;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // date_expiration
            // 
            date_expiration.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            date_expiration.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            date_expiration.Location = new Point(623, 403);
            date_expiration.Name = "date_expiration";
            date_expiration.Size = new Size(245, 27);
            date_expiration.TabIndex = 93;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(623, 370);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 92;
            label11.Text = "Expiration Date *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(623, 283);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 91;
            label6.Text = "Quantity *";
            // 
            // txt_Availability
            // 
            txt_Availability.BorderStyle = BorderStyle.FixedSingle;
            txt_Availability.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Availability.Location = new Point(623, 318);
            txt_Availability.Name = "txt_Availability";
            txt_Availability.Size = new Size(245, 27);
            txt_Availability.TabIndex = 90;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(338, 370);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 89;
            label10.Text = "Date Added *";
            // 
            // txt_Date_Added
            // 
            txt_Date_Added.BorderStyle = BorderStyle.FixedSingle;
            txt_Date_Added.Enabled = false;
            txt_Date_Added.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Date_Added.Location = new Point(338, 405);
            txt_Date_Added.Name = "txt_Date_Added";
            txt_Date_Added.Size = new Size(245, 27);
            txt_Date_Added.TabIndex = 88;
            // 
            // cmd_Measurement
            // 
            cmd_Measurement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_Measurement.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_Measurement.FormattingEnabled = true;
            cmd_Measurement.Items.AddRange(new object[] { "Small (S)", "Medium (M)", "Large (L)", "Extra Large (XL)", "Double Extra Large (XXL)" });
            cmd_Measurement.Location = new Point(623, 483);
            cmd_Measurement.Name = "cmd_Measurement";
            cmd_Measurement.Size = new Size(245, 28);
            cmd_Measurement.TabIndex = 87;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(623, 451);
            label9.Name = "label9";
            label9.Size = new Size(170, 20);
            label9.TabIndex = 86;
            label9.Text = "Unit of measurement *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(338, 283);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 85;
            label4.Text = "Price *";
            // 
            // txt_Price
            // 
            txt_Price.BorderStyle = BorderStyle.FixedSingle;
            txt_Price.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Price.Location = new Point(338, 318);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(245, 27);
            txt_Price.TabIndex = 84;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(338, 195);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 83;
            label8.Text = "Item Name *";
            // 
            // txt_Product_Name
            // 
            txt_Product_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Product_Name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Product_Name.Location = new Point(338, 230);
            txt_Product_Name.Name = "txt_Product_Name";
            txt_Product_Name.Size = new Size(245, 27);
            txt_Product_Name.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(623, 107);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 81;
            label7.Text = "Item Code *";
            // 
            // txt_Product_Code
            // 
            txt_Product_Code.BorderStyle = BorderStyle.FixedSingle;
            txt_Product_Code.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Product_Code.Location = new Point(623, 142);
            txt_Product_Code.Name = "txt_Product_Code";
            txt_Product_Code.Size = new Size(245, 27);
            txt_Product_Code.TabIndex = 80;
            // 
            // txt_ProductID
            // 
            txt_ProductID.BorderStyle = BorderStyle.FixedSingle;
            txt_ProductID.Enabled = false;
            txt_ProductID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ProductID.Location = new Point(338, 142);
            txt_ProductID.Name = "txt_ProductID";
            txt_ProductID.Size = new Size(245, 27);
            txt_ProductID.TabIndex = 72;
            txt_ProductID.Text = "(Auto)";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(842, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 67;
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
            panel2.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(231, 24);
            label1.TabIndex = 0;
            label1.Text = "Add new item variant";
            // 
            // cmd_Category
            // 
            cmd_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_Category.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_Category.FormattingEnabled = true;
            cmd_Category.Location = new Point(338, 483);
            cmd_Category.Name = "cmd_Category";
            cmd_Category.Size = new Size(245, 28);
            cmd_Category.TabIndex = 79;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(71, 81, 86);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(741, 547);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(145, 48);
            btn_Clear.TabIndex = 78;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(14, 159, 104);
            btn_Save.Cursor = Cursors.Hand;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(422, 547);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(145, 48);
            btn_Save.TabIndex = 77;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(338, 451);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 76;
            label5.Text = "Category *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(623, 195);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 75;
            label3.Text = "Description *";
            // 
            // txt_Description
            // 
            txt_Description.BorderStyle = BorderStyle.FixedSingle;
            txt_Description.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Description.Location = new Point(623, 230);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(245, 27);
            txt_Description.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(338, 107);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 73;
            label2.Text = "Item ID *";
            // 
            // btn_Product_Image
            // 
            btn_Product_Image.BackColor = Color.FromArgb(14, 159, 104);
            btn_Product_Image.Cursor = Cursors.Hand;
            btn_Product_Image.FlatAppearance.BorderSize = 0;
            btn_Product_Image.FlatStyle = FlatStyle.Flat;
            btn_Product_Image.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Product_Image.ForeColor = Color.White;
            btn_Product_Image.Image = (Image)resources.GetObject("btn_Product_Image.Image");
            btn_Product_Image.Location = new Point(24, 396);
            btn_Product_Image.Name = "btn_Product_Image";
            btn_Product_Image.Size = new Size(277, 38);
            btn_Product_Image.TabIndex = 71;
            btn_Product_Image.Text = "Add item image";
            btn_Product_Image.TextAlign = ContentAlignment.MiddleRight;
            btn_Product_Image.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Product_Image.UseVisualStyleBackColor = false;
            // 
            // picture_Product
            // 
            picture_Product.BorderStyle = BorderStyle.FixedSingle;
            picture_Product.Location = new Point(24, 107);
            picture_Product.Name = "picture_Product";
            picture_Product.Size = new Size(277, 275);
            picture_Product.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_Product.TabIndex = 70;
            picture_Product.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 45);
            panel1.TabIndex = 68;
            // 
            // Add_New_Item_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(btn_Update);
            Controls.Add(date_expiration);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(txt_Availability);
            Controls.Add(label10);
            Controls.Add(txt_Date_Added);
            Controls.Add(cmd_Measurement);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(txt_Price);
            Controls.Add(label8);
            Controls.Add(txt_Product_Name);
            Controls.Add(label7);
            Controls.Add(txt_Product_Code);
            Controls.Add(txt_ProductID);
            Controls.Add(btnClose);
            Controls.Add(panel2);
            Controls.Add(cmd_Category);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txt_Description);
            Controls.Add(label2);
            Controls.Add(btn_Product_Image);
            Controls.Add(picture_Product);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_New_Item_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)picture_Product).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btn_Update;
        private DateTimePicker date_expiration;
        private Label label11;
        private Label label6;
        private TextBox txt_Availability;
        private Label label10;
        private TextBox txt_Date_Added;
        private ComboBox cmd_Measurement;
        private Label label9;
        private Label label4;
        private TextBox txt_Price;
        private Label label8;
        private TextBox txt_Product_Name;
        private Label label7;
        private TextBox txt_Product_Code;
        private TextBox txt_ProductID;
        private Button btnClose;
        private Panel panel2;
        private Label label1;
        private ComboBox cmd_Category;
        private Button btn_Clear;
        private Button btn_Save;
        private Label label5;
        private Label label3;
        private TextBox txt_Description;
        private Label label2;
        private Button btn_Product_Image;
        private PictureBox picture_Product;
        private Panel panel1;
    }
}