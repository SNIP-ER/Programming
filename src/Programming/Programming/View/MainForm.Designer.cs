namespace Programming
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
            this.AllTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabControl = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.DayLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.EnumarationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueTextBox = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumarationLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.Classes = new System.Windows.Forms.TabPage();
            this.ClassesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesButton = new System.Windows.Forms.Button();
            this.RectanglesColorLabel = new System.Windows.Forms.Label();
            this.RectanglesWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesLengthLabel = new System.Windows.Forms.Label();
            this.RectanglesColorTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesInstructionGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesInstructionLabel = new System.Windows.Forms.Label();
            this.AllTabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumarationsGroupBox.SuspendLayout();
            this.Classes.SuspendLayout();
            this.ClassesGroupBox.SuspendLayout();
            this.RectanglesInstructionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTabControl
            // 
            this.AllTabControl.Controls.Add(this.EnumsTabControl);
            this.AllTabControl.Controls.Add(this.Classes);
            this.AllTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTabControl.Location = new System.Drawing.Point(0, 0);
            this.AllTabControl.Name = "AllTabControl";
            this.AllTabControl.SelectedIndex = 0;
            this.AllTabControl.Size = new System.Drawing.Size(800, 436);
            this.AllTabControl.TabIndex = 0;
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabControl.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabControl.Controls.Add(this.EnumarationsGroupBox);
            this.EnumsTabControl.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabControl.Size = new System.Drawing.Size(792, 410);
            this.EnumsTabControl.TabIndex = 0;
            this.EnumsTabControl.Text = "Enums";
            this.EnumsTabControl.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(395, 243);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(392, 164);
            this.SeasonHandleGroupBox.TabIndex = 4;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Items.AddRange(new object[] {
            "Default",
            "Winter",
            "Spring",
            "Summer",
            "Autumn"});
            this.SeasonComboBox.Location = new System.Drawing.Point(9, 47);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonComboBox.TabIndex = 3;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeasonButton.Location = new System.Drawing.Point(136, 46);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "GO!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(6, 30);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.ChooseSeasonLabel.TabIndex = 0;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.DayLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeValueLabel);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 243);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(392, 164);
            this.WeekdayParsingGroupBox.TabIndex = 3;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DayLabel.Location = new System.Drawing.Point(8, 85);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(0, 13);
            this.DayLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParseButton.Location = new System.Drawing.Point(204, 46);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(9, 46);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(189, 20);
            this.ParseTextBox.TabIndex = 1;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.AutoSize = true;
            this.TypeValueLabel.Location = new System.Drawing.Point(6, 30);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(115, 13);
            this.TypeValueLabel.TabIndex = 0;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // EnumarationsGroupBox
            // 
            this.EnumarationsGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumarationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumarationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumarationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumarationsGroupBox.Controls.Add(this.EnumarationLabel);
            this.EnumarationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumarationsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumarationsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EnumarationsGroupBox.Name = "EnumarationsGroupBox";
            this.EnumarationsGroupBox.Size = new System.Drawing.Size(786, 240);
            this.EnumarationsGroupBox.TabIndex = 2;
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
            this.EnumsListBox.SelectedValueChanged += new System.EventHandler(this.EnumsListBox_SelectedValueChanged);
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.RectanglesInstructionGroupBox);
            this.Classes.Controls.Add(this.ClassesGroupBox);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(792, 410);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // ClassesGroupBox
            // 
            this.ClassesGroupBox.Controls.Add(this.RectanglesButton);
            this.ClassesGroupBox.Controls.Add(this.RectanglesColorLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesWidthLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesLengthLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesColorTextBox);
            this.ClassesGroupBox.Controls.Add(this.RectanglesWidthTextBox);
            this.ClassesGroupBox.Controls.Add(this.RectanglesLengthTextBox);
            this.ClassesGroupBox.Controls.Add(this.RectanglesListBox);
            this.ClassesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ClassesGroupBox.Name = "ClassesGroupBox";
            this.ClassesGroupBox.Size = new System.Drawing.Size(310, 233);
            this.ClassesGroupBox.TabIndex = 0;
            this.ClassesGroupBox.TabStop = false;
            this.ClassesGroupBox.Text = "Rectangles";
            // 
            // RectanglesButton
            // 
            this.RectanglesButton.Location = new System.Drawing.Point(156, 192);
            this.RectanglesButton.Name = "RectanglesButton";
            this.RectanglesButton.Size = new System.Drawing.Size(118, 23);
            this.RectanglesButton.TabIndex = 7;
            this.RectanglesButton.Text = "Find";
            this.RectanglesButton.UseVisualStyleBackColor = true;
            this.RectanglesButton.Click += new System.EventHandler(this.RectanglesButton_Click);
            // 
            // RectanglesColorLabel
            // 
            this.RectanglesColorLabel.AutoSize = true;
            this.RectanglesColorLabel.Location = new System.Drawing.Point(153, 128);
            this.RectanglesColorLabel.Name = "RectanglesColorLabel";
            this.RectanglesColorLabel.Size = new System.Drawing.Size(34, 13);
            this.RectanglesColorLabel.TabIndex = 6;
            this.RectanglesColorLabel.Text = "Color:";
            // 
            // RectanglesWidthLabel
            // 
            this.RectanglesWidthLabel.AutoSize = true;
            this.RectanglesWidthLabel.Location = new System.Drawing.Point(153, 75);
            this.RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            this.RectanglesWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.RectanglesWidthLabel.TabIndex = 5;
            this.RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesLengthLabel
            // 
            this.RectanglesLengthLabel.AutoSize = true;
            this.RectanglesLengthLabel.Location = new System.Drawing.Point(153, 19);
            this.RectanglesLengthLabel.Name = "RectanglesLengthLabel";
            this.RectanglesLengthLabel.Size = new System.Drawing.Size(43, 13);
            this.RectanglesLengthLabel.TabIndex = 4;
            this.RectanglesLengthLabel.Text = "Length:";
            // 
            // RectanglesColorTextBox
            // 
            this.RectanglesColorTextBox.Location = new System.Drawing.Point(156, 144);
            this.RectanglesColorTextBox.Name = "RectanglesColorTextBox";
            this.RectanglesColorTextBox.Size = new System.Drawing.Size(118, 20);
            this.RectanglesColorTextBox.TabIndex = 3;
            this.RectanglesColorTextBox.TextChanged += new System.EventHandler(this.RectanglesColorTextBox_TextChanged);
            // 
            // RectanglesWidthTextBox
            // 
            this.RectanglesWidthTextBox.Location = new System.Drawing.Point(156, 91);
            this.RectanglesWidthTextBox.Name = "RectanglesWidthTextBox";
            this.RectanglesWidthTextBox.Size = new System.Drawing.Size(118, 20);
            this.RectanglesWidthTextBox.TabIndex = 2;
            this.RectanglesWidthTextBox.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // RectanglesLengthTextBox
            // 
            this.RectanglesLengthTextBox.Location = new System.Drawing.Point(156, 35);
            this.RectanglesLengthTextBox.Name = "RectanglesLengthTextBox";
            this.RectanglesLengthTextBox.Size = new System.Drawing.Size(118, 20);
            this.RectanglesLengthTextBox.TabIndex = 1;
            this.RectanglesLengthTextBox.TextChanged += new System.EventHandler(this.RectanglesLengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(8, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(107, 196);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesInstructionGroupBox
            // 
            this.RectanglesInstructionGroupBox.Controls.Add(this.RectanglesInstructionLabel);
            this.RectanglesInstructionGroupBox.Location = new System.Drawing.Point(0, 239);
            this.RectanglesInstructionGroupBox.Name = "RectanglesInstructionGroupBox";
            this.RectanglesInstructionGroupBox.Size = new System.Drawing.Size(310, 171);
            this.RectanglesInstructionGroupBox.TabIndex = 2;
            this.RectanglesInstructionGroupBox.TabStop = false;
            this.RectanglesInstructionGroupBox.Text = "Инструкция";
            // 
            // RectanglesInstructionLabel
            // 
            this.RectanglesInstructionLabel.AutoSize = true;
            this.RectanglesInstructionLabel.Location = new System.Drawing.Point(7, 20);
            this.RectanglesInstructionLabel.Name = "RectanglesInstructionLabel";
            this.RectanglesInstructionLabel.Size = new System.Drawing.Size(294, 117);
            this.RectanglesInstructionLabel.TabIndex = 0;
            this.RectanglesInstructionLabel.Text = resources.GetString("RectanglesInstructionLabel.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.AllTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.AllTabControl.ResumeLayout(false);
            this.EnumsTabControl.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumarationsGroupBox.ResumeLayout(false);
            this.EnumarationsGroupBox.PerformLayout();
            this.Classes.ResumeLayout(false);
            this.ClassesGroupBox.ResumeLayout(false);
            this.ClassesGroupBox.PerformLayout();
            this.RectanglesInstructionGroupBox.ResumeLayout(false);
            this.RectanglesInstructionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AllTabControl;
        private System.Windows.Forms.TabPage EnumsTabControl;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox EnumarationsGroupBox;
        private System.Windows.Forms.Label EnumarationLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label IntValueTextBox;
        public System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseTextBox;
        private System.Windows.Forms.Label TypeValueLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        internal System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.GroupBox ClassesGroupBox;
        private System.Windows.Forms.TextBox RectanglesColorTextBox;
        private System.Windows.Forms.TextBox RectanglesWidthTextBox;
        private System.Windows.Forms.TextBox RectanglesLengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label RectanglesLengthLabel;
        private System.Windows.Forms.Label RectanglesColorLabel;
        private System.Windows.Forms.Label RectanglesWidthLabel;
        private System.Windows.Forms.Button RectanglesButton;
        private System.Windows.Forms.GroupBox RectanglesInstructionGroupBox;
        private System.Windows.Forms.Label RectanglesInstructionLabel;
    }
}

