namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            tableLayoutPanelOrdersTab = new TableLayoutPanel();
            panelOrderTable = new Panel();
            dataGridViewOrders = new DataGridView();
            labelOrders = new Label();
            panelOrderData = new Panel();
            labelOrdersAmount = new Label();
            labelAmount = new Label();
            listBoxOrderItems = new ListBox();
            labelOrderItems = new Label();
            addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            comboBoxStatus = new ComboBox();
            textBoxCreated = new TextBox();
            textBoxId = new TextBox();
            labelStatus = new Label();
            labelCreated = new Label();
            labelId = new Label();
            labelSelectedOrder = new Label();
            Id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            tableLayoutPanelOrdersTab.SuspendLayout();
            panelOrderTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panelOrderData.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelOrdersTab
            // 
            tableLayoutPanelOrdersTab.ColumnCount = 2;
            tableLayoutPanelOrdersTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelOrdersTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelOrdersTab.Controls.Add(panelOrderTable, 0, 0);
            tableLayoutPanelOrdersTab.Controls.Add(panelOrderData, 1, 0);
            tableLayoutPanelOrdersTab.Dock = DockStyle.Fill;
            tableLayoutPanelOrdersTab.Location = new Point(0, 0);
            tableLayoutPanelOrdersTab.Name = "tableLayoutPanelOrdersTab";
            tableLayoutPanelOrdersTab.RowCount = 1;
            tableLayoutPanelOrdersTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelOrdersTab.Size = new Size(669, 423);
            tableLayoutPanelOrdersTab.TabIndex = 0;
            // 
            // panelOrderTable
            // 
            panelOrderTable.Controls.Add(dataGridViewOrders);
            panelOrderTable.Controls.Add(labelOrders);
            panelOrderTable.Dock = DockStyle.Fill;
            panelOrderTable.Location = new Point(3, 3);
            panelOrderTable.Name = "panelOrderTable";
            panelOrderTable.Size = new Size(261, 417);
            panelOrderTable.TabIndex = 0;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.AllowUserToResizeColumns = false;
            dataGridViewOrders.AllowUserToResizeRows = false;
            dataGridViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { Id, Created, OrderStatus, Customer, Address, Cost });
            dataGridViewOrders.Location = new Point(3, 18);
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.Size = new Size(255, 396);
            dataGridViewOrders.TabIndex = 1;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelOrders.Location = new Point(0, 0);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(45, 15);
            labelOrders.TabIndex = 0;
            labelOrders.Text = "Orders";
            // 
            // panelOrderData
            // 
            panelOrderData.Controls.Add(labelOrdersAmount);
            panelOrderData.Controls.Add(labelAmount);
            panelOrderData.Controls.Add(listBoxOrderItems);
            panelOrderData.Controls.Add(labelOrderItems);
            panelOrderData.Controls.Add(addressControl);
            panelOrderData.Controls.Add(comboBoxStatus);
            panelOrderData.Controls.Add(textBoxCreated);
            panelOrderData.Controls.Add(textBoxId);
            panelOrderData.Controls.Add(labelStatus);
            panelOrderData.Controls.Add(labelCreated);
            panelOrderData.Controls.Add(labelId);
            panelOrderData.Controls.Add(labelSelectedOrder);
            panelOrderData.Dock = DockStyle.Fill;
            panelOrderData.Location = new Point(270, 3);
            panelOrderData.Name = "panelOrderData";
            panelOrderData.Size = new Size(396, 417);
            panelOrderData.TabIndex = 1;
            // 
            // labelOrdersAmount
            // 
            labelOrdersAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelOrdersAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelOrdersAmount.Location = new Point(-3, 386);
            labelOrdersAmount.Name = "labelOrdersAmount";
            labelOrdersAmount.Size = new Size(393, 28);
            labelOrdersAmount.TabIndex = 11;
            labelOrdersAmount.Text = "0";
            labelOrdersAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAmount.Location = new Point(332, 359);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(58, 15);
            labelAmount.TabIndex = 10;
            labelAmount.Text = "Amount :";
            // 
            // listBoxOrderItems
            // 
            listBoxOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxOrderItems.DisplayMember = "Name";
            listBoxOrderItems.FormattingEnabled = true;
            listBoxOrderItems.Location = new Point(3, 292);
            listBoxOrderItems.Name = "listBoxOrderItems";
            listBoxOrderItems.Size = new Size(387, 64);
            listBoxOrderItems.TabIndex = 9;
            // 
            // labelOrderItems
            // 
            labelOrderItems.AutoSize = true;
            labelOrderItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelOrderItems.Location = new Point(3, 274);
            labelOrderItems.Name = "labelOrderItems";
            labelOrderItems.Size = new Size(75, 15);
            labelOrderItems.TabIndex = 8;
            labelOrderItems.Text = "Order Items";
            // 
            // addressControl
            // 
            addressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl.Location = new Point(0, 100);
            addressControl.Name = "addressControl";
            addressControl.ReadOnly = true;
            addressControl.Size = new Size(390, 171);
            addressControl.TabIndex = 7;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(70, 71);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(130, 23);
            comboBoxStatus.TabIndex = 6;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // textBoxCreated
            // 
            textBoxCreated.Location = new Point(70, 42);
            textBoxCreated.Name = "textBoxCreated";
            textBoxCreated.ReadOnly = true;
            textBoxCreated.Size = new Size(130, 23);
            textBoxCreated.TabIndex = 5;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(70, 15);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(130, 23);
            textBoxId.TabIndex = 4;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(3, 74);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(45, 15);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "Status :";
            // 
            // labelCreated
            // 
            labelCreated.AutoSize = true;
            labelCreated.Location = new Point(0, 45);
            labelCreated.Name = "labelCreated";
            labelCreated.Size = new Size(54, 15);
            labelCreated.TabIndex = 2;
            labelCreated.Text = "Created :";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(3, 18);
            labelId.Name = "labelId";
            labelId.Size = new Size(24, 15);
            labelId.TabIndex = 1;
            labelId.Text = "ID :";
            // 
            // labelSelectedOrder
            // 
            labelSelectedOrder.AutoSize = true;
            labelSelectedOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSelectedOrder.Location = new Point(3, 0);
            labelSelectedOrder.Name = "labelSelectedOrder";
            labelSelectedOrder.Size = new Size(92, 15);
            labelSelectedOrder.TabIndex = 0;
            labelSelectedOrder.Text = "Selected Order";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id.Width = 40;
            // 
            // Created
            // 
            Created.DataPropertyName = "Date";
            Created.HeaderText = "Created";
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderStatus
            // 
            OrderStatus.DataPropertyName = "Status";
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Customer
            // 
            Customer.DataPropertyName = "CustomerName";
            Customer.HeaderText = "Customer Full Name";
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            Customer.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cost
            // 
            Cost.DataPropertyName = "Amount";
            Cost.HeaderText = "Cost";
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            Cost.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelOrdersTab);
            Name = "OrdersTab";
            Size = new Size(669, 423);
            tableLayoutPanelOrdersTab.ResumeLayout(false);
            panelOrderTable.ResumeLayout(false);
            panelOrderTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panelOrderData.ResumeLayout(false);
            panelOrderData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelOrdersTab;
        private Panel panelOrderTable;
        private Panel panelOrderData;
        private Label labelOrders;
        private DataGridView dataGridViewOrders;
        private Label labelSelectedOrder;
        private TextBox textBoxId;
        private Label labelStatus;
        private Label labelCreated;
        private Label labelId;
        private TextBox textBoxCreated;
        private ComboBox comboBoxStatus;
        private Controls.AddressControl addressControl;
        private Label labelOrderItems;
        private Label labelOrdersAmount;
        private Label labelAmount;
        private ListBox listBoxOrderItems;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Cost;
    }
}
