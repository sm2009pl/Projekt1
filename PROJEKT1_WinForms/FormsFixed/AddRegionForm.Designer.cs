namespace PROJEKT1_WinForms.FormsFixed
{
    partial class AddRegionForm
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
            this.textBoxRegDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRegDesc
            // 
            this.textBoxRegDesc.Location = new System.Drawing.Point(112, 12);
            this.textBoxRegDesc.Multiline = true;
            this.textBoxRegDesc.Name = "textBoxRegDesc";
            this.textBoxRegDesc.ShortcutsEnabled = false;
            this.textBoxRegDesc.Size = new System.Drawing.Size(153, 118);
            this.textBoxRegDesc.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Region description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 34);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add region";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRegDesc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRegionForm";
            this.Text = "Add region";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRegDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}