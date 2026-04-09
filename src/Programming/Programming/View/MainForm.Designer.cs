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
            this.RectangleIdLabel = new System.Windows.Forms.Label();
            this.RectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.RectangleYLabel = new System.Windows.Forms.Label();
            this.RectangleYTextBox = new System.Windows.Forms.TextBox();
            this.RectangleXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleXLabel = new System.Windows.Forms.Label();
            this.RectanglesButton = new System.Windows.Forms.Button();
            this.RectanglesColorLabel = new System.Windows.Forms.Label();
            this.RectanglesWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesLengthLabel = new System.Windows.Forms.Label();
            this.RectanglesColorTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesLengthTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectanglesListBox = new System.Windows.Forms.ListBox();
            this.Rectangles = new System.Windows.Forms.TabPage();
            this.RectanglesButtonsTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxWeekdayParsing1 = new Programming.View.Enums.GroupBoxWeekdayParsing();
            this.groupBoxEnumerations1 = new Programming.View.Enums.GroupBoxEnumerations();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.groupBoxSeasonsHandle1 = new Programming.View.Enums.GroupBoxSeasonsHandle();
            this.AllTabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.Classes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
            this.RectanglesInstructionGroupBox.SuspendLayout();
            this.ClassesGroupBox.SuspendLayout();
            this.Rectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTabControl
            // 
            this.AllTabControl.Controls.Add(this.EnumsTabControl);
            this.AllTabControl.Controls.Add(this.Classes);
            this.AllTabControl.Controls.Add(this.Rectangles);
            this.AllTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTabControl.Location = new System.Drawing.Point(0, 0);
            this.AllTabControl.Name = "AllTabControl";
            this.AllTabControl.SelectedIndex = 0;
            this.AllTabControl.Size = new System.Drawing.Size(750, 436);
            this.AllTabControl.TabIndex = 0;
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.groupBoxSeasonsHandle1);
            this.EnumsTabControl.Controls.Add(this.groupBoxWeekdayParsing1);
            this.EnumsTabControl.Controls.Add(this.groupBoxEnumerations1);
            this.EnumsTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnumsTabControl.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabControl.Size = new System.Drawing.Size(742, 410);
            this.EnumsTabControl.TabIndex = 0;
            this.EnumsTabControl.Text = "Enums";
            this.EnumsTabControl.UseVisualStyleBackColor = true;
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.groupBox1);
            this.Classes.Controls.Add(this.FilmsGroupBox);
            this.Classes.Controls.Add(this.RectanglesInstructionGroupBox);
            this.Classes.Controls.Add(this.ClassesGroupBox);
            this.Classes.Cursor = System.Windows.Forms.Cursors.Default;
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(742, 410);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(317, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструкция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 117);
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
            this.FilmsGroupBox.Location = new System.Drawing.Point(317, 0);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(475, 233);
            this.FilmsGroupBox.TabIndex = 3;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FilmFindButton
            // 
            this.FilmFindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmFindButton.Location = new System.Drawing.Point(241, 193);
            this.FilmFindButton.Name = "FilmFindButton";
            this.FilmFindButton.Size = new System.Drawing.Size(107, 23);
            this.FilmFindButton.TabIndex = 11;
            this.FilmFindButton.Text = "Find";
            this.FilmFindButton.UseVisualStyleBackColor = true;
            this.FilmFindButton.Click += new System.EventHandler(this.FilmFindButton_Click);
            // 
            // FilmDurationTextBox
            // 
            this.FilmDurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmDurationTextBox.Location = new System.Drawing.Point(318, 144);
            this.FilmDurationTextBox.Name = "FilmDurationTextBox";
            this.FilmDurationTextBox.Size = new System.Drawing.Size(149, 22);
            this.FilmDurationTextBox.TabIndex = 10;
            this.FilmDurationTextBox.TextChanged += new System.EventHandler(this.FilmDurationTextBox_TextChanged);
            // 
            // FilmYearTextBox
            // 
            this.FilmYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmYearTextBox.Location = new System.Drawing.Point(122, 144);
            this.FilmYearTextBox.Name = "FilmYearTextBox";
            this.FilmYearTextBox.Size = new System.Drawing.Size(149, 22);
            this.FilmYearTextBox.TabIndex = 9;
            this.FilmYearTextBox.TextChanged += new System.EventHandler(this.FilmYearTextBox_TextChanged);
            // 
            // FilmRatingTextBox
            // 
            this.FilmRatingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmRatingTextBox.Location = new System.Drawing.Point(318, 91);
            this.FilmRatingTextBox.Name = "FilmRatingTextBox";
            this.FilmRatingTextBox.Size = new System.Drawing.Size(149, 22);
            this.FilmRatingTextBox.TabIndex = 8;
            this.FilmRatingTextBox.TextChanged += new System.EventHandler(this.FilmRatingTextBox_TextChanged);
            // 
            // FilmGenreTextBox
            // 
            this.FilmGenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmGenreTextBox.Location = new System.Drawing.Point(122, 91);
            this.FilmGenreTextBox.Name = "FilmGenreTextBox";
            this.FilmGenreTextBox.Size = new System.Drawing.Size(149, 22);
            this.FilmGenreTextBox.TabIndex = 7;
            this.FilmGenreTextBox.TextChanged += new System.EventHandler(this.FilmGenreTextBox_TextChanged);
            // 
            // FilmDurationLabel
            // 
            this.FilmDurationLabel.AutoSize = true;
            this.FilmDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmDurationLabel.Location = new System.Drawing.Point(362, 125);
            this.FilmDurationLabel.Name = "FilmDurationLabel";
            this.FilmDurationLabel.Size = new System.Drawing.Size(57, 16);
            this.FilmDurationLabel.TabIndex = 6;
            this.FilmDurationLabel.Text = "Duration";
            // 
            // FilmYearLabel
            // 
            this.FilmYearLabel.AutoSize = true;
            this.FilmYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmYearLabel.Location = new System.Drawing.Point(173, 125);
            this.FilmYearLabel.Name = "FilmYearLabel";
            this.FilmYearLabel.Size = new System.Drawing.Size(36, 16);
            this.FilmYearLabel.TabIndex = 5;
            this.FilmYearLabel.Text = "Year";
            // 
            // FilmRatingLabel
            // 
            this.FilmRatingLabel.AutoSize = true;
            this.FilmRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmRatingLabel.Location = new System.Drawing.Point(373, 72);
            this.FilmRatingLabel.Name = "FilmRatingLabel";
            this.FilmRatingLabel.Size = new System.Drawing.Size(46, 16);
            this.FilmRatingLabel.TabIndex = 4;
            this.FilmRatingLabel.Text = "Rating";
            // 
            // FilmGenreLabel
            // 
            this.FilmGenreLabel.AutoSize = true;
            this.FilmGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmGenreLabel.Location = new System.Drawing.Point(173, 72);
            this.FilmGenreLabel.Name = "FilmGenreLabel";
            this.FilmGenreLabel.Size = new System.Drawing.Size(44, 16);
            this.FilmGenreLabel.TabIndex = 3;
            this.FilmGenreLabel.Text = "Genre";
            // 
            // FilmNameTextBox
            // 
            this.FilmNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmNameTextBox.Location = new System.Drawing.Point(122, 39);
            this.FilmNameTextBox.Name = "FilmNameTextBox";
            this.FilmNameTextBox.Size = new System.Drawing.Size(345, 22);
            this.FilmNameTextBox.TabIndex = 2;
            this.FilmNameTextBox.TextChanged += new System.EventHandler(this.FilmNameTextBox_TextChanged);
            // 
            // FilmNameLabel
            // 
            this.FilmNameLabel.AutoSize = true;
            this.FilmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmNameLabel.Location = new System.Drawing.Point(272, 20);
            this.FilmNameLabel.Name = "FilmNameLabel";
            this.FilmNameLabel.Size = new System.Drawing.Size(44, 16);
            this.FilmNameLabel.TabIndex = 1;
            this.FilmNameLabel.Text = "Name";
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 16;
            this.FilmsListBox.Items.AddRange(new object[] {
            "Film 1",
            "Film 2",
            "Film 3",
            "Film 4",
            "Film 5"});
            this.FilmsListBox.Location = new System.Drawing.Point(7, 20);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(105, 164);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
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
            // ClassesGroupBox
            // 
            this.ClassesGroupBox.Controls.Add(this.RectangleIdLabel);
            this.ClassesGroupBox.Controls.Add(this.RectangleIdTextBox);
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
            this.ClassesGroupBox.Controls.Add(this.ClassesRectanglesListBox);
            this.ClassesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ClassesGroupBox.Name = "ClassesGroupBox";
            this.ClassesGroupBox.Size = new System.Drawing.Size(310, 233);
            this.ClassesGroupBox.TabIndex = 0;
            this.ClassesGroupBox.TabStop = false;
            this.ClassesGroupBox.Text = "Rectangles";
            // 
            // RectangleIdLabel
            // 
            this.RectangleIdLabel.AutoSize = true;
            this.RectangleIdLabel.Location = new System.Drawing.Point(246, 143);
            this.RectangleIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RectangleIdLabel.Name = "RectangleIdLabel";
            this.RectangleIdLabel.Size = new System.Drawing.Size(18, 13);
            this.RectangleIdLabel.TabIndex = 13;
            this.RectangleIdLabel.Text = "ID";
            // 
            // RectangleIdTextBox
            // 
            this.RectangleIdTextBox.Location = new System.Drawing.Point(249, 158);
            this.RectangleIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectangleIdTextBox.Name = "RectangleIdTextBox";
            this.RectangleIdTextBox.ReadOnly = true;
            this.RectangleIdTextBox.Size = new System.Drawing.Size(52, 20);
            this.RectangleIdTextBox.TabIndex = 12;
            // 
            // RectangleYLabel
            // 
            this.RectangleYLabel.AutoSize = true;
            this.RectangleYLabel.Location = new System.Drawing.Point(184, 143);
            this.RectangleYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RectangleYLabel.Name = "RectangleYLabel";
            this.RectangleYLabel.Size = new System.Drawing.Size(14, 13);
            this.RectangleYLabel.TabIndex = 11;
            this.RectangleYLabel.Text = "Y";
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Location = new System.Drawing.Point(187, 158);
            this.RectangleYTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.ReadOnly = true;
            this.RectangleYTextBox.Size = new System.Drawing.Size(52, 20);
            this.RectangleYTextBox.TabIndex = 10;
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Location = new System.Drawing.Point(121, 158);
            this.RectangleXTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.ReadOnly = true;
            this.RectangleXTextBox.Size = new System.Drawing.Size(52, 20);
            this.RectangleXTextBox.TabIndex = 9;
            // 
            // RectangleXLabel
            // 
            this.RectangleXLabel.AutoSize = true;
            this.RectangleXLabel.Location = new System.Drawing.Point(121, 143);
            this.RectangleXLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RectangleXLabel.Name = "RectangleXLabel";
            this.RectangleXLabel.Size = new System.Drawing.Size(14, 13);
            this.RectangleXLabel.TabIndex = 8;
            this.RectangleXLabel.Text = "X";
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
            this.RectanglesColorLabel.Location = new System.Drawing.Point(153, 97);
            this.RectanglesColorLabel.Name = "RectanglesColorLabel";
            this.RectanglesColorLabel.Size = new System.Drawing.Size(34, 13);
            this.RectanglesColorLabel.TabIndex = 6;
            this.RectanglesColorLabel.Text = "Color:";
            // 
            // RectanglesWidthLabel
            // 
            this.RectanglesWidthLabel.AutoSize = true;
            this.RectanglesWidthLabel.Location = new System.Drawing.Point(154, 57);
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
            this.RectanglesColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesColorTextBox.Location = new System.Drawing.Point(156, 113);
            this.RectanglesColorTextBox.Name = "RectanglesColorTextBox";
            this.RectanglesColorTextBox.Size = new System.Drawing.Size(118, 22);
            this.RectanglesColorTextBox.TabIndex = 3;
            this.RectanglesColorTextBox.TextChanged += new System.EventHandler(this.RectanglesColorTextBox_TextChanged);
            // 
            // RectanglesWidthTextBox
            // 
            this.RectanglesWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesWidthTextBox.Location = new System.Drawing.Point(156, 73);
            this.RectanglesWidthTextBox.Name = "RectanglesWidthTextBox";
            this.RectanglesWidthTextBox.Size = new System.Drawing.Size(118, 22);
            this.RectanglesWidthTextBox.TabIndex = 2;
            this.RectanglesWidthTextBox.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // RectanglesLengthTextBox
            // 
            this.RectanglesLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesLengthTextBox.Location = new System.Drawing.Point(156, 35);
            this.RectanglesLengthTextBox.Name = "RectanglesLengthTextBox";
            this.RectanglesLengthTextBox.Size = new System.Drawing.Size(118, 22);
            this.RectanglesLengthTextBox.TabIndex = 1;
            this.RectanglesLengthTextBox.TextChanged += new System.EventHandler(this.RectanglesLengthTextBox_TextChanged);
            // 
            // ClassesRectanglesListBox
            // 
            this.ClassesRectanglesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassesRectanglesListBox.FormattingEnabled = true;
            this.ClassesRectanglesListBox.ItemHeight = 16;
            this.ClassesRectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.ClassesRectanglesListBox.Location = new System.Drawing.Point(8, 19);
            this.ClassesRectanglesListBox.Name = "ClassesRectanglesListBox";
            this.ClassesRectanglesListBox.Size = new System.Drawing.Size(107, 164);
            this.ClassesRectanglesListBox.TabIndex = 0;
            this.ClassesRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.ClassesRectanglesListBox_SelectedIndexChanged);
            // 
            // Rectangles
            // 
            this.Rectangles.Controls.Add(this.rectanglesCollisionControl1);
            this.Rectangles.Controls.Add(this.RectanglesButtonsTableLayoutPanel1);
            this.Rectangles.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rectangles.Location = new System.Drawing.Point(4, 22);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.Size = new System.Drawing.Size(742, 410);
            this.Rectangles.TabIndex = 2;
            this.Rectangles.Text = "Rectangles";
            this.Rectangles.UseVisualStyleBackColor = true;
            // 
            // RectanglesButtonsTableLayoutPanel1
            // 
            this.RectanglesButtonsTableLayoutPanel1.AutoSize = true;
            this.RectanglesButtonsTableLayoutPanel1.ColumnCount = 2;
            this.RectanglesButtonsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesButtonsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesButtonsTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.RectanglesButtonsTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.RectanglesButtonsTableLayoutPanel1.Name = "RectanglesButtonsTableLayoutPanel1";
            this.RectanglesButtonsTableLayoutPanel1.RowCount = 1;
            this.RectanglesButtonsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesButtonsTableLayoutPanel1.Size = new System.Drawing.Size(742, 0);
            this.RectanglesButtonsTableLayoutPanel1.TabIndex = 16;
            // 
            // groupBoxWeekdayParsing1
            // 
            this.groupBoxWeekdayParsing1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxWeekdayParsing1.Location = new System.Drawing.Point(3, 243);
            this.groupBoxWeekdayParsing1.Name = "groupBoxWeekdayParsing1";
            this.groupBoxWeekdayParsing1.Size = new System.Drawing.Size(392, 164);
            this.groupBoxWeekdayParsing1.TabIndex = 6;
            // 
            // groupBoxEnumerations1
            // 
            this.groupBoxEnumerations1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEnumerations1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEnumerations1.Name = "groupBoxEnumerations1";
            this.groupBoxEnumerations1.Size = new System.Drawing.Size(736, 240);
            this.groupBoxEnumerations1.TabIndex = 5;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(742, 410);
            this.rectanglesCollisionControl1.TabIndex = 17;
            // 
            // groupBoxSeasonsHandle1
            // 
            this.groupBoxSeasonsHandle1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxSeasonsHandle1.Location = new System.Drawing.Point(395, 243);
            this.groupBoxSeasonsHandle1.Name = "groupBoxSeasonsHandle1";
            this.groupBoxSeasonsHandle1.Size = new System.Drawing.Size(344, 164);
            this.groupBoxSeasonsHandle1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 436);
            this.Controls.Add(this.AllTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.AllTabControl.ResumeLayout(false);
            this.EnumsTabControl.ResumeLayout(false);
            this.Classes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.RectanglesInstructionGroupBox.ResumeLayout(false);
            this.RectanglesInstructionGroupBox.PerformLayout();
            this.ClassesGroupBox.ResumeLayout(false);
            this.ClassesGroupBox.PerformLayout();
            this.Rectangles.ResumeLayout(false);
            this.Rectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AllTabControl;
        private System.Windows.Forms.TabPage EnumsTabControl;
        internal System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.GroupBox ClassesGroupBox;
        private System.Windows.Forms.TextBox RectanglesColorTextBox;
        private System.Windows.Forms.TextBox RectanglesWidthTextBox;
        private System.Windows.Forms.TextBox RectanglesLengthTextBox;
        private System.Windows.Forms.ListBox ClassesRectanglesListBox;
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
        private System.Windows.Forms.Label RectangleIdLabel;
        private System.Windows.Forms.TextBox RectangleIdTextBox;
        private System.Windows.Forms.TabPage Rectangles;
        private System.Windows.Forms.TableLayoutPanel RectanglesButtonsTableLayoutPanel1;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Enums.GroupBoxEnumerations groupBoxEnumerations1;
        private View.Enums.GroupBoxWeekdayParsing groupBoxWeekdayParsing1;
        private View.Enums.GroupBoxSeasonsHandle groupBoxSeasonsHandle1;
    }
}

