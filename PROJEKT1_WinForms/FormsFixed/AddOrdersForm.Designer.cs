namespace PROJEKT1_WinForms.FormsFixed
{
    partial class AddOrdersForm
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
            this.textBoxOrdShipTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrdShipAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOrdShipCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOrdShipRegion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOrdShipPostalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOrdShipCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxCustomerID = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.comboBoxShipperID = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRequired = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerShipped = new System.Windows.Forms.DateTimePicker();
            this.textBoxOrdFreight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer ID";
            // 
            // textBoxOrdShipTo
            // 
            this.textBoxOrdShipTo.Location = new System.Drawing.Point(132, 194);
            this.textBoxOrdShipTo.MaxLength = 40;
            this.textBoxOrdShipTo.Name = "textBoxOrdShipTo";
            this.textBoxOrdShipTo.ShortcutsEnabled = false;
            this.textBoxOrdShipTo.Size = new System.Drawing.Size(221, 20);
            this.textBoxOrdShipTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee ID";
            // 
            // textBoxOrdShipAddress
            // 
            this.textBoxOrdShipAddress.Location = new System.Drawing.Point(132, 220);
            this.textBoxOrdShipAddress.MaxLength = 60;
            this.textBoxOrdShipAddress.Name = "textBoxOrdShipAddress";
            this.textBoxOrdShipAddress.ShortcutsEnabled = false;
            this.textBoxOrdShipAddress.Size = new System.Drawing.Size(314, 20);
            this.textBoxOrdShipAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order date";
            // 
            // textBoxOrdShipCity
            // 
            this.textBoxOrdShipCity.Location = new System.Drawing.Point(132, 246);
            this.textBoxOrdShipCity.MaxLength = 15;
            this.textBoxOrdShipCity.Name = "textBoxOrdShipCity";
            this.textBoxOrdShipCity.ShortcutsEnabled = false;
            this.textBoxOrdShipCity.Size = new System.Drawing.Size(120, 20);
            this.textBoxOrdShipCity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Required date";
            // 
            // textBoxOrdShipRegion
            // 
            this.textBoxOrdShipRegion.Location = new System.Drawing.Point(132, 271);
            this.textBoxOrdShipRegion.MaxLength = 15;
            this.textBoxOrdShipRegion.Name = "textBoxOrdShipRegion";
            this.textBoxOrdShipRegion.ShortcutsEnabled = false;
            this.textBoxOrdShipRegion.Size = new System.Drawing.Size(120, 20);
            this.textBoxOrdShipRegion.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Shipped date";
            // 
            // textBoxOrdShipPostalCode
            // 
            this.textBoxOrdShipPostalCode.Location = new System.Drawing.Point(132, 297);
            this.textBoxOrdShipPostalCode.MaxLength = 10;
            this.textBoxOrdShipPostalCode.Name = "textBoxOrdShipPostalCode";
            this.textBoxOrdShipPostalCode.ShortcutsEnabled = false;
            this.textBoxOrdShipPostalCode.Size = new System.Drawing.Size(88, 20);
            this.textBoxOrdShipPostalCode.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Shipped via";
            // 
            // textBoxOrdShipCountry
            // 
            this.textBoxOrdShipCountry.Location = new System.Drawing.Point(132, 323);
            this.textBoxOrdShipCountry.MaxLength = 15;
            this.textBoxOrdShipCountry.Name = "textBoxOrdShipCountry";
            this.textBoxOrdShipCountry.ShortcutsEnabled = false;
            this.textBoxOrdShipCountry.Size = new System.Drawing.Size(120, 20);
            this.textBoxOrdShipCountry.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Freight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Shipped to";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Shipping address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Shipping city";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Shipping region";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Shipping postal code";
            // 
            // comboBoxCustomerID
            // 
            this.comboBoxCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerID.FormattingEnabled = true;
            this.comboBoxCustomerID.Location = new System.Drawing.Point(132, 9);
            this.comboBoxCustomerID.Name = "comboBoxCustomerID";
            this.comboBoxCustomerID.Size = new System.Drawing.Size(63, 21);
            this.comboBoxCustomerID.TabIndex = 27;
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(132, 36);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(63, 21);
            this.comboBoxEmployeeID.TabIndex = 28;
            // 
            // comboBoxShipperID
            // 
            this.comboBoxShipperID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShipperID.FormattingEnabled = true;
            this.comboBoxShipperID.Location = new System.Drawing.Point(132, 141);
            this.comboBoxShipperID.Name = "comboBoxShipperID";
            this.comboBoxShipperID.Size = new System.Drawing.Size(63, 21);
            this.comboBoxShipperID.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Shipping country";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(396, 38);
            this.button3.TabIndex = 33;
            this.button3.Text = "Add order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(131, 63);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerOrder.TabIndex = 34;
            // 
            // dateTimePickerRequired
            // 
            this.dateTimePickerRequired.Location = new System.Drawing.Point(131, 89);
            this.dateTimePickerRequired.Name = "dateTimePickerRequired";
            this.dateTimePickerRequired.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerRequired.TabIndex = 35;
            // 
            // dateTimePickerShipped
            // 
            this.dateTimePickerShipped.Location = new System.Drawing.Point(131, 115);
            this.dateTimePickerShipped.Name = "dateTimePickerShipped";
            this.dateTimePickerShipped.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerShipped.TabIndex = 36;
            // 
            // textBoxOrdFreight
            // 
            this.textBoxOrdFreight.Location = new System.Drawing.Point(131, 168);
            this.textBoxOrdFreight.MaxLength = 10;
            this.textBoxOrdFreight.Name = "textBoxOrdFreight";
            this.textBoxOrdFreight.ShortcutsEnabled = false;
            this.textBoxOrdFreight.Size = new System.Drawing.Size(88, 20);
            this.textBoxOrdFreight.TabIndex = 79;
            this.textBoxOrdFreight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrderPrice_KeyPress);
            // 
            // AddOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 403);
            this.Controls.Add(this.textBoxOrdFreight);
            this.Controls.Add(this.dateTimePickerShipped);
            this.Controls.Add(this.dateTimePickerRequired);
            this.Controls.Add(this.dateTimePickerOrder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxShipperID);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.comboBoxCustomerID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxOrdShipCountry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxOrdShipPostalCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxOrdShipRegion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOrdShipCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOrdShipAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOrdShipTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddOrdersForm";
            this.Text = "Add order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrdShipTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrdShipAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOrdShipCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOrdShipRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOrdShipPostalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOrdShipCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCustomerID;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.ComboBox comboBoxShipperID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequired;
        private System.Windows.Forms.DateTimePicker dateTimePickerShipped;
        private System.Windows.Forms.TextBox textBoxOrdFreight;
    }
}