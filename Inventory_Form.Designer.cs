namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Inventory_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Product_List = new System.Windows.Forms.Button();
            this.btn_Category_List = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(159)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(159)))), ((int)(((byte)(104)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 3);
            this.panel2.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1043, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 27);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 60);
            this.panel1.TabIndex = 15;
            // 
            // btn_Product_List
            // 
            this.btn_Product_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(159)))), ((int)(((byte)(104)))));
            this.btn_Product_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product_List.FlatAppearance.BorderSize = 0;
            this.btn_Product_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product_List.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Product_List.ForeColor = System.Drawing.Color.White;
            this.btn_Product_List.Image = ((System.Drawing.Image)(resources.GetObject("btn_Product_List.Image")));
            this.btn_Product_List.Location = new System.Drawing.Point(12, 11);
            this.btn_Product_List.Name = "btn_Product_List";
            this.btn_Product_List.Size = new System.Drawing.Size(184, 38);
            this.btn_Product_List.TabIndex = 14;
            this.btn_Product_List.Text = "Product List";
            this.btn_Product_List.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Product_List.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Product_List.UseVisualStyleBackColor = false;
            this.btn_Product_List.Click += new System.EventHandler(this.btn_Product_List_Click_1);
            // 
            // btn_Category_List
            // 
            this.btn_Category_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(159)))), ((int)(((byte)(104)))));
            this.btn_Category_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Category_List.FlatAppearance.BorderSize = 0;
            this.btn_Category_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Category_List.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Category_List.ForeColor = System.Drawing.Color.White;
            this.btn_Category_List.Image = ((System.Drawing.Image)(resources.GetObject("btn_Category_List.Image")));
            this.btn_Category_List.Location = new System.Drawing.Point(224, 11);
            this.btn_Category_List.Name = "btn_Category_List";
            this.btn_Category_List.Size = new System.Drawing.Size(197, 38);
            this.btn_Category_List.TabIndex = 15;
            this.btn_Category_List.Text = "Category List";
            this.btn_Category_List.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Category_List.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Category_List.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Category_List);
            this.panel3.Controls.Add(this.btn_Product_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 60);
            this.panel3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(367, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // Inventory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventory_Form";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button btnClose;
        private Panel panel1;
        public Button btn_Product_List;
        private Button btn_Category_List;
        private Panel panel3;
        private DataGridView dataGridView1;
    }
}