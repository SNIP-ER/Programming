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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl = new TabControl();
            tabPageItems = new TabPage();
            itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            tabPageCustomers = new TabPage();
            customersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabPageCarts = new TabPage();
            cartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            tabControl.SuspendLayout();
            tabPageItems.SuspendLayout();
            tabPageCustomers.SuspendLayout();
            tabPageCarts.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageItems);
            tabControl.Controls.Add(tabPageCustomers);
            tabControl.Controls.Add(tabPageCarts);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(2, 1, 2, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(681, 447);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
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
            // tabPageCustomers
            // 
            tabPageCustomers.Controls.Add(customersTab);
            tabPageCustomers.Location = new Point(4, 24);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Size = new Size(673, 419);
            tabPageCustomers.TabIndex = 1;
            tabPageCustomers.Text = "Customers";
            tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(0, 0);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(673, 419);
            customersTab.TabIndex = 0;
            // 
            // tabPageCarts
            // 
            tabPageCarts.Controls.Add(cartsTab);
            tabPageCarts.Location = new Point(4, 24);
            tabPageCarts.Name = "tabPageCarts";
            tabPageCarts.Size = new Size(673, 419);
            tabPageCarts.TabIndex = 2;
            tabPageCarts.Text = "Carts";
            tabPageCarts.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            cartsTab.Dock = DockStyle.Fill;
            cartsTab.Location = new Point(0, 0);
            cartsTab.Name = "cartsTab";
            cartsTab.Size = new Size(673, 419);
            cartsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 447);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(470, 380);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl.ResumeLayout(false);
            tabPageItems.ResumeLayout(false);
            tabPageCustomers.ResumeLayout(false);
            tabPageCarts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageItems;
        private View.Tabs.ItemsTab itemsTab;
        private TabPage tabPageCustomers;
        private View.Tabs.CustomersTab customersTab;
        private TabPage tabPageCarts;
        private View.Tabs.CartsTab cartsTab;
    }
}
