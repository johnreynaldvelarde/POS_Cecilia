namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class View_Today_Sales_Form
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            data_Grid_Today = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            title_product = new Label();
            panel3 = new Panel();
            btnClose = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Today).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // data_Grid_Today
            // 
            data_Grid_Today.AllowUserToAddRows = false;
            data_Grid_Today.AllowUserToOrderColumns = true;
            data_Grid_Today.AllowUserToResizeColumns = false;
            data_Grid_Today.AllowUserToResizeRows = false;
            data_Grid_Today.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Today.BackgroundColor = Color.White;
            data_Grid_Today.BorderStyle = BorderStyle.None;
            data_Grid_Today.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Today.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Grid_Today.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Grid_Today.ColumnHeadersHeight = 50;
            data_Grid_Today.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Today.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Column2 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            data_Grid_Today.DefaultCellStyle = dataGridViewCellStyle4;
            data_Grid_Today.Dock = DockStyle.Fill;
            data_Grid_Today.EnableHeadersVisualStyles = false;
            data_Grid_Today.Location = new Point(0, 0);
            data_Grid_Today.Name = "data_Grid_Today";
            data_Grid_Today.ReadOnly = true;
            data_Grid_Today.RowHeadersVisible = false;
            data_Grid_Today.RowHeadersWidth = 50;
            data_Grid_Today.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Today.RowTemplate.Height = 40;
            data_Grid_Today.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Today.Size = new Size(880, 462);
            data_Grid_Today.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.FillWeight = 46.70051F;
            dataGridViewTextBoxColumn2.HeaderText = "#";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.FillWeight = 104.868011F;
            dataGridViewTextBoxColumn4.HeaderText = "Product Name";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.FillWeight = 92.09565F;
            dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Amount";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(data_Grid_Today);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 462);
            panel4.TabIndex = 84;
            // 
            // title_product
            // 
            title_product.AutoSize = true;
            title_product.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title_product.ForeColor = Color.FromArgb(14, 159, 104);
            title_product.Location = new Point(12, 10);
            title_product.Name = "title_product";
            title_product.Size = new Size(128, 24);
            title_product.TabIndex = 0;
            title_product.Text = "Today Sales";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 70);
            panel3.TabIndex = 83;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(846, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 27);
            btnClose.TabIndex = 80;
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
            panel2.TabIndex = 82;
            // 
            // panel1
            // 
            panel1.Controls.Add(title_product);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 45);
            panel1.TabIndex = 81;
            // 
            // View_Today_Sales_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnClose);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "View_Today_Sales_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)data_Grid_Today).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_Grid_Today;
        private Panel panel4;
        public Label title_product;
        private Panel panel3;
        private Button btnClose;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column2;
    }
}