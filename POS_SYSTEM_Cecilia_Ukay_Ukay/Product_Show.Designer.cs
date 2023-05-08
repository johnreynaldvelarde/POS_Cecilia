namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Product_Show
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Add_Cart = new Button();
            picture_product = new PictureBox();
            product_description = new Label();
            product_price = new Label();
            product_name = new Label();
            label4 = new Label();
            available_number = new Label();
            button1 = new Button();
            button2 = new Button();
            need_quantity = new Label();
            ((System.ComponentModel.ISupportInitialize)picture_product).BeginInit();
            SuspendLayout();
            // 
            // btn_Add_Cart
            // 
            btn_Add_Cart.BackColor = Color.FromArgb(14, 159, 104);
            btn_Add_Cart.Cursor = Cursors.Hand;
            btn_Add_Cart.FlatAppearance.BorderSize = 0;
            btn_Add_Cart.FlatStyle = FlatStyle.Flat;
            btn_Add_Cart.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add_Cart.ForeColor = Color.White;
            btn_Add_Cart.Location = new Point(339, 65);
            btn_Add_Cart.Name = "btn_Add_Cart";
            btn_Add_Cart.Size = new Size(68, 58);
            btn_Add_Cart.TabIndex = 0;
            btn_Add_Cart.Text = "Add";
            btn_Add_Cart.UseVisualStyleBackColor = false;
            // 
            // picture_product
            // 
            picture_product.BackColor = SystemColors.Control;
            picture_product.Dock = DockStyle.Left;
            picture_product.Location = new Point(10, 10);
            picture_product.Name = "picture_product";
            picture_product.Size = new Size(139, 155);
            picture_product.SizeMode = PictureBoxSizeMode.Zoom;
            picture_product.TabIndex = 1;
            picture_product.TabStop = false;
            // 
            // product_description
            // 
            product_description.AutoSize = true;
            product_description.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            product_description.Location = new Point(176, 56);
            product_description.Name = "product_description";
            product_description.Size = new Size(80, 17);
            product_description.TabIndex = 2;
            product_description.Text = "Description";
            // 
            // product_price
            // 
            product_price.AutoSize = true;
            product_price.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            product_price.ForeColor = Color.FromArgb(233, 83, 85);
            product_price.Location = new Point(368, 24);
            product_price.Name = "product_price";
            product_price.Size = new Size(39, 16);
            product_price.TabIndex = 3;
            product_price.Text = "Price";
            // 
            // product_name
            // 
            product_name.AutoSize = true;
            product_name.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            product_name.Location = new Point(176, 24);
            product_name.Name = "product_name";
            product_name.Size = new Size(99, 16);
            product_name.TabIndex = 4;
            product_name.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(176, 86);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 5;
            label4.Text = "Availability:";
            // 
            // available_number
            // 
            available_number.AutoSize = true;
            available_number.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            available_number.Location = new Point(264, 86);
            available_number.Name = "available_number";
            available_number.Size = new Size(15, 17);
            available_number.TabIndex = 6;
            available_number.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(176, 127);
            button1.Name = "button1";
            button1.Size = new Size(40, 23);
            button1.TabIndex = 7;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(251, 127);
            button2.Name = "button2";
            button2.Size = new Size(40, 23);
            button2.TabIndex = 8;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // need_quantity
            // 
            need_quantity.AutoSize = true;
            need_quantity.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            need_quantity.Location = new Point(227, 130);
            need_quantity.Name = "need_quantity";
            need_quantity.Size = new Size(15, 17);
            need_quantity.TabIndex = 9;
            need_quantity.Text = "0";
            // 
            // Product_Show
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(need_quantity);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(available_number);
            Controls.Add(label4);
            Controls.Add(product_name);
            Controls.Add(product_price);
            Controls.Add(product_description);
            Controls.Add(picture_product);
            Controls.Add(btn_Add_Cart);
            Name = "Product_Show";
            Padding = new Padding(10);
            Size = new Size(420, 175);
            ((System.ComponentModel.ISupportInitialize)picture_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Add_Cart;
        private PictureBox picture_product;
        private Label product_description;
        private Label product_price;
        private Label product_name;
        private Label label4;
        private Label available_number;
        private Button button1;
        private Button button2;
        private Label need_quantity;
    }
}
