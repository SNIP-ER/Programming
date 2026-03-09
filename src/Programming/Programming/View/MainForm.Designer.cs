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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.FilmFindButton = new System.Windows.Forms.Button();
            this.FilmDurationTextBox = new System.Windows.Forms.TextBox();
            this.FilmYearTextBox = new System.Windows.Forms.TextBox();
            this.FilmRatingTextBox = new System.Windows.Forms.TextBox();
            this.FilmGenreTextBox = new System.Windows.Forms.TextBox();
            this.FilmDurationLabel = new System.Windows.Forms.Label();
            this.FilmYearLabel = new System.Windows.Forms.Label();
            this.FilmRatingLabel = new System.Windows.Forms.Label();
            this.FilmGenreLabel = new System.Windows.Forms.Label();
            this.FilmNameTextBox = new System.Windows.Forms.TextBox();
            this.FilmNameLabel = new System.Windows.Forms.Label();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.RectanglesInstructionGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesInstructionLabel = new System.Windows.Forms.Label();
            this.ClassesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesButton = new System.Windows.Forms.Button();
            this.RectanglesColorLabel = new System.Windows.Forms.Label();
            this.RectanglesWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesLengthLabel = new System.Windows.Forms.Label();
            this.RectanglesColorTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectangleXLabel = new System.Windows.Forms.Label();
            this.RectangleXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleYTextBox = new System.Windows.Forms.TextBox();
            this.RectangleYLabel = new System.Windows.Forms.Label();
            this.AllTabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumarationsGroupBox.SuspendLayout();
            this.Classes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
            this.RectanglesInstructionGroupBox.SuspendLayout();
            this.ClassesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTabControl
            // 
            this.AllTabControl.Controls.Add(this.EnumsTabControl);
            this.AllTabControl.Controls.Add(this.Classes);
            this.AllTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTabControl.Location = new System.Drawing.Point(0, 0);
            this.AllTabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AllTabControl.Name = "AllTabControl";
            this.AllTabControl.SelectedIndex = 0;
            this.AllTabControl.Size = new System.Drawing.Size(1600, 838);
            this.AllTabControl.TabIndex = 0;
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabControl.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabControl.Controls.Add(this.EnumarationsGroupBox);
            this.EnumsTabControl.Location = new System.Drawing.Point(8, 39);
            this.EnumsTabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EnumsTabControl.Size = new System.Drawing.Size(1584, 791);
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
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(790, 468);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(784, 317);
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
            this.SeasonComboBox.Location = new System.Drawing.Point(18, 90);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(238, 33);
            this.SeasonComboBox.TabIndex = 3;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeasonButton.Location = new System.Drawing.Point(272, 88);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(150, 44);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "GO!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(12, 58);
            this.ChooseSeasonLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(168, 25);
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
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(6, 468);
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(784, 317);
            this.WeekdayParsingGroupBox.TabIndex = 3;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DayLabel.Location = new System.Drawing.Point(16, 163);
            this.DayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(0, 25);
            this.DayLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParseButton.Location = new System.Drawing.Point(408, 88);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(150, 44);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(18, 88);
            this.ParseTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(374, 31);
            this.ParseTextBox.TabIndex = 1;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.AutoSize = true;
            this.TypeValueLabel.Location = new System.Drawing.Point(12, 58);
            this.TypeValueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(232, 25);
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
            this.EnumarationsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.EnumarationsGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EnumarationsGroupBox.Name = "EnumarationsGroupBox";
            this.EnumarationsGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EnumarationsGroupBox.Size = new System.Drawing.Size(1572, 462);
            this.EnumarationsGroupBox.TabIndex = 2;
            this.EnumarationsGroupBox.TabStop = false;
            this.EnumarationsGroupBox.Text = "Enumarations";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ValueTextBox.Location = new System.Drawing.Point(594, 83);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.ReadOnly = true;
            this.ValueTextBox.Size = new System.Drawing.Size(196, 31);
            this.ValueTextBox.TabIndex = 5;
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.AutoSize = true;
            this.IntValueTextBox.Location = new System.Drawing.Point(588, 52);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(99, 25);
            this.IntValueTextBox.TabIndex = 4;
            this.IntValueTextBox.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(296, 52);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(150, 25);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 25;
            this.ValuesListBox.Location = new System.Drawing.Point(302, 83);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(236, 354);
            this.ValuesListBox.TabIndex = 2;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumarationLabel
            // 
            this.EnumarationLabel.AutoSize = true;
            this.EnumarationLabel.Location = new System.Drawing.Point(12, 52);
            this.EnumarationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EnumarationLabel.Name = "EnumarationLabel";
            this.EnumarationLabel.Size = new System.Drawing.Size(217, 25);
            this.EnumarationLabel.TabIndex = 1;
            this.EnumarationLabel.Text = "Choose enumaration:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 25;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(18, 83);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(236, 354);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedValueChanged += new System.EventHandler(this.EnumsListBox_SelectedValueChanged);
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.groupBox1);
            this.Classes.Controls.Add(this.FilmsGroupBox);
            this.Classes.Controls.Add(this.RectanglesInstructionGroupBox);
            this.Classes.Controls.Add(this.ClassesGroupBox);
            this.Classes.Location = new System.Drawing.Point(8, 39);
            this.Classes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(1584, 791);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(634, 460);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(950, 329);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструкция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 225);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.FilmFindButton);
            this.FilmsGroupBox.Controls.Add(this.FilmDurationTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmYearTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmRatingTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmGenreTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmDurationLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmYearLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmRatingLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmGenreLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmNameTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmNameLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Location = new System.Drawing.Point(634, 0);
            this.FilmsGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmsGroupBox.Size = new System.Drawing.Size(950, 448);
            this.FilmsGroupBox.TabIndex = 3;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FilmFindButton
            // 
            this.FilmFindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmFindButton.Location = new System.Drawing.Point(482, 371);
            this.FilmFindButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmFindButton.Name = "FilmFindButton";
            this.FilmFindButton.Size = new System.Drawing.Size(214, 44);
            this.FilmFindButton.TabIndex = 11;
            this.FilmFindButton.Text = "Find";
            this.FilmFindButton.UseVisualStyleBackColor = true;
            this.FilmFindButton.Click += new System.EventHandler(this.FilmFindButton_Click);
            // 
            // FilmDurationTextBox
            // 
            this.FilmDurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmDurationTextBox.Location = new System.Drawing.Point(636, 277);
            this.FilmDurationTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmDurationTextBox.Name = "FilmDurationTextBox";
            this.FilmDurationTextBox.Size = new System.Drawing.Size(294, 37);
            this.FilmDurationTextBox.TabIndex = 10;
            this.FilmDurationTextBox.TextChanged += new System.EventHandler(this.FilmDurationTextBox_TextChanged);
            // 
            // FilmYearTextBox
            // 
            this.FilmYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmYearTextBox.Location = new System.Drawing.Point(244, 277);
            this.FilmYearTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmYearTextBox.Name = "FilmYearTextBox";
            this.FilmYearTextBox.Size = new System.Drawing.Size(294, 37);
            this.FilmYearTextBox.TabIndex = 9;
            this.FilmYearTextBox.TextChanged += new System.EventHandler(this.FilmYearTextBox_TextChanged);
            // 
            // FilmRatingTextBox
            // 
            this.FilmRatingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmRatingTextBox.Location = new System.Drawing.Point(636, 175);
            this.FilmRatingTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmRatingTextBox.Name = "FilmRatingTextBox";
            this.FilmRatingTextBox.Size = new System.Drawing.Size(294, 37);
            this.FilmRatingTextBox.TabIndex = 8;
            this.FilmRatingTextBox.TextChanged += new System.EventHandler(this.FilmRatingTextBox_TextChanged);
            // 
            // FilmGenreTextBox
            // 
            this.FilmGenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmGenreTextBox.Location = new System.Drawing.Point(244, 175);
            this.FilmGenreTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmGenreTextBox.Name = "FilmGenreTextBox";
            this.FilmGenreTextBox.Size = new System.Drawing.Size(294, 37);
            this.FilmGenreTextBox.TabIndex = 7;
            this.FilmGenreTextBox.TextChanged += new System.EventHandler(this.FilmGenreTextBox_TextChanged);
            // 
            // FilmDurationLabel
            // 
            this.FilmDurationLabel.AutoSize = true;
            this.FilmDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmDurationLabel.Location = new System.Drawing.Point(724, 240);
            this.FilmDurationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FilmDurationLabel.Name = "FilmDurationLabel";
            this.FilmDurationLabel.Size = new System.Drawing.Size(110, 30);
            this.FilmDurationLabel.TabIndex = 6;
            this.FilmDurationLabel.Text = "Duration";
            // 
            // FilmYearLabel
            // 
            this.FilmYearLabel.AutoSize = true;
            this.FilmYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmYearLabel.Location = new System.Drawing.Point(346, 240);
            this.FilmYearLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FilmYearLabel.Name = "FilmYearLabel";
            this.FilmYearLabel.Size = new System.Drawing.Size(66, 30);
            this.FilmYearLabel.TabIndex = 5;
            this.FilmYearLabel.Text = "Year";
            // 
            // FilmRatingLabel
            // 
            this.FilmRatingLabel.AutoSize = true;
            this.FilmRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmRatingLabel.Location = new System.Drawing.Point(746, 138);
            this.FilmRatingLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FilmRatingLabel.Name = "FilmRatingLabel";
            this.FilmRatingLabel.Size = new System.Drawing.Size(87, 30);
            this.FilmRatingLabel.TabIndex = 4;
            this.FilmRatingLabel.Text = "Rating";
            // 
            // FilmGenreLabel
            // 
            this.FilmGenreLabel.AutoSize = true;
            this.FilmGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmGenreLabel.Location = new System.Drawing.Point(346, 138);
            this.FilmGenreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FilmGenreLabel.Name = "FilmGenreLabel";
            this.FilmGenreLabel.Size = new System.Drawing.Size(84, 30);
            this.FilmGenreLabel.TabIndex = 3;
            this.FilmGenreLabel.Text = "Genre";
            // 
            // FilmNameTextBox
            // 
            this.FilmNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmNameTextBox.Location = new System.Drawing.Point(244, 75);
            this.FilmNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmNameTextBox.Name = "FilmNameTextBox";
            this.FilmNameTextBox.Size = new System.Drawing.Size(686, 37);
            this.FilmNameTextBox.TabIndex = 2;
            this.FilmNameTextBox.TextChanged += new System.EventHandler(this.FilmNameTextBox_TextChanged);
            // 
            // FilmNameLabel
            // 
            this.FilmNameLabel.AutoSize = true;
            this.FilmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmNameLabel.Location = new System.Drawing.Point(544, 38);
            this.FilmNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FilmNameLabel.Name = "FilmNameLabel";
            this.FilmNameLabel.Size = new System.Drawing.Size(82, 30);
            this.FilmNameLabel.TabIndex = 1;
            this.FilmNameLabel.Text = "Name";
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 30;
            this.FilmsListBox.Items.AddRange(new object[] {
            "Film 1",
            "Film 2",
            "Film 3",
            "Film 4",
            "Film 5"});
            this.FilmsListBox.Location = new System.Drawing.Point(14, 38);
            this.FilmsListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(206, 364);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // RectanglesInstructionGroupBox
            // 
            this.RectanglesInstructionGroupBox.Controls.Add(this.RectanglesInstructionLabel);
            this.RectanglesInstructionGroupBox.Location = new System.Drawing.Point(0, 460);
            this.RectanglesInstructionGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RectanglesInstructionGroupBox.Name = "RectanglesInstructionGroupBox";
            this.RectanglesInstructionGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RectanglesInstructionGroupBox.Size = new System.Drawing.Size(620, 329);
            this.RectanglesInstructionGroupBox.TabIndex = 2;
            this.RectanglesInstructionGroupBox.TabStop = false;
            this.RectanglesInstructionGroupBox.Text = "Инструкция";
            // 
            // RectanglesInstructionLabel
            // 
            this.RectanglesInstructionLabel.AutoSize = true;
            this.RectanglesInstructionLabel.Location = new System.Drawing.Point(14, 38);
            this.RectanglesInstructionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RectanglesInstructionLabel.Name = "RectanglesInstructionLabel";
            this.RectanglesInstructionLabel.Size = new System.Drawing.Size(577, 225);
            this.RectanglesInstructionLabel.TabIndex = 0;
            this.RectanglesInstructionLabel.Text = resources.GetString("RectanglesInstructionLabel.Text");
            // 
            // ClassesGroupBox
            // 
            this.ClassesGroupBox.Controls.Add(this.RectangleYLabel);
            this.ClassesGroupBox.Controls.Add(this.RectangleYTextBox);
            this.ClassesGroupBox.Controls.Add(this.RectangleXTextBox);
            this.ClassesGroupBox.Controls.Add(this.RectangleXLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesButton);
            this.ClassesGroupBox.Controls.Add(this.RectanglesColorLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesWidthLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesLengthLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesColorTextBox);
            this.ClassesGroupBox.Controls.Add(this.RectanglesWidthTextBox);
            this.ClassesGroupBox.Controls.Add(this.RectanglesLengthTextBox);
            this.ClassesGroupBox.Controls.Add(this.RectanglesListBox);
            this.ClassesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ClassesGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ClassesGroupBox.Name = "ClassesGroupBox";
            this.ClassesGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ClassesGroupBox.Size = new System.Drawing.Size(620, 448);
            this.ClassesGroupBox.TabIndex = 0;
            this.ClassesGroupBox.TabStop = false;
            this.ClassesGroupBox.Text = "Rectangles";
            // 
            // RectanglesButton
            // 
            this.RectanglesButton.Location = new System.Drawing.Point(312, 369);
            this.RectanglesButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RectanglesButton.Name = "RectanglesButton";
            this.RectanglesButton.Size = new System.Drawing.Size(236, 44);
            this.RectanglesButton.TabIndex = 7;
            this.RectanglesButton.Text = "Find";
            this.RectanglesButton.UseVisualStyleBackColor = true;
            this.RectanglesButton.Click += new System.EventHandler(this.RectanglesButton_Click);
            // 
            // RectanglesColorLabel
            // 
            this.RectanglesColorLabel.AutoSize = true;
            this.RectanglesColorLabel.Location = new System.Drawing.Point(306, 187);
            this.RectanglesColorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RectanglesColorLabel.Name = "RectanglesColorLabel";
            this.RectanglesColorLabel.Size = new System.Drawing.Size(69, 25);
            this.RectanglesColorLabel.TabIndex = 6;
            this.RectanglesColorLabel.Text = "Color:";
            // 
            // RectanglesWidthLabel
            // 
            this.RectanglesWidthLabel.AutoSize = true;
            this.RectanglesWidthLabel.Location = new System.Drawing.Point(307, 110);
            this.RectanglesWidthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            this.RectanglesWidthLabel.Size = new System.Drawing.Size(73, 25);
            this.RectanglesWidthLabel.TabIndex = 5;
            this.RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesLengthLabel
            // 
            this.RectanglesLengthLabel.AutoSize = true;
            this.RectanglesLengthLabel.Location = new System.Drawing.Point(306, 37);
            this.RectanglesLengthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RectanglesLengthLabel.Name = "RectanglesLengthLabel";
            this.RectanglesLengthLabel.Size = new System.Drawing.Size(84, 25);
            this.RectanglesLengthLabel.TabIndex = 4;
            this.RectanglesLengthLabel.Text = "Length:";
            // 
            // RectanglesColorTextBox
            // 
            this.RectanglesColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesColorTextBox.Location = new System.Drawing.Point(312, 218);
            this.RectanglesColorTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RectanglesColorTextBox.Name = "RectanglesColorTextBox";
            this.RectanglesColorTextBox.Size = new System.Drawing.Size(232, 37);
            this.RectanglesColorTextBox.TabIndex = 3;
            this.RectanglesColorTextBox.TextChanged += new System.EventHandler(this.RectanglesColorTextBox_TextChanged);
            // 
            // RectanglesWidthTextBox
            // 
            this.RectanglesWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesWidthTextBox.Location = new System.Drawing.Point(311, 141);
            this.RectanglesWidthTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RectanglesWidthTextBox.Name = "RectanglesWidthTextBox";
            this.RectanglesWidthTextBox.Size = new System.Drawing.Size(232, 37);
            this.RectanglesWidthTextBox.TabIndex = 2;
            this.RectanglesWidthTextBox.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // RectanglesLengthTextBox
            // 
            this.RectanglesLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesLengthTextBox.Location = new System.Drawing.Point(312, 67);
            this.RectanglesLengthTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RectanglesLengthTextBox.Name = "RectanglesLengthTextBox";
            this.RectanglesLengthTextBox.Size = new System.Drawing.Size(232, 37);
            this.RectanglesLengthTextBox.TabIndex = 1;
            this.RectanglesLengthTextBox.TextChanged += new System.EventHandler(this.RectanglesLengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 30;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(16, 37);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(210, 364);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectangleXLabel
            // 
            this.RectangleXLabel.AutoSize = true;
            this.RectangleXLabel.Location = new System.Drawing.Point(312, 277);
            this.RectangleXLabel.Name = "RectangleXLabel";
            this.RectangleXLabel.Size = new System.Drawing.Size(26, 25);
            this.RectangleXLabel.TabIndex = 8;
            this.RectangleXLabel.Text = "X";
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Location = new System.Drawing.Point(311, 306);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.ReadOnly = true;
            this.RectangleXTextBox.Size = new System.Drawing.Size(100, 31);
            this.RectangleXTextBox.TabIndex = 9;
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Location = new System.Drawing.Point(443, 306);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.ReadOnly = true;
            this.RectangleYTextBox.Size = new System.Drawing.Size(100, 31);
            this.RectangleYTextBox.TabIndex = 10;
            // 
            // RectangleYLabel
            // 
            this.RectangleYLabel.AutoSize = true;
            this.RectangleYLabel.Location = new System.Drawing.Point(438, 277);
            this.RectangleYLabel.Name = "RectangleYLabel";
            this.RectangleYLabel.Size = new System.Drawing.Size(27, 25);
            this.RectangleYLabel.TabIndex = 11;
            this.RectangleYLabel.Text = "Y";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 838);
            this.Controls.Add(this.AllTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.RectanglesInstructionGroupBox.ResumeLayout(false);
            this.RectanglesInstructionGroupBox.PerformLayout();
            this.ClassesGroupBox.ResumeLayout(false);
            this.ClassesGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.TextBox FilmNameTextBox;
        private System.Windows.Forms.Label FilmNameLabel;
        private System.Windows.Forms.Label FilmRatingLabel;
        private System.Windows.Forms.Label FilmGenreLabel;
        private System.Windows.Forms.Label FilmDurationLabel;
        private System.Windows.Forms.Label FilmYearLabel;
        private System.Windows.Forms.TextBox FilmDurationTextBox;
        private System.Windows.Forms.TextBox FilmYearTextBox;
        private System.Windows.Forms.TextBox FilmRatingTextBox;
        private System.Windows.Forms.TextBox FilmGenreTextBox;
        private System.Windows.Forms.Button FilmFindButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RectangleXLabel;
        private System.Windows.Forms.TextBox RectangleXTextBox;
        private System.Windows.Forms.Label RectangleYLabel;
        private System.Windows.Forms.TextBox RectangleYTextBox;
    }
}

