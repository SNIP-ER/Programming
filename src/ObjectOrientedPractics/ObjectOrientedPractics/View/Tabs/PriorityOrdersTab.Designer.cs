namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            panelOrderData = new Panel();
            comboBoxDeliveryTimePriority = new ComboBox();
            labelDeliveryTimePriority = new Label();
            labelPriorityOptions = new Label();
            buttonClearOrderPriority = new Button();
            buttonRemoveItemPriority = new Button();
            buttonAddItemPriority = new Button();
            labelOrdersAmountPriority = new Label();
            labelAmountPriority = new Label();
            listBoxOrderItemsPriority = new ListBox();
            labelOrderItemsPriority = new Label();
            addressControlPriority = new ObjectOrientedPractics.View.Controls.AddressControl();
            comboBoxStatusPriority = new ComboBox();
            textBoxCreatedPriority = new TextBox();
            textBoxIdPriority = new TextBox();
            labelStatusPriority = new Label();
            labelCreatedPriority = new Label();
            labelIdPriority = new Label();
            labelSelectedOrderPriority = new Label();
            panelOrderData.SuspendLayout();
            SuspendLayout();
            // 
            // panelOrderData
            // 
            panelOrderData.Controls.Add(comboBoxDeliveryTimePriority);
            panelOrderData.Controls.Add(labelDeliveryTimePriority);
            panelOrderData.Controls.Add(labelPriorityOptions);
            panelOrderData.Controls.Add(buttonClearOrderPriority);
            panelOrderData.Controls.Add(buttonRemoveItemPriority);
            panelOrderData.Controls.Add(buttonAddItemPriority);
            panelOrderData.Controls.Add(labelOrdersAmountPriority);
            panelOrderData.Controls.Add(labelAmountPriority);
            panelOrderData.Controls.Add(listBoxOrderItemsPriority);
            panelOrderData.Controls.Add(labelOrderItemsPriority);
            panelOrderData.Controls.Add(addressControlPriority);
            panelOrderData.Controls.Add(comboBoxStatusPriority);
            panelOrderData.Controls.Add(textBoxCreatedPriority);
            panelOrderData.Controls.Add(textBoxIdPriority);
            panelOrderData.Controls.Add(labelStatusPriority);
            panelOrderData.Controls.Add(labelCreatedPriority);
            panelOrderData.Controls.Add(labelIdPriority);
            panelOrderData.Controls.Add(labelSelectedOrderPriority);
            panelOrderData.Dock = DockStyle.Fill;
            panelOrderData.Location = new Point(0, 0);
            panelOrderData.Name = "panelOrderData";
            panelOrderData.Size = new Size(669, 423);
            panelOrderData.TabIndex = 2;
            // 
            // comboBoxDeliveryTimePriority
            // 
            comboBoxDeliveryTimePriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeliveryTimePriority.FormattingEnabled = true;
            comboBoxDeliveryTimePriority.Location = new Point(322, 18);
            comboBoxDeliveryTimePriority.Name = "comboBoxDeliveryTimePriority";
            comboBoxDeliveryTimePriority.Size = new Size(121, 23);
            comboBoxDeliveryTimePriority.TabIndex = 17;
            comboBoxDeliveryTimePriority.SelectedIndexChanged += comboBoxDeliveryTimePriority_SelectedIndexChanged;
            // 
            // labelDeliveryTimePriority
            // 
            labelDeliveryTimePriority.AutoSize = true;
            labelDeliveryTimePriority.Location = new Point(235, 21);
            labelDeliveryTimePriority.Name = "labelDeliveryTimePriority";
            labelDeliveryTimePriority.Size = new Size(81, 15);
            labelDeliveryTimePriority.TabIndex = 16;
            labelDeliveryTimePriority.Text = "Delivery Time:";
            // 
            // labelPriorityOptions
            // 
            labelPriorityOptions.AutoSize = true;
            labelPriorityOptions.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPriorityOptions.Location = new Point(235, -2);
            labelPriorityOptions.Name = "labelPriorityOptions";
            labelPriorityOptions.Size = new Size(94, 15);
            labelPriorityOptions.TabIndex = 15;
            labelPriorityOptions.Text = "Priority Options";
            // 
            // buttonClearOrderPriority
            // 
            buttonClearOrderPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClearOrderPriority.Location = new Point(586, 377);
            buttonClearOrderPriority.Name = "buttonClearOrderPriority";
            buttonClearOrderPriority.Size = new Size(80, 34);
            buttonClearOrderPriority.TabIndex = 14;
            buttonClearOrderPriority.Text = "Clear Order";
            buttonClearOrderPriority.UseVisualStyleBackColor = true;
            buttonClearOrderPriority.Click += buttonClearOrderPriority_Click;
            // 
            // buttonRemoveItemPriority
            // 
            buttonRemoveItemPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemoveItemPriority.Location = new Point(142, 377);
            buttonRemoveItemPriority.Name = "buttonRemoveItemPriority";
            buttonRemoveItemPriority.Size = new Size(97, 34);
            buttonRemoveItemPriority.TabIndex = 13;
            buttonRemoveItemPriority.Text = "Remove Item";
            buttonRemoveItemPriority.UseVisualStyleBackColor = true;
            buttonRemoveItemPriority.Click += buttonRemoveItemPriority_Click;
            // 
            // buttonAddItemPriority
            // 
            buttonAddItemPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddItemPriority.Location = new Point(14, 377);
            buttonAddItemPriority.Name = "buttonAddItemPriority";
            buttonAddItemPriority.Size = new Size(97, 34);
            buttonAddItemPriority.TabIndex = 12;
            buttonAddItemPriority.Text = "Add Item";
            buttonAddItemPriority.UseVisualStyleBackColor = true;
            buttonAddItemPriority.Click += buttonAddItemPriority_Click;
            // 
            // labelOrdersAmountPriority
            // 
            labelOrdersAmountPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelOrdersAmountPriority.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelOrdersAmountPriority.Location = new Point(398, 343);
            labelOrdersAmountPriority.Name = "labelOrdersAmountPriority";
            labelOrdersAmountPriority.Size = new Size(271, 28);
            labelOrdersAmountPriority.TabIndex = 11;
            labelOrdersAmountPriority.Text = "0";
            labelOrdersAmountPriority.TextAlign = ContentAlignment.TopRight;
            // 
            // labelAmountPriority
            // 
            labelAmountPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmountPriority.AutoSize = true;
            labelAmountPriority.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAmountPriority.Location = new Point(586, 322);
            labelAmountPriority.Name = "labelAmountPriority";
            labelAmountPriority.Size = new Size(80, 21);
            labelAmountPriority.TabIndex = 10;
            labelAmountPriority.Text = "Amount :";
            // 
            // listBoxOrderItemsPriority
            // 
            listBoxOrderItemsPriority.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxOrderItemsPriority.DisplayMember = "Name";
            listBoxOrderItemsPriority.FormattingEnabled = true;
            listBoxOrderItemsPriority.Location = new Point(14, 292);
            listBoxOrderItemsPriority.Name = "listBoxOrderItemsPriority";
            listBoxOrderItemsPriority.Size = new Size(378, 79);
            listBoxOrderItemsPriority.TabIndex = 9;
            // 
            // labelOrderItemsPriority
            // 
            labelOrderItemsPriority.AutoSize = true;
            labelOrderItemsPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelOrderItemsPriority.Location = new Point(14, 274);
            labelOrderItemsPriority.Name = "labelOrderItemsPriority";
            labelOrderItemsPriority.Size = new Size(75, 15);
            labelOrderItemsPriority.TabIndex = 8;
            labelOrderItemsPriority.Text = "Order Items";
            // 
            // addressControlPriority
            // 
            addressControlPriority.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControlPriority.Location = new Point(0, 100);
            addressControlPriority.Name = "addressControlPriority";
            addressControlPriority.ReadOnly = true;
            addressControlPriority.Size = new Size(654, 171);
            addressControlPriority.TabIndex = 7;
            // 
            // comboBoxStatusPriority
            // 
            comboBoxStatusPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusPriority.FormattingEnabled = true;
            comboBoxStatusPriority.Location = new Point(70, 71);
            comboBoxStatusPriority.Name = "comboBoxStatusPriority";
            comboBoxStatusPriority.Size = new Size(130, 23);
            comboBoxStatusPriority.TabIndex = 6;
            comboBoxStatusPriority.SelectedIndexChanged += comboBoxStatusPriority_SelectedIndexChanged;
            // 
            // textBoxCreatedPriority
            // 
            textBoxCreatedPriority.Location = new Point(70, 42);
            textBoxCreatedPriority.Name = "textBoxCreatedPriority";
            textBoxCreatedPriority.ReadOnly = true;
            textBoxCreatedPriority.Size = new Size(130, 23);
            textBoxCreatedPriority.TabIndex = 5;
            // 
            // textBoxIdPriority
            // 
            textBoxIdPriority.Location = new Point(70, 15);
            textBoxIdPriority.Name = "textBoxIdPriority";
            textBoxIdPriority.ReadOnly = true;
            textBoxIdPriority.Size = new Size(130, 23);
            textBoxIdPriority.TabIndex = 4;
            // 
            // labelStatusPriority
            // 
            labelStatusPriority.AutoSize = true;
            labelStatusPriority.Location = new Point(3, 74);
            labelStatusPriority.Name = "labelStatusPriority";
            labelStatusPriority.Size = new Size(45, 15);
            labelStatusPriority.TabIndex = 3;
            labelStatusPriority.Text = "Status :";
            // 
            // labelCreatedPriority
            // 
            labelCreatedPriority.AutoSize = true;
            labelCreatedPriority.Location = new Point(0, 45);
            labelCreatedPriority.Name = "labelCreatedPriority";
            labelCreatedPriority.Size = new Size(54, 15);
            labelCreatedPriority.TabIndex = 2;
            labelCreatedPriority.Text = "Created :";
            // 
            // labelIdPriority
            // 
            labelIdPriority.AutoSize = true;
            labelIdPriority.Location = new Point(3, 18);
            labelIdPriority.Name = "labelIdPriority";
            labelIdPriority.Size = new Size(24, 15);
            labelIdPriority.TabIndex = 1;
            labelIdPriority.Text = "ID :";
            // 
            // labelSelectedOrderPriority
            // 
            labelSelectedOrderPriority.AutoSize = true;
            labelSelectedOrderPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSelectedOrderPriority.Location = new Point(3, 0);
            labelSelectedOrderPriority.Name = "labelSelectedOrderPriority";
            labelSelectedOrderPriority.Size = new Size(92, 15);
            labelSelectedOrderPriority.TabIndex = 0;
            labelSelectedOrderPriority.Text = "Selected Order";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelOrderData);
            Name = "PriorityOrdersTab";
            Size = new Size(669, 423);
            panelOrderData.ResumeLayout(false);
            panelOrderData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOrderData;
        private Label labelOrdersAmountPriority;
        private Label labelAmountPriority;
        private ListBox listBoxOrderItemsPriority;
        private Label labelOrderItemsPriority;
        private Controls.AddressControl addressControlPriority;
        private ComboBox comboBoxStatusPriority;
        private TextBox textBoxCreatedPriority;
        private TextBox textBoxIdPriority;
        private Label labelStatusPriority;
        private Label labelCreatedPriority;
        private Label labelIdPriority;
        private Label labelSelectedOrderPriority;
        private Button buttonRemoveItemPriority;
        private Button buttonAddItemPriority;
        private Button buttonClearOrderPriority;
        private Label labelPriorityOptions;
        private ComboBox comboBoxDeliveryTimePriority;
        private Label labelDeliveryTimePriority;
    }
}
