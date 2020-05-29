namespace PROJEKT1_WinForms.FormsFixed
{
    partial class AddTerritoriesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTerrDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRegionID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxTerritoryID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Region ID";
            // 
            // textBoxTerrDesc
            // 
            this.textBoxTerrDesc.Location = new System.Drawing.Point(121, 43);
            this.textBoxTerrDesc.MaxLength = 255;
            this.textBoxTerrDesc.Multiline = true;
            this.textBoxTerrDesc.Name = "textBoxTerrDesc";
            this.textBoxTerrDesc.ShortcutsEnabled = false;
            this.textBoxTerrDesc.Size = new System.Drawing.Size(227, 94);
            this.textBoxTerrDesc.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Territory description";
            // 
            // comboBoxRegionID
            // 
            this.comboBoxRegionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegionID.FormattingEnabled = true;
            this.comboBoxRegionID.Location = new System.Drawing.Point(121, 146);
            this.comboBoxRegionID.Name = "comboBoxRegionID";
            this.comboBoxRegionID.Size = new System.Drawing.Size(74, 21);
            this.comboBoxRegionID.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "Add territory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Territory ID";
            // 
            // textBoxTerritoryID
            // 
            this.textBoxTerritoryID.Location = new System.Drawing.Point(121, 17);
            this.textBoxTerritoryID.MaxLength = 5;
            this.textBoxTerritoryID.Name = "textBoxTerritoryID";
            this.textBoxTerritoryID.ShortcutsEnabled = false;
            this.textBoxTerritoryID.Size = new System.Drawing.Size(55, 20);
            this.textBoxTerritoryID.TabIndex = 31;
            // 
            // AddTerritoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxRegionID);
            this.Controls.Add(this.textBoxTerrDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTerritoryID);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTerritoriesForm";
            this.Text = "Add territory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTerrDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRegionID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxTerritoryID;
    }
}