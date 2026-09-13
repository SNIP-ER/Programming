namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            tableLayoutPanelCustomersTab = new TableLayoutPanel();
            panelCustomers = new Panel();
            listBoxCustomers = new ListBox();
            labelCustomers = new Label();
            tableLayoutPanelCustomersButtons = new TableLayoutPanel();
            buttonCustomersAdd = new Button();
            buttonCustomersRemove = new Button();
            panelSelectedCustomer = new Panel();
            tableLayoutPanelSelectedCustomer = new TableLayoutPanel();
            panelSelectedCustomerInfo = new Panel();
            textBoxSelectedCustomerAddress = new TextBox();
            textBoxSelectedCustomerFullName = new TextBox();
            textBoxSelectedCustomerId = new TextBox();
            labelSelectedCustomerAddress = new Label();
            labelSelectedCustomerFullName = new Label();
            labelSelectedCustomerId = new Label();
            labelSelectedCustomer = new Label();
            panel1 = new Panel();
            tableLayoutPanelCustomersTab.SuspendLayout();
            panelCustomers.SuspendLayout();
            tableLayoutPanelCustomersButtons.SuspendLayout();
            panelSelectedCustomer.SuspendLayout();
            tableLayoutPanelSelectedCustomer.SuspendLayout();
            panelSelectedCustomerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelCustomersTab
            // 
            tableLayoutPanelCustomersTab.ColumnCount = 2;
            tableLayoutPanelCustomersTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelCustomersTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelCustomersTab.Controls.Add(panelCustomers, 0, 0);
            tableLayoutPanelCustomersTab.Controls.Add(panelSelectedCustomer, 1, 0);
            tableLayoutPanelCustomersTab.Dock = DockStyle.Fill;
            tableLayoutPanelCustomersTab.Location = new Point(0, 0);
            tableLayoutPanelCustomersTab.Name = "tableLayoutPanelCustomersTab";
            tableLayoutPanelCustomersTab.RowCount = 1;
            tableLayoutPanelCustomersTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCustomersTab.Size = new Size(669, 423);
            tableLayoutPanelCustomersTab.TabIndex = 0;
            // 
            // panelCustomers
            // 
            panelCustomers.Controls.Add(listBoxCustomers);
            panelCustomers.Controls.Add(labelCustomers);
            panelCustomers.Controls.Add(tableLayoutPanelCustomersButtons);
            panelCustomers.Dock = DockStyle.Fill;
            panelCustomers.Location = new Point(3, 3);
            panelCustomers.Name = "panelCustomers";
            panelCustomers.Size = new Size(261, 417);
            panelCustomers.TabIndex = 0;
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.Location = new Point(4, 24);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(254, 334);
            listBoxCustomers.TabIndex = 2;
            listBoxCustomers.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
            // 
            // labelCustomers
            // 
            labelCustomers.AutoSize = true;
            labelCustomers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCustomers.Location = new Point(4, 6);
            labelCustomers.Name = "labelCustomers";
            labelCustomers.Size = new Size(66, 15);
            labelCustomers.TabIndex = 1;
            labelCustomers.Text = "Customers";
            // 
            // tableLayoutPanelCustomersButtons
            // 
            tableLayoutPanelCustomersButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanelCustomersButtons.ColumnCount = 3;
            tableLayoutPanelCustomersButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCustomersButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCustomersButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCustomersButtons.Controls.Add(buttonCustomersAdd, 0, 0);
            tableLayoutPanelCustomersButtons.Controls.Add(buttonCustomersRemove, 1, 0);
            tableLayoutPanelCustomersButtons.Location = new Point(0, 364);
            tableLayoutPanelCustomersButtons.Name = "tableLayoutPanelCustomersButtons";
            tableLayoutPanelCustomersButtons.RowCount = 1;
            tableLayoutPanelCustomersButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCustomersButtons.Size = new Size(261, 50);
            tableLayoutPanelCustomersButtons.TabIndex = 0;
            // 
            // buttonCustomersAdd
            // 
            buttonCustomersAdd.Dock = DockStyle.Fill;
            buttonCustomersAdd.Location = new Point(3, 3);
            buttonCustomersAdd.Name = "buttonCustomersAdd";
            buttonCustomersAdd.Size = new Size(81, 44);
            buttonCustomersAdd.TabIndex = 0;
            buttonCustomersAdd.Text = "Add";
            buttonCustomersAdd.UseVisualStyleBackColor = true;
            buttonCustomersAdd.Click += buttonCustomersAdd_Click;
            // 
            // buttonCustomersRemove
            // 
            buttonCustomersRemove.Dock = DockStyle.Fill;
            buttonCustomersRemove.Location = new Point(90, 3);
            buttonCustomersRemove.Name = "buttonCustomersRemove";
            buttonCustomersRemove.Size = new Size(81, 44);
            buttonCustomersRemove.TabIndex = 1;
            buttonCustomersRemove.Text = "Remove";
            buttonCustomersRemove.UseVisualStyleBackColor = true;
            buttonCustomersRemove.Click += buttonCustomersRemove_Click;
            // 
            // panelSelectedCustomer
            // 
            panelSelectedCustomer.Controls.Add(tableLayoutPanelSelectedCustomer);
            panelSelectedCustomer.Dock = DockStyle.Fill;
            panelSelectedCustomer.Location = new Point(270, 3);
            panelSelectedCustomer.Name = "panelSelectedCustomer";
            panelSelectedCustomer.Size = new Size(396, 417);
            panelSelectedCustomer.TabIndex = 1;
            // 
            // tableLayoutPanelSelectedCustomer
            // 
            tableLayoutPanelSelectedCustomer.ColumnCount = 1;
            tableLayoutPanelSelectedCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelSelectedCustomer.Controls.Add(panelSelectedCustomerInfo, 0, 0);
            tableLayoutPanelSelectedCustomer.Controls.Add(panel1, 0, 1);
            tableLayoutPanelSelectedCustomer.Dock = DockStyle.Fill;
            tableLayoutPanelSelectedCustomer.Location = new Point(0, 0);
            tableLayoutPanelSelectedCustomer.Name = "tableLayoutPanelSelectedCustomer";
            tableLayoutPanelSelectedCustomer.RowCount = 2;
            tableLayoutPanelSelectedCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelSelectedCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanelSelectedCustomer.Size = new Size(396, 417);
            tableLayoutPanelSelectedCustomer.TabIndex = 0;
            // 
            // panelSelectedCustomerInfo
            // 
            panelSelectedCustomerInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSelectedCustomerInfo.BackColor = Color.White;
            panelSelectedCustomerInfo.Controls.Add(textBoxSelectedCustomerAddress);
            panelSelectedCustomerInfo.Controls.Add(textBoxSelectedCustomerFullName);
            panelSelectedCustomerInfo.Controls.Add(textBoxSelectedCustomerId);
            panelSelectedCustomerInfo.Controls.Add(labelSelectedCustomerAddress);
            panelSelectedCustomerInfo.Controls.Add(labelSelectedCustomerFullName);
            panelSelectedCustomerInfo.Controls.Add(labelSelectedCustomerId);
            panelSelectedCustomerInfo.Controls.Add(labelSelectedCustomer);
            panelSelectedCustomerInfo.Location = new Point(3, 3);
            panelSelectedCustomerInfo.Name = "panelSelectedCustomerInfo";
            panelSelectedCustomerInfo.Size = new Size(390, 160);
            panelSelectedCustomerInfo.TabIndex = 0;
            // 
            // textBoxSelectedCustomerAddress
            // 
            textBoxSelectedCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSelectedCustomerAddress.Location = new Point(83, 83);
            textBoxSelectedCustomerAddress.Multiline = true;
            textBoxSelectedCustomerAddress.Name = "textBoxSelectedCustomerAddress";
            textBoxSelectedCustomerAddress.Size = new Size(304, 74);
            textBoxSelectedCustomerAddress.TabIndex = 9;
            textBoxSelectedCustomerAddress.Leave += textBoxSelectedCustomerAddress_Leave;
            // 
            // textBoxSelectedCustomerFullName
            // 
            textBoxSelectedCustomerFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSelectedCustomerFullName.Location = new Point(83, 54);
            textBoxSelectedCustomerFullName.Name = "textBoxSelectedCustomerFullName";
            textBoxSelectedCustomerFullName.Size = new Size(304, 23);
            textBoxSelectedCustomerFullName.TabIndex = 8;
            textBoxSelectedCustomerFullName.Leave += textBoxSelectedCustomerFullName_Leave;
            // 
            // textBoxSelectedCustomerId
            // 
            textBoxSelectedCustomerId.Location = new Point(83, 27);
            textBoxSelectedCustomerId.Name = "textBoxSelectedCustomerId";
            textBoxSelectedCustomerId.ReadOnly = true;
            textBoxSelectedCustomerId.Size = new Size(100, 23);
            textBoxSelectedCustomerId.TabIndex = 7;
            // 
            // labelSelectedCustomerAddress
            // 
            labelSelectedCustomerAddress.AutoSize = true;
            labelSelectedCustomerAddress.Location = new Point(3, 86);
            labelSelectedCustomerAddress.Name = "labelSelectedCustomerAddress";
            labelSelectedCustomerAddress.Size = new Size(52, 15);
            labelSelectedCustomerAddress.TabIndex = 6;
            labelSelectedCustomerAddress.Text = "Address:";
            // 
            // labelSelectedCustomerFullName
            // 
            labelSelectedCustomerFullName.AutoSize = true;
            labelSelectedCustomerFullName.Location = new Point(3, 57);
            labelSelectedCustomerFullName.Name = "labelSelectedCustomerFullName";
            labelSelectedCustomerFullName.Size = new Size(64, 15);
            labelSelectedCustomerFullName.TabIndex = 5;
            labelSelectedCustomerFullName.Text = "Full Name:";
            // 
            // labelSelectedCustomerId
            // 
            labelSelectedCustomerId.AutoSize = true;
            labelSelectedCustomerId.Location = new Point(3, 30);
            labelSelectedCustomerId.Name = "labelSelectedCustomerId";
            labelSelectedCustomerId.Size = new Size(21, 15);
            labelSelectedCustomerId.TabIndex = 4;
            labelSelectedCustomerId.Text = "ID:";
            // 
            // labelSelectedCustomer
            // 
            labelSelectedCustomer.AutoSize = true;
            labelSelectedCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSelectedCustomer.Location = new Point(3, 3);
            labelSelectedCustomer.Name = "labelSelectedCustomer";
            labelSelectedCustomer.Size = new Size(113, 15);
            labelSelectedCustomer.TabIndex = 3;
            labelSelectedCustomer.Text = "Selected Customer";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(3, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 245);
            panel1.TabIndex = 1;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelCustomersTab);
            Name = "CustomersTab";
            Size = new Size(669, 423);
            tableLayoutPanelCustomersTab.ResumeLayout(false);
            panelCustomers.ResumeLayout(false);
            panelCustomers.PerformLayout();
            tableLayoutPanelCustomersButtons.ResumeLayout(false);
            panelSelectedCustomer.ResumeLayout(false);
            tableLayoutPanelSelectedCustomer.ResumeLayout(false);
            panelSelectedCustomerInfo.ResumeLayout(false);
            panelSelectedCustomerInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelCustomersTab;
        private Panel panelCustomers;
        private TableLayoutPanel tableLayoutPanelCustomersButtons;
        private Label labelCustomers;
        private ListBox listBoxCustomers;
        private Panel panelSelectedCustomer;
        private TableLayoutPanel tableLayoutPanelSelectedCustomer;
        private Panel panelSelectedCustomerInfo;
        private Panel panel1;
        private Label labelSelectedCustomer;
        private TextBox textBoxSelectedCustomerId;
        private Label labelSelectedCustomerAddress;
        private Label labelSelectedCustomerFullName;
        private Label labelSelectedCustomerId;
        private TextBox textBoxSelectedCustomerAddress;
        private TextBox textBoxSelectedCustomerFullName;
        private Button buttonCustomersAdd;
        private Button buttonCustomersRemove;
    }
}
