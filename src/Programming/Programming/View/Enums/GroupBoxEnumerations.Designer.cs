namespace Programming.View.Enums
{
    partial class GroupBoxEnumerations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumarationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueTextBox = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumarationLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumarationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumarationsGroupBox
            // 
            this.EnumarationsGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumarationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumarationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumarationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumarationsGroupBox.Controls.Add(this.EnumarationLabel);
            this.EnumarationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumarationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumarationsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumarationsGroupBox.Name = "EnumarationsGroupBox";
            this.EnumarationsGroupBox.Size = new System.Drawing.Size(736, 240);
            this.EnumarationsGroupBox.TabIndex = 3;
            this.EnumarationsGroupBox.TabStop = false;
            this.EnumarationsGroupBox.Text = "Enumarations";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ValueTextBox.Location = new System.Drawing.Point(297, 43);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.ReadOnly = true;
            this.ValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValueTextBox.TabIndex = 5;
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.AutoSize = true;
            this.IntValueTextBox.Location = new System.Drawing.Point(294, 27);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(51, 13);
            this.IntValueTextBox.TabIndex = 4;
            this.IntValueTextBox.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(148, 27);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(151, 43);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 186);
            this.ValuesListBox.TabIndex = 2;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumarationLabel
            // 
            this.EnumarationLabel.AutoSize = true;
            this.EnumarationLabel.Location = new System.Drawing.Point(6, 27);
            this.EnumarationLabel.Name = "EnumarationLabel";
            this.EnumarationLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumarationLabel.TabIndex = 1;
            this.EnumarationLabel.Text = "Choose enumaration:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(9, 43);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 186);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedValueChanged);
            // 
            // GroupBoxEnumerations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumarationsGroupBox);
            this.Name = "GroupBoxEnumerations";
            this.Size = new System.Drawing.Size(736, 240);
            this.EnumarationsGroupBox.ResumeLayout(false);
            this.EnumarationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumarationsGroupBox;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label IntValueTextBox;
        private System.Windows.Forms.Label ValueLabel;
        public System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label EnumarationLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
    }
}
