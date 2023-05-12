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
            product_category = new Label();
            product_price = new Label();
            product_name = new Label();
            label4 = new Label();
            product_quantity = new Label();
            button1 = new Button();
            button2 = new Button();
            need_quantity = new Label();
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
            btn_Add_Cart.Location = new Point(242, 68);
            btn_Add_Cart.Name = "btn_Add_Cart";
            btn_Add_Cart.Size = new Size(68, 58);
            btn_Add_Cart.TabIndex = 0;
            btn_Add_Cart.Text = "Add";
            btn_Add_Cart.UseVisualStyleBackColor = false;
            // 
            // product_category
            // 
            product_category.AutoSize = true;
            product_category.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            product_category.Location = new Point(31, 57);
            product_category.Name = "product_category";
            product_category.Size = new Size(69, 17);
            product_category.TabIndex = 2;
            product_category.Text = "Category";
            // 
            // product_price
            // 
            product_price.AutoSize = true;
            product_price.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            product_price.ForeColor = Color.FromArgb(233, 83, 85);
            product_price.Location = new Point(271, 25);
            product_price.Name = "product_price";
            product_price.Size = new Size(39, 16);
            product_price.TabIndex = 3;
            product_price.Text = "Price";
            // 
            // product_name
            // 
            product_name.AutoSize = true;
            product_name.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            product_name.Location = new Point(31, 25);
            product_name.Name = "product_name";
            product_name.Size = new Size(99, 16);
            product_name.TabIndex = 4;
            product_name.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 89);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 5;
            label4.Text = "Available:";
            // 
            // product_quantity
            // 
            product_quantity.AutoSize = true;
            product_quantity.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            product_quantity.Location = new Point(111, 89);
            product_quantity.Name = "product_quantity";
            product_quantity.Size = new Size(15, 17);
            product_quantity.TabIndex = 6;
            product_quantity.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(31, 128);
            button1.Name = "button1";
            button1.Size = new Size(40, 23);
            button1.TabIndex = 7;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(106, 128);
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
            need_quantity.Location = new Point(82, 131);
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
            Controls.Add(product_quantity);
            Controls.Add(label4);
            Controls.Add(product_name);
            Controls.Add(product_price);
            Controls.Add(product_category);
            Controls.Add(btn_Add_Cart);
            Name = "Product_Show";
            Padding = new Padding(10);
            Size = new Size(336, 175);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Add_Cart;
        private Label product_category;
        private Label product_price;
        private Label product_name;
        private Label label4;
        private Label product_quantity;
        private Button button1;
        private Button button2;
        private Label need_quantity;
    }
}
