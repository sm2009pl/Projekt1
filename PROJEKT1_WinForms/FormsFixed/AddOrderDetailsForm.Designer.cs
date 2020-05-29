namespace PROJEKT1_WinForms.FormsFixed
{
    partial class AddOrderDetailsForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOrdDetQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOrdDetUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrdDetName = new System.Windows.Forms.TextBox();
            this.comboBoxProductID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOrderID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOrdDetDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Quantity";
            // 
            // textBoxOrdDetQuantity
            // 
            this.textBoxOrdDetQuantity.Location = new System.Drawing.Point(103, 118);
            this.textBoxOrdDetQuantity.MaxLength = 10;
            this.textBoxOrdDetQuantity.Name = "textBoxOrdDetQuantity";
            this.textBoxOrdDetQuantity.ShortcutsEnabled = false;
            this.textBoxOrdDetQuantity.Size = new System.Drawing.Size(88, 20);
            this.textBoxOrdDetQuantity.TabIndex = 69;
            this.textBoxOrdDetQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProdUnitPriceForInt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Unit price";
            // 
            // textBoxOrdDetUnitPrice
            // 
            this.textBoxOrdDetUnitPrice.Location = new System.Drawing.Point(103, 92);
            this.textBoxOrdDetUnitPrice.MaxLength = 10;
            this.textBoxOrdDetUnitPrice.Name = "textBoxOrdDetUnitPrice";
            this.textBoxOrdDetUnitPrice.ShortcutsEnabled = false;
            this.textBoxOrdDetUnitPrice.Size = new System.Drawing.Size(88, 20);
            this.textBoxOrdDetUnitPrice.TabIndex = 67;
            this.textBoxOrdDetUnitPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxOrdDetUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrdPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Product name";
            // 
            // textBoxOrdDetName
            // 
            this.textBoxOrdDetName.Enabled = false;
            this.textBoxOrdDetName.Location = new System.Drawing.Point(103, 66);
            this.textBoxOrdDetName.MaxLength = 40;
            this.textBoxOrdDetName.Name = "textBoxOrdDetName";
            this.textBoxOrdDetName.ShortcutsEnabled = false;
            this.textBoxOrdDetName.Size = new System.Drawing.Size(254, 20);
            this.textBoxOrdDetName.TabIndex = 65;
            // 
            // comboBoxProductID
            // 
            this.comboBoxProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductID.FormattingEnabled = true;
            this.comboBoxProductID.Location = new System.Drawing.Point(103, 39);
            this.comboBoxProductID.Name = "comboBoxProductID";
            this.comboBoxProductID.Size = new System.Drawing.Size(88, 21);
            this.comboBoxProductID.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Product ID";
            // 
            // comboBoxOrderID
            // 
            this.comboBoxOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderID.FormattingEnabled = true;
            this.comboBoxOrderID.Location = new System.Drawing.Point(103, 12);
            this.comboBoxOrderID.Name = "comboBoxOrderID";
            this.comboBoxOrderID.Size = new System.Drawing.Size(88, 21);
            this.comboBoxOrderID.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Order ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 40);
            this.button1.TabIndex = 73;
            this.button1.Text = "Add order detail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOrdDetDiscount
            // 
            this.textBoxOrdDetDiscount.Location = new System.Drawing.Point(103, 144);
            this.textBoxOrdDetDiscount.MaxLength = 2;
            this.textBoxOrdDetDiscount.Name = "textBoxOrdDetDiscount";
            this.textBoxOrdDetDiscount.ShortcutsEnabled = false;
            this.textBoxOrdDetDiscount.Size = new System.Drawing.Size(34, 20);
            this.textBoxOrdDetDiscount.TabIndex = 74;
            this.textBoxOrdDetDiscount.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBoxOrdDetDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrdPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "%";
            // 
            // AddOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 248);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxOrdDetDiscount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOrdDetQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOrdDetUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrdDetName);
            this.Controls.Add(this.comboBoxProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOrderID);
            this.Controls.Add(this.label1);
            this.Name = "AddOrderDetailsForm";
            this.Text = "Add order detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOrdDetQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOrdDetUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrdDetName;
        private System.Windows.Forms.ComboBox comboBoxProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxOrdDetDiscount;
        private System.Windows.Forms.Label label7;
    }
}