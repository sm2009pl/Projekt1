namespace PROJEKT1_WinForms
{
    partial class AddCategoriesForm
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
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.textBoxCatDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.Location = new System.Drawing.Point(96, 12);
            this.textBoxCatName.MaxLength = 15;
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.ShortcutsEnabled = false;
            this.textBoxCatName.Size = new System.Drawing.Size(165, 20);
            this.textBoxCatName.TabIndex = 1;
            // 
            // textBoxCatDesc
            // 
            this.textBoxCatDesc.Location = new System.Drawing.Point(96, 38);
            this.textBoxCatDesc.MaxLength = 255;
            this.textBoxCatDesc.Multiline = true;
            this.textBoxCatDesc.Name = "textBoxCatDesc";
            this.textBoxCatDesc.ShortcutsEnabled = false;
            this.textBoxCatDesc.Size = new System.Drawing.Size(173, 124);
            this.textBoxCatDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCatDesc);
            this.Controls.Add(this.textBoxCatName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCategoriesForm";
            this.Text = "Add category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCatName;
        private System.Windows.Forms.TextBox textBoxCatDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}