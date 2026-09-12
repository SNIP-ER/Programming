namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPageItems = new TabPage();
            itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            tabControl.SuspendLayout();
            tabPageItems.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageItems);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(2, 1, 2, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(681, 447);
            tabControl.TabIndex = 0;
            // 
            // tabPageItems
            // 
            tabPageItems.Controls.Add(itemsTab);
            tabPageItems.Location = new Point(4, 24);
            tabPageItems.Margin = new Padding(2, 1, 2, 1);
            tabPageItems.Name = "tabPageItems";
            tabPageItems.Padding = new Padding(2, 1, 2, 1);
            tabPageItems.Size = new Size(673, 419);
            tabPageItems.TabIndex = 0;
            tabPageItems.Text = "Items";
            tabPageItems.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(2, 1);
            itemsTab.Margin = new Padding(2, 1, 2, 1);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(669, 417);
            itemsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 447);
            Controls.Add(tabControl);
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(470, 380);
            Name = "MainForm";
            Text = "MainForm";
            tabControl.ResumeLayout(false);
            tabPageItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageItems;
        private View.Tabs.ItemsTab itemsTab;
    }
}
