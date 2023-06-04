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
            btn_Update = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            label1 = new Label();
            btn_Clear = new Button();
            btn_Save = new Button();
            panel1 = new Panel();
            label6 = new Label();
            txt_Date_Added = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_Price = new TextBox();
            label2 = new Label();
            txt_Item_Name = new TextBox();
            cmd_Piece = new ComboBox();
            label5 = new Label();
            txt_Item_Code = new TextBox();
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
            btn_Update.Location = new Point(587, 543);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(145, 48);
            btn_Update.TabIndex = 94;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(845, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 67;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
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
            label1.Size = new Size(161, 24);
            label1.TabIndex = 0;
            label1.Text = "Add new item ";
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(71, 81, 86);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(745, 543);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(145, 48);
            btn_Clear.TabIndex = 78;
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
            btn_Save.Location = new Point(426, 543);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(145, 48);
            btn_Save.TabIndex = 77;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(266, 426);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 102;
            label6.Text = "Date Added *";
            // 
            // txt_Date_Added
            // 
            txt_Date_Added.BorderStyle = BorderStyle.FixedSingle;
            txt_Date_Added.Enabled = false;
            txt_Date_Added.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Date_Added.Location = new Point(266, 461);
            txt_Date_Added.Name = "txt_Date_Added";
            txt_Date_Added.Size = new Size(400, 29);
            txt_Date_Added.TabIndex = 101;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(266, 339);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 100;
            label4.Text = "Per Piece *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(266, 254);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 98;
            label3.Text = "Price *";
            // 
            // txt_Price
            // 
            txt_Price.BorderStyle = BorderStyle.FixedSingle;
            txt_Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Price.Location = new Point(266, 289);
            txt_Price.Multiline = true;
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(400, 29);
            txt_Price.TabIndex = 97;
            txt_Price.KeyPress += txt_Price_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(266, 172);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 96;
            label2.Text = "Item Name *";
            // 
            // txt_Item_Name
            // 
            txt_Item_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Item_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Item_Name.Location = new Point(266, 207);
            txt_Item_Name.Name = "txt_Item_Name";
            txt_Item_Name.Size = new Size(400, 29);
            txt_Item_Name.TabIndex = 95;
            // 
            // cmd_Piece
            // 
            cmd_Piece.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd_Piece.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmd_Piece.FormattingEnabled = true;
            cmd_Piece.Items.AddRange(new object[] { "50", "100", "150", "200", "250", "300", "350", "400", "450", "500" });
            cmd_Piece.Location = new Point(266, 373);
            cmd_Piece.Name = "cmd_Piece";
            cmd_Piece.Size = new Size(400, 29);
            cmd_Piece.TabIndex = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(266, 92);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 105;
            label5.Text = "Item Code *";
            // 
            // txt_Item_Code
            // 
            txt_Item_Code.BorderStyle = BorderStyle.FixedSingle;
            txt_Item_Code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Item_Code.Location = new Point(266, 127);
            txt_Item_Code.Name = "txt_Item_Code";
            txt_Item_Code.Size = new Size(400, 29);
            txt_Item_Code.TabIndex = 104;
            // 
            // Add_New_Item_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(txt_Item_Code);
            Controls.Add(cmd_Piece);
            Controls.Add(label6);
            Controls.Add(txt_Date_Added);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Price);
            Controls.Add(label2);
            Controls.Add(txt_Item_Name);
            Controls.Add(btn_Update);
            Controls.Add(btnClose);
            Controls.Add(panel2);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_New_Item_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Add_New_Item_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btn_Update;
        private Button btnClose;
        private Panel panel2;
        private Label label1;
        private Button btn_Clear;
        private Button btn_Save;
        private Panel panel1;
        private Label label6;
        private TextBox txt_Date_Added;
        private Label label4;
        private Label label3;
        private TextBox txt_Price;
        private Label label2;
        private TextBox txt_Item_Name;
        private ComboBox cmd_Piece;
        private Label label5;
        private TextBox txt_Item_Code;
    }
}