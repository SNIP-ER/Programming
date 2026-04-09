namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.RectanglesLabelRectangles = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesButtonRemove = new System.Windows.Forms.PictureBox();
            this.RectanglesButtonAdd = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RectanglesLeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RectanglesTextBoxHeight = new System.Windows.Forms.TextBox();
            this.RectanglesLabelHeight = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RectanglesLabelId = new System.Windows.Forms.Label();
            this.RectanglesTextBoxId = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RectanglesTextBoxWidth = new System.Windows.Forms.TextBox();
            this.RectanglesLabelWidth = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RectanglesTextBoxY = new System.Windows.Forms.TextBox();
            this.RectanglesLabelY = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RectanglesLabelX = new System.Windows.Forms.Label();
            this.RectanglesTextBoxX = new System.Windows.Forms.TextBox();
            this.RectanglesLabelSelected = new System.Windows.Forms.Label();
            this.RectanglesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RectanglesButtonRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectanglesButtonAdd)).BeginInit();
            this.panel1.SuspendLayout();
            this.RectanglesLeftLayoutPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RectanglesTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesLabelRectangles
            // 
            this.RectanglesLabelRectangles.AutoSize = true;
            this.RectanglesLabelRectangles.Location = new System.Drawing.Point(3, 0);
            this.RectanglesLabelRectangles.Name = "RectanglesLabelRectangles";
            this.RectanglesLabelRectangles.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabelRectangles.TabIndex = 0;
            this.RectanglesLabelRectangles.Text = "Rectangles:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(3, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(192, 95);
            this.RectanglesListBox.TabIndex = 1;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesButtonRemove
            // 
            this.RectanglesButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RectanglesButtonRemove.Image = global::Programming.Properties.Resources.remove;
            this.RectanglesButtonRemove.Location = new System.Drawing.Point(108, 3);
            this.RectanglesButtonRemove.Name = "RectanglesButtonRemove";
            this.RectanglesButtonRemove.Size = new System.Drawing.Size(37, 28);
            this.RectanglesButtonRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RectanglesButtonRemove.TabIndex = 5;
            this.RectanglesButtonRemove.TabStop = false;
            this.RectanglesButtonRemove.Click += new System.EventHandler(this.RectanglesButtonRemove_Click);
            this.RectanglesButtonRemove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RectanglesButtonRemove_MouseDown);
            this.RectanglesButtonRemove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RectanglesButtonRemove_MouseUp);
            // 
            // RectanglesButtonAdd
            // 
            this.RectanglesButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RectanglesButtonAdd.Image = global::Programming.Properties.Resources.add;
            this.RectanglesButtonAdd.Location = new System.Drawing.Point(40, 3);
            this.RectanglesButtonAdd.Name = "RectanglesButtonAdd";
            this.RectanglesButtonAdd.Size = new System.Drawing.Size(37, 28);
            this.RectanglesButtonAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RectanglesButtonAdd.TabIndex = 4;
            this.RectanglesButtonAdd.TabStop = false;
            this.RectanglesButtonAdd.Click += new System.EventHandler(this.RectanglesButtonAdd_Click);
            this.RectanglesButtonAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RectanglesButtonAdd_MouseDown);
            this.RectanglesButtonAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RectanglesButtonAdd_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RectanglesButtonRemove);
            this.panel1.Controls.Add(this.RectanglesButtonAdd);
            this.panel1.Location = new System.Drawing.Point(2, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 47);
            this.panel1.TabIndex = 17;
            // 
            // RectanglesLeftLayoutPanel
            // 
            this.RectanglesLeftLayoutPanel.ColumnCount = 1;
            this.RectanglesLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.83193F));
            this.RectanglesLeftLayoutPanel.Controls.Add(this.panel6, 0, 8);
            this.RectanglesLeftLayoutPanel.Controls.Add(this.panel2, 0, 4);
            this.RectanglesLeftLayoutPanel.Controls.Add(this.panel5, 0, 7);
            this.RectanglesLeftLayoutPanel.Controls.Add(this.RectanglesLabelRectangles, 0, 0);
            this.RectanglesLeftLayoutPanel.Controls.Add(this.panel4, 0, 6);
            this.RectanglesLeftLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.RectanglesLeftLayoutPanel.Controls.Add(this.panel3, 0, 5);
            this.RectanglesLeftLayoutPanel.Controls.Add(this.RectanglesListBox, 0, 1);
            this.RectanglesLeftLayoutPanel.Controls.Add(this.RectanglesLabelSelected, 0, 3);
            this.RectanglesLeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectanglesLeftLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RectanglesLeftLayoutPanel.Name = "RectanglesLeftLayoutPanel";
            this.RectanglesLeftLayoutPanel.RowCount = 9;
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5514F));
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.4486F));
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.RectanglesLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.RectanglesLeftLayoutPanel.Size = new System.Drawing.Size(200, 410);
            this.RectanglesLeftLayoutPanel.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.RectanglesTextBoxHeight);
            this.panel6.Controls.Add(this.RectanglesLabelHeight);
            this.panel6.Location = new System.Drawing.Point(2, 313);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 16);
            this.panel6.TabIndex = 18;
            // 
            // RectanglesTextBoxHeight
            // 
            this.RectanglesTextBoxHeight.Location = new System.Drawing.Point(54, 0);
            this.RectanglesTextBoxHeight.Name = "RectanglesTextBoxHeight";
            this.RectanglesTextBoxHeight.Size = new System.Drawing.Size(61, 20);
            this.RectanglesTextBoxHeight.TabIndex = 14;
            this.RectanglesTextBoxHeight.Leave += new System.EventHandler(this.RectanglesTextBoxHeight_Leave);
            // 
            // RectanglesLabelHeight
            // 
            this.RectanglesLabelHeight.AutoSize = true;
            this.RectanglesLabelHeight.Location = new System.Drawing.Point(3, 2);
            this.RectanglesLabelHeight.Name = "RectanglesLabelHeight";
            this.RectanglesLabelHeight.Size = new System.Drawing.Size(41, 13);
            this.RectanglesLabelHeight.TabIndex = 9;
            this.RectanglesLabelHeight.Text = "Height:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RectanglesLabelId);
            this.panel2.Controls.Add(this.RectanglesTextBoxId);
            this.panel2.Location = new System.Drawing.Point(2, 222);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 16);
            this.panel2.TabIndex = 17;
            // 
            // RectanglesLabelId
            // 
            this.RectanglesLabelId.AutoSize = true;
            this.RectanglesLabelId.Location = new System.Drawing.Point(22, 2);
            this.RectanglesLabelId.Name = "RectanglesLabelId";
            this.RectanglesLabelId.Size = new System.Drawing.Size(19, 13);
            this.RectanglesLabelId.TabIndex = 5;
            this.RectanglesLabelId.Text = "Id:";
            // 
            // RectanglesTextBoxId
            // 
            this.RectanglesTextBoxId.Location = new System.Drawing.Point(54, -2);
            this.RectanglesTextBoxId.Name = "RectanglesTextBoxId";
            this.RectanglesTextBoxId.ReadOnly = true;
            this.RectanglesTextBoxId.Size = new System.Drawing.Size(61, 20);
            this.RectanglesTextBoxId.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.RectanglesTextBoxWidth);
            this.panel5.Controls.Add(this.RectanglesLabelWidth);
            this.panel5.Location = new System.Drawing.Point(2, 290);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 16);
            this.panel5.TabIndex = 18;
            // 
            // RectanglesTextBoxWidth
            // 
            this.RectanglesTextBoxWidth.Location = new System.Drawing.Point(54, 0);
            this.RectanglesTextBoxWidth.Name = "RectanglesTextBoxWidth";
            this.RectanglesTextBoxWidth.Size = new System.Drawing.Size(61, 20);
            this.RectanglesTextBoxWidth.TabIndex = 13;
            this.RectanglesTextBoxWidth.Leave += new System.EventHandler(this.RectanglesTextBoxWidth_Leave);
            // 
            // RectanglesLabelWidth
            // 
            this.RectanglesLabelWidth.AutoSize = true;
            this.RectanglesLabelWidth.Location = new System.Drawing.Point(6, 2);
            this.RectanglesLabelWidth.Name = "RectanglesLabelWidth";
            this.RectanglesLabelWidth.Size = new System.Drawing.Size(38, 13);
            this.RectanglesLabelWidth.TabIndex = 8;
            this.RectanglesLabelWidth.Text = "Width:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RectanglesTextBoxY);
            this.panel4.Controls.Add(this.RectanglesLabelY);
            this.panel4.Location = new System.Drawing.Point(2, 267);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 16);
            this.panel4.TabIndex = 18;
            // 
            // RectanglesTextBoxY
            // 
            this.RectanglesTextBoxY.Location = new System.Drawing.Point(54, 0);
            this.RectanglesTextBoxY.Name = "RectanglesTextBoxY";
            this.RectanglesTextBoxY.Size = new System.Drawing.Size(61, 20);
            this.RectanglesTextBoxY.TabIndex = 12;
            this.RectanglesTextBoxY.Leave += new System.EventHandler(this.RectanglesTextBoxY_Leave);
            // 
            // RectanglesLabelY
            // 
            this.RectanglesLabelY.AutoSize = true;
            this.RectanglesLabelY.Location = new System.Drawing.Point(23, 2);
            this.RectanglesLabelY.Name = "RectanglesLabelY";
            this.RectanglesLabelY.Size = new System.Drawing.Size(17, 13);
            this.RectanglesLabelY.TabIndex = 7;
            this.RectanglesLabelY.Text = "Y:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RectanglesLabelX);
            this.panel3.Controls.Add(this.RectanglesTextBoxX);
            this.panel3.Location = new System.Drawing.Point(2, 245);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 16);
            this.panel3.TabIndex = 17;
            // 
            // RectanglesLabelX
            // 
            this.RectanglesLabelX.AutoSize = true;
            this.RectanglesLabelX.Location = new System.Drawing.Point(24, 2);
            this.RectanglesLabelX.Name = "RectanglesLabelX";
            this.RectanglesLabelX.Size = new System.Drawing.Size(17, 13);
            this.RectanglesLabelX.TabIndex = 6;
            this.RectanglesLabelX.Text = "X:";
            // 
            // RectanglesTextBoxX
            // 
            this.RectanglesTextBoxX.Location = new System.Drawing.Point(54, 0);
            this.RectanglesTextBoxX.Name = "RectanglesTextBoxX";
            this.RectanglesTextBoxX.Size = new System.Drawing.Size(61, 20);
            this.RectanglesTextBoxX.TabIndex = 11;
            this.RectanglesTextBoxX.Leave += new System.EventHandler(this.RectanglesTextBoxX_Leave);
            // 
            // RectanglesLabelSelected
            // 
            this.RectanglesLabelSelected.AutoSize = true;
            this.RectanglesLabelSelected.Location = new System.Drawing.Point(3, 197);
            this.RectanglesLabelSelected.Name = "RectanglesLabelSelected";
            this.RectanglesLabelSelected.Size = new System.Drawing.Size(104, 13);
            this.RectanglesLabelSelected.TabIndex = 4;
            this.RectanglesLabelSelected.Text = "Selected Rectangle:";
            // 
            // RectanglesTableLayoutPanel
            // 
            this.RectanglesTableLayoutPanel.ColumnCount = 1;
            this.RectanglesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesTableLayoutPanel.Controls.Add(this.RectanglesPanel, 0, 0);
            this.RectanglesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RectanglesTableLayoutPanel.Location = new System.Drawing.Point(205, 0);
            this.RectanglesTableLayoutPanel.Name = "RectanglesTableLayoutPanel";
            this.RectanglesTableLayoutPanel.RowCount = 1;
            this.RectanglesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesTableLayoutPanel.Size = new System.Drawing.Size(537, 410);
            this.RectanglesTableLayoutPanel.TabIndex = 16;
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesPanel.Location = new System.Drawing.Point(3, 3);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(531, 404);
            this.RectanglesPanel.TabIndex = 15;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesLeftLayoutPanel);
            this.Controls.Add(this.RectanglesTableLayoutPanel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(742, 410);
            ((System.ComponentModel.ISupportInitialize)(this.RectanglesButtonRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectanglesButtonAdd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.RectanglesLeftLayoutPanel.ResumeLayout(false);
            this.RectanglesLeftLayoutPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.RectanglesTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RectanglesLabelRectangles;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.PictureBox RectanglesButtonRemove;
        private System.Windows.Forms.PictureBox RectanglesButtonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel RectanglesLeftLayoutPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox RectanglesTextBoxHeight;
        private System.Windows.Forms.Label RectanglesLabelHeight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RectanglesLabelId;
        private System.Windows.Forms.TextBox RectanglesTextBoxId;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox RectanglesTextBoxWidth;
        private System.Windows.Forms.Label RectanglesLabelWidth;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox RectanglesTextBoxY;
        private System.Windows.Forms.Label RectanglesLabelY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RectanglesLabelX;
        private System.Windows.Forms.TextBox RectanglesTextBoxX;
        private System.Windows.Forms.Label RectanglesLabelSelected;
        private System.Windows.Forms.TableLayoutPanel RectanglesTableLayoutPanel;
        private System.Windows.Forms.Panel RectanglesPanel;
    }
}
