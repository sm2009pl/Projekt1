namespace PROJEKT1_WinForms
{
    partial class AddCustDemoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustTypeDesc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustTypeID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer type description";
            // 
            // textBoxCustTypeDesc
            // 
            this.textBoxCustTypeDesc.Location = new System.Drawing.Point(147, 35);
            this.textBoxCustTypeDesc.MaxLength = 255;
            this.textBoxCustTypeDesc.Multiline = true;
            this.textBoxCustTypeDesc.Name = "textBoxCustTypeDesc";
            this.textBoxCustTypeDesc.ShortcutsEnabled = false;
            this.textBoxCustTypeDesc.Size = new System.Drawing.Size(147, 104);
            this.textBoxCustTypeDesc.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add customer type";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer type ID";
            // 
            // textBoxCustTypeID
            // 
            this.textBoxCustTypeID.Location = new System.Drawing.Point(147, 9);
            this.textBoxCustTypeID.MaxLength = 5;
            this.textBoxCustTypeID.Name = "textBoxCustTypeID";
            this.textBoxCustTypeID.ShortcutsEnabled = false;
            this.textBoxCustTypeID.Size = new System.Drawing.Size(48, 20);
            this.textBoxCustTypeID.TabIndex = 1;
            // 
            // AddCustDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCustTypeDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCustTypeID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCustDemoForm";
            this.Text = "Add customer type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustTypeDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustTypeID;
    }
}