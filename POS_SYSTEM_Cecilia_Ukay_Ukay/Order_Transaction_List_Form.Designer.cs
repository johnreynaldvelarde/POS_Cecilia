namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Order_Transaction_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Transaction_List_Form));
            data_Grid_Order_Transaction = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            panel1 = new Panel();
            btn_Export = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Order_Transaction).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // data_Grid_Order_Transaction
            // 
            data_Grid_Order_Transaction.AllowUserToAddRows = false;
            data_Grid_Order_Transaction.AllowUserToOrderColumns = true;
            data_Grid_Order_Transaction.AllowUserToResizeColumns = false;
            data_Grid_Order_Transaction.AllowUserToResizeRows = false;
            data_Grid_Order_Transaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Order_Transaction.BackgroundColor = Color.White;
            data_Grid_Order_Transaction.BorderStyle = BorderStyle.None;
            data_Grid_Order_Transaction.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Order_Transaction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Grid_Order_Transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Grid_Order_Transaction.ColumnHeadersHeight = 50;
            data_Grid_Order_Transaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Order_Transaction.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3, Column4, View });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            data_Grid_Order_Transaction.DefaultCellStyle = dataGridViewCellStyle4;
            data_Grid_Order_Transaction.Dock = DockStyle.Fill;
            data_Grid_Order_Transaction.EnableHeadersVisualStyles = false;
            data_Grid_Order_Transaction.Location = new Point(5, 88);
            data_Grid_Order_Transaction.Name = "data_Grid_Order_Transaction";
            data_Grid_Order_Transaction.ReadOnly = true;
            data_Grid_Order_Transaction.RowHeadersVisible = false;
            data_Grid_Order_Transaction.RowHeadersWidth = 50;
            data_Grid_Order_Transaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Order_Transaction.RowTemplate.Height = 40;
            data_Grid_Order_Transaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Order_Transaction.Size = new Size(1088, 492);
            data_Grid_Order_Transaction.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 60F;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Retailer Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Transaction Date";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Total Quantity";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total Amount";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // View
            // 
            View.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            View.HeaderText = "";
            View.Image = (Image)resources.GetObject("View.Image");
            View.MinimumWidth = 50;
            View.Name = "View";
            View.ReadOnly = true;
            View.Width = 50;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Export);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 5;
            // 
            // btn_Export
            // 
            btn_Export.BackColor = Color.FromArgb(14, 159, 104);
            btn_Export.Cursor = Cursors.Hand;
            btn_Export.FlatAppearance.BorderSize = 0;
            btn_Export.FlatStyle = FlatStyle.Flat;
            btn_Export.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Export.ForeColor = Color.White;
            btn_Export.Image = (Image)resources.GetObject("btn_Export.Image");
            btn_Export.Location = new Point(908, 9);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(159, 38);
            btn_Export.TabIndex = 16;
            btn_Export.Text = "Excel Export";
            btn_Export.TextAlign = ContentAlignment.MiddleRight;
            btn_Export.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Export.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 159, 104);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(246, 33);
            label1.TabIndex = 1;
            label1.Text = "Order Transaction";
            // 
            // Order_Transaction_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 585);
            ControlBox = false;
            Controls.Add(data_Grid_Order_Transaction);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Order_Transaction_List_Form";
            Padding = new Padding(5, 20, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)data_Grid_Order_Transaction).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_Grid_Order_Transaction;
        private Panel panel1;
        private Button btn_Export;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn View;
    }
}