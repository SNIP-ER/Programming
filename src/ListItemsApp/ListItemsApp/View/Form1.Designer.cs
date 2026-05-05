namespace ListItemsApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NameItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TranslateComboBox = new System.Windows.Forms.ComboBox();
            this.ItemInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameItemsListBox
            // 
            this.NameItemsListBox.FormattingEnabled = true;
            this.NameItemsListBox.Location = new System.Drawing.Point(12, 12);
            this.NameItemsListBox.Name = "NameItemsListBox";
            this.NameItemsListBox.Size = new System.Drawing.Size(248, 329);
            this.NameItemsListBox.TabIndex = 0;
            // 
            // ItemInfoGroupBox
            // 
            this.ItemInfoGroupBox.Controls.Add(this.textBox3);
            this.ItemInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ItemInfoGroupBox.Controls.Add(this.NameTextBox);
            this.ItemInfoGroupBox.Controls.Add(this.CountLabel);
            this.ItemInfoGroupBox.Controls.Add(this.CategoryLabel);
            this.ItemInfoGroupBox.Controls.Add(this.CategoryComboBox);
            this.ItemInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ItemInfoGroupBox.Controls.Add(this.NameLabel);
            this.ItemInfoGroupBox.Location = new System.Drawing.Point(285, 12);
            this.ItemInfoGroupBox.Name = "ItemInfoGroupBox";
            this.ItemInfoGroupBox.Size = new System.Drawing.Size(448, 157);
            this.ItemInfoGroupBox.TabIndex = 1;
            this.ItemInfoGroupBox.TabStop = false;
            this.ItemInfoGroupBox.Text = "Selected Item";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(131, 57);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(295, 20);
            this.ManufacturerTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(131, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(295, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLabel.Location = new System.Drawing.Point(34, 124);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(41, 16);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "Count";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(25, 89);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(62, 16);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(212, 88);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 2;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(16, 58);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(84, 16);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(34, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // TranslateComboBox
            // 
            this.TranslateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TranslateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TranslateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranslateComboBox.FormattingEnabled = true;
            this.TranslateComboBox.Items.AddRange(new object[] {
            "ENG",
            "RUS"});
            this.TranslateComboBox.Location = new System.Drawing.Point(667, 319);
            this.TranslateComboBox.Name = "TranslateComboBox";
            this.TranslateComboBox.Size = new System.Drawing.Size(68, 21);
            this.TranslateComboBox.TabIndex = 2;
            this.TranslateComboBox.SelectedIndexChanged += new System.EventHandler(this.TranslateComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 352);
            this.Controls.Add(this.TranslateComboBox);
            this.Controls.Add(this.ItemInfoGroupBox);
            this.Controls.Add(this.NameItemsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ListItemApp";
            this.ItemInfoGroupBox.ResumeLayout(false);
            this.ItemInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox NameItemsListBox;
        private System.Windows.Forms.GroupBox ItemInfoGroupBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox TranslateComboBox;
    }
}

