namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    partial class Popup_Category
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
            category_name = new Label();
            SuspendLayout();
            // 
            // category_name
            // 
            category_name.AutoSize = true;
            category_name.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            category_name.ForeColor = Color.White;
            category_name.Location = new Point(15, 15);
            category_name.Name = "category_name";
            category_name.Size = new Size(68, 16);
            category_name.TabIndex = 0;
            category_name.Text = "Category";
            // 
            // Popup_Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 159, 104);
            Controls.Add(category_name);
            Cursor = Cursors.Hand;
            Name = "Popup_Category";
            Size = new Size(131, 47);
            Click += Popup_Category_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label category_name;
    }
}
