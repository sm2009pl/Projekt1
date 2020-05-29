namespace PROJEKT1_WinForms.FormsFixed
{
    partial class AddProductsForm
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
            this.textBoxProdQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProdUnitsInStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSupplierID = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoryID = new System.Windows.Forms.ComboBox();
            this.checkBoxProdDiscontinued = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxProdUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxProdQuantityPerUnit
            // 
            this.textBoxProdQuantityPerUnit.Location = new System.Drawing.Point(122, 92);
            this.textBoxProdQuantityPerUnit.MaxLength = 255;
            this.textBoxProdQuantityPerUnit.Multiline = true;
            this.textBoxProdQuantityPerUnit.Name = "textBoxProdQuantityPerUnit";
            this.textBoxProdQuantityPerUnit.ShortcutsEnabled = false;
            this.textBoxProdQuantityPerUnit.Size = new System.Drawing.Size(145, 81);
            this.textBoxProdQuantityPerUnit.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Supplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Category ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Quantity per unit";
            // 
            // textBoxProdUnitsInStock
            // 
            this.textBoxProdUnitsInStock.Location = new System.Drawing.Point(122, 205);
            this.textBoxProdUnitsInStock.MaxLength = 10;
            this.textBoxProdUnitsInStock.Name = "textBoxProdUnitsInStock";
            this.textBoxProdUnitsInStock.ShortcutsEnabled = false;
            this.textBoxProdUnitsInStock.Size = new System.Drawing.Size(88, 20);
            this.textBoxProdUnitsInStock.TabIndex = 39;
            this.textBoxProdUnitsInStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProdUnitPriceForInt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Unit price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Units in stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Discontinued";
            // 
            // comboBoxSupplierID
            // 
            this.comboBoxSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplierID.FormattingEnabled = true;
            this.comboBoxSupplierID.Location = new System.Drawing.Point(122, 38);
            this.comboBoxSupplierID.Name = "comboBoxSupplierID";
            this.comboBoxSupplierID.Size = new System.Drawing.Size(73, 21);
            this.comboBoxSupplierID.TabIndex = 48;
            // 
            // comboBoxCategoryID
            // 
            this.comboBoxCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryID.FormattingEnabled = true;
            this.comboBoxCategoryID.Location = new System.Drawing.Point(122, 65);
            this.comboBoxCategoryID.Name = "comboBoxCategoryID";
            this.comboBoxCategoryID.Size = new System.Drawing.Size(73, 21);
            this.comboBoxCategoryID.TabIndex = 49;
            // 
            // checkBoxProdDiscontinued
            // 
            this.checkBoxProdDiscontinued.AutoSize = true;
            this.checkBoxProdDiscontinued.Location = new System.Drawing.Point(122, 231);
            this.checkBoxProdDiscontinued.Name = "checkBoxProdDiscontinued";
            this.checkBoxProdDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.checkBoxProdDiscontinued.TabIndex = 50;
            this.checkBoxProdDiscontinued.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 40);
            this.button1.TabIndex = 57;
            this.button1.Text = "Add product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxProdUnitPrice
            // 
            this.textBoxProdUnitPrice.Location = new System.Drawing.Point(122, 179);
            this.textBoxProdUnitPrice.MaxLength = 10;
            this.textBoxProdUnitPrice.Name = "textBoxProdUnitPrice";
            this.textBoxProdUnitPrice.ShortcutsEnabled = false;
            this.textBoxProdUnitPrice.Size = new System.Drawing.Size(88, 20);
            this.textBoxProdUnitPrice.TabIndex = 79;
            this.textBoxProdUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProdUnitPrice_KeyPress);
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(122, 12);
            this.textBoxProdName.MaxLength = 40;
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.ShortcutsEnabled = false;
            this.textBoxProdName.Size = new System.Drawing.Size(235, 20);
            this.textBoxProdName.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Product Name";
            // 
            // AddProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 302);
            this.Controls.Add(this.textBoxProdName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxProdUnitPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxProdDiscontinued);
            this.Controls.Add(this.comboBoxCategoryID);
            this.Controls.Add(this.comboBoxSupplierID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProdUnitsInStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProdQuantityPerUnit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProductsForm";
            this.Text = "Add product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxProdQuantityPerUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProdUnitsInStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSupplierID;
        private System.Windows.Forms.ComboBox comboBoxCategoryID;
        private System.Windows.Forms.CheckBox checkBoxProdDiscontinued;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxProdUnitPrice;
        private System.Windows.Forms.TextBox textBoxProdName;
        private System.Windows.Forms.Label label9;
    }
}