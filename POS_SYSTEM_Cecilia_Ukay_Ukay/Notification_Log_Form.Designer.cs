namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Notification_Log_Form
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
            panel1 = new Panel();
            title_product = new Label();
            data_Grid_Annual = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Annual).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(title_product);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 45);
            panel1.TabIndex = 95;
            // 
            // title_product
            // 
            title_product.AutoSize = true;
            title_product.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title_product.ForeColor = Color.FromArgb(14, 159, 104);
            title_product.Location = new Point(12, 10);
            title_product.Name = "title_product";
            title_product.Size = new Size(169, 24);
            title_product.TabIndex = 0;
            title_product.Text = "Notification Log";
            // 
            // data_Grid_Annual
            // 
            data_Grid_Annual.AllowUserToAddRows = false;
            data_Grid_Annual.AllowUserToOrderColumns = true;
            data_Grid_Annual.AllowUserToResizeColumns = false;
            data_Grid_Annual.AllowUserToResizeRows = false;
            data_Grid_Annual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Grid_Annual.BackgroundColor = Color.White;
            data_Grid_Annual.BorderStyle = BorderStyle.None;
            data_Grid_Annual.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data_Grid_Annual.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(14, 159, 104);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Grid_Annual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Grid_Annual.ColumnHeadersHeight = 50;
            data_Grid_Annual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_Grid_Annual.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Column2 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            data_Grid_Annual.DefaultCellStyle = dataGridViewCellStyle4;
            data_Grid_Annual.Dock = DockStyle.Fill;
            data_Grid_Annual.EnableHeadersVisualStyles = false;
            data_Grid_Annual.Location = new Point(10, 55);
            data_Grid_Annual.Name = "data_Grid_Annual";
            data_Grid_Annual.ReadOnly = true;
            data_Grid_Annual.RowHeadersVisible = false;
            data_Grid_Annual.RowHeadersWidth = 50;
            data_Grid_Annual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_Grid_Annual.RowTemplate.Height = 40;
            data_Grid_Annual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Grid_Annual.Size = new Size(680, 298);
            data_Grid_Annual.TabIndex = 96;
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
            // Notification_Log_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 363);
            ControlBox = false;
            Controls.Add(data_Grid_Annual);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Notification_Log_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Grid_Annual).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label title_product;
        private DataGridView data_Grid_Annual;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column2;
    }
}