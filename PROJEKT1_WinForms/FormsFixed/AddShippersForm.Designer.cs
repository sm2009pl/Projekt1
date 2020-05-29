namespace PROJEKT1_WinForms.FormsFixed
{
    partial class AddShippersForm
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
            this.textBoxShipName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShipPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShipName
            // 
            this.textBoxShipName.Location = new System.Drawing.Point(108, 12);
            this.textBoxShipName.MaxLength = 50;
            this.textBoxShipName.Name = "textBoxShipName";
            this.textBoxShipName.ShortcutsEnabled = false;
            this.textBoxShipName.Size = new System.Drawing.Size(314, 20);
            this.textBoxShipName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Company name";
            // 
            // textBoxShipPhone
            // 
            this.textBoxShipPhone.Location = new System.Drawing.Point(108, 38);
            this.textBoxShipPhone.MaxLength = 24;
            this.textBoxShipPhone.Name = "textBoxShipPhone";
            this.textBoxShipPhone.ShortcutsEnabled = false;
            this.textBoxShipPhone.Size = new System.Drawing.Size(158, 20);
            this.textBoxShipPhone.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Phone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 36);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add shipper";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddShippersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 108);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxShipPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxShipName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddShippersForm";
            this.Text = "Add shipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxShipName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShipPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}