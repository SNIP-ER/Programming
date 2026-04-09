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
            this.RectanglesInstructionGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesInstructionLabel = new System.Windows.Forms.Label();
            this.Rectangles = new System.Windows.Forms.TabPage();
            this.RectanglesButtonsTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSeasonsHandle1 = new Programming.View.Enums.GroupBoxSeasonsHandle();
            this.groupBoxWeekdayParsing1 = new Programming.View.Enums.GroupBoxWeekdayParsing();
            this.groupBoxEnumerations1 = new Programming.View.Enums.GroupBoxEnumerations();
            this.groupBoxRectangles1 = new Programming.View.Classes.GroupBoxRectangles();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.groupBoxMovies1 = new Programming.View.Classes.GroupBoxMovies();
            this.AllTabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.Classes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RectanglesInstructionGroupBox.SuspendLayout();
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
            this.Classes.Controls.Add(this.groupBoxMovies1);
            this.Classes.Controls.Add(this.groupBoxRectangles1);
            this.Classes.Controls.Add(this.groupBox1);
            this.Classes.Controls.Add(this.RectanglesInstructionGroupBox);
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
            // groupBoxSeasonsHandle1
            // 
            this.groupBoxSeasonsHandle1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxSeasonsHandle1.Location = new System.Drawing.Point(395, 243);
            this.groupBoxSeasonsHandle1.Name = "groupBoxSeasonsHandle1";
            this.groupBoxSeasonsHandle1.Size = new System.Drawing.Size(344, 164);
            this.groupBoxSeasonsHandle1.TabIndex = 7;
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
            // groupBoxRectangles1
            // 
            this.groupBoxRectangles1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRectangles1.Name = "groupBoxRectangles1";
            this.groupBoxRectangles1.Size = new System.Drawing.Size(310, 233);
            this.groupBoxRectangles1.TabIndex = 5;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(742, 410);
            this.rectanglesCollisionControl1.TabIndex = 17;
            // 
            // groupBoxMovies1
            // 
            this.groupBoxMovies1.Location = new System.Drawing.Point(317, 0);
            this.groupBoxMovies1.Name = "groupBoxMovies1";
            this.groupBoxMovies1.Size = new System.Drawing.Size(422, 233);
            this.groupBoxMovies1.TabIndex = 6;
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
            this.RectanglesInstructionGroupBox.ResumeLayout(false);
            this.RectanglesInstructionGroupBox.PerformLayout();
            this.Rectangles.ResumeLayout(false);
            this.Rectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AllTabControl;
        private System.Windows.Forms.TabPage EnumsTabControl;
        internal System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.GroupBox RectanglesInstructionGroupBox;
        private System.Windows.Forms.Label RectanglesInstructionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Rectangles;
        private System.Windows.Forms.TableLayoutPanel RectanglesButtonsTableLayoutPanel1;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Enums.GroupBoxEnumerations groupBoxEnumerations1;
        private View.Enums.GroupBoxWeekdayParsing groupBoxWeekdayParsing1;
        private View.Enums.GroupBoxSeasonsHandle groupBoxSeasonsHandle1;
        private View.Classes.GroupBoxRectangles groupBoxRectangles1;
        private View.Classes.GroupBoxMovies groupBoxMovies1;
    }
}

