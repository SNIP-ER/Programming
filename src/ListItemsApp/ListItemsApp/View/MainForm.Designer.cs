namespace ListItemsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NameItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.RemPictureBox = new System.Windows.Forms.PictureBox();
            this.ItemInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameItemsListBox
            // 
            resources.ApplyResources(this.NameItemsListBox, "NameItemsListBox");
            this.NameItemsListBox.FormattingEnabled = true;
            this.NameItemsListBox.Name = "NameItemsListBox";
            this.NameItemsListBox.SelectedIndexChanged += new System.EventHandler(this.NameItemsListBox_SelectedIndexChanged);
            // 
            // ItemInfoGroupBox
            // 
            resources.ApplyResources(this.ItemInfoGroupBox, "ItemInfoGroupBox");
            this.ItemInfoGroupBox.Controls.Add(this.CountTextBox);
            this.ItemInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ItemInfoGroupBox.Controls.Add(this.NameTextBox);
            this.ItemInfoGroupBox.Controls.Add(this.CountLabel);
            this.ItemInfoGroupBox.Controls.Add(this.CategoryLabel);
            this.ItemInfoGroupBox.Controls.Add(this.CategoryComboBox);
            this.ItemInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ItemInfoGroupBox.Controls.Add(this.NameLabel);
            this.ItemInfoGroupBox.Name = "ItemInfoGroupBox";
            this.ItemInfoGroupBox.TabStop = false;
            // 
            // CountTextBox
            // 
            resources.ApplyResources(this.CountTextBox, "CountTextBox");
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Leave += new System.EventHandler(this.CountTextBox_Leave);
            // 
            // ManufacturerTextBox
            // 
            resources.ApplyResources(this.ManufacturerTextBox, "ManufacturerTextBox");
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Leave += new System.EventHandler(this.ManufacturerTextBox_Leave);
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // CountLabel
            // 
            resources.ApplyResources(this.CountLabel, "CountLabel");
            this.CountLabel.Name = "CountLabel";
            // 
            // CategoryLabel
            // 
            resources.ApplyResources(this.CategoryLabel, "CategoryLabel");
            this.CategoryLabel.Name = "CategoryLabel";
            // 
            // CategoryComboBox
            // 
            resources.ApplyResources(this.CategoryComboBox, "CategoryComboBox");
            this.CategoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ManufacturerLabel
            // 
            resources.ApplyResources(this.ManufacturerLabel, "ManufacturerLabel");
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // AddPictureBox
            // 
            resources.ApplyResources(this.AddPictureBox, "AddPictureBox");
            this.AddPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPictureBox.Image = global::ListItemsApp.Properties.Resources.Add;
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddPictureBox_MouseDown);
            this.AddPictureBox.MouseEnter += new System.EventHandler(this.AddPictureBox_MouseEnter);
            this.AddPictureBox.MouseLeave += new System.EventHandler(this.AddPictureBox_MouseLeave);
            // 
            // RemPictureBox
            // 
            resources.ApplyResources(this.RemPictureBox, "RemPictureBox");
            this.RemPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemPictureBox.Image = global::ListItemsApp.Properties.Resources.Rem;
            this.RemPictureBox.Name = "RemPictureBox";
            this.RemPictureBox.TabStop = false;
            this.RemPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemPictureBox_MouseDown);
            this.RemPictureBox.MouseEnter += new System.EventHandler(this.RemPictureBox_MouseEnter);
            this.RemPictureBox.MouseLeave += new System.EventHandler(this.RemPictureBox_MouseLeave);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RemPictureBox);
            this.Controls.Add(this.AddPictureBox);
            this.Controls.Add(this.ItemInfoGroupBox);
            this.Controls.Add(this.NameItemsListBox);
            this.Name = "MainForm";
            this.ItemInfoGroupBox.ResumeLayout(false);
            this.ItemInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemPictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.PictureBox RemPictureBox;
    }
}

