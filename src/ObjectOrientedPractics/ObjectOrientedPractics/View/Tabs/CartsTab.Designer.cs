namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            tableLayoutPanelAll = new TableLayoutPanel();
            panelItems = new Panel();
            buttonCart = new Button();
            listBoxItems = new ListBox();
            labelItems = new Label();
            panelDetails = new Panel();
            tableLayoutPanelDetails = new TableLayoutPanel();
            panelCost = new Panel();
            listBoxCarts = new ListBox();
            buttonCreateOrder = new Button();
            buttonRemoveItem = new Button();
            buttonClearCart = new Button();
            labelCost = new Label();
            labelAmount = new Label();
            labelCart = new Label();
            comboBoxCustomer = new ComboBox();
            labelCustomer = new Label();
            tableLayoutPanelAll.SuspendLayout();
            panelItems.SuspendLayout();
            panelDetails.SuspendLayout();
            tableLayoutPanelDetails.SuspendLayout();
            panelCost.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelAll
            // 
            tableLayoutPanelAll.ColumnCount = 2;
            tableLayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelAll.Controls.Add(panelItems, 0, 0);
            tableLayoutPanelAll.Controls.Add(panelDetails, 1, 0);
            tableLayoutPanelAll.Dock = DockStyle.Fill;
            tableLayoutPanelAll.Location = new Point(0, 0);
            tableLayoutPanelAll.Name = "tableLayoutPanelAll";
            tableLayoutPanelAll.RowCount = 1;
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAll.Size = new Size(669, 423);
            tableLayoutPanelAll.TabIndex = 0;
            // 
            // panelItems
            // 
            panelItems.Controls.Add(buttonCart);
            panelItems.Controls.Add(listBoxItems);
            panelItems.Controls.Add(labelItems);
            panelItems.Dock = DockStyle.Fill;
            panelItems.Location = new Point(3, 3);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(261, 417);
            panelItems.TabIndex = 0;
            // 
            // buttonCart
            // 
            buttonCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCart.Location = new Point(3, 373);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(90, 41);
            buttonCart.TabIndex = 2;
            buttonCart.Text = "Add To Cart";
            buttonCart.UseVisualStyleBackColor = true;
            buttonCart.Click += buttonCart_Click;
            // 
            // listBoxItems
            // 
            listBoxItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxItems.DisplayMember = "Name";
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(3, 18);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(255, 349);
            listBoxItems.TabIndex = 1;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelItems.Location = new Point(3, 0);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(39, 15);
            labelItems.TabIndex = 0;
            labelItems.Text = "Items";
            // 
            // panelDetails
            // 
            panelDetails.Controls.Add(tableLayoutPanelDetails);
            panelDetails.Dock = DockStyle.Fill;
            panelDetails.Location = new Point(270, 3);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(396, 417);
            panelDetails.TabIndex = 1;
            // 
            // tableLayoutPanelDetails
            // 
            tableLayoutPanelDetails.ColumnCount = 1;
            tableLayoutPanelDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelDetails.Controls.Add(panelCost, 0, 0);
            tableLayoutPanelDetails.Dock = DockStyle.Fill;
            tableLayoutPanelDetails.Location = new Point(0, 0);
            tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            tableLayoutPanelDetails.RowCount = 2;
            tableLayoutPanelDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanelDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelDetails.Size = new Size(396, 417);
            tableLayoutPanelDetails.TabIndex = 0;
            // 
            // panelCost
            // 
            panelCost.Controls.Add(listBoxCarts);
            panelCost.Controls.Add(buttonCreateOrder);
            panelCost.Controls.Add(buttonRemoveItem);
            panelCost.Controls.Add(buttonClearCart);
            panelCost.Controls.Add(labelCost);
            panelCost.Controls.Add(labelAmount);
            panelCost.Controls.Add(labelCart);
            panelCost.Controls.Add(comboBoxCustomer);
            panelCost.Controls.Add(labelCustomer);
            panelCost.Dock = DockStyle.Fill;
            panelCost.Location = new Point(3, 3);
            panelCost.Name = "panelCost";
            panelCost.Size = new Size(390, 244);
            panelCost.TabIndex = 0;
            // 
            // listBoxCarts
            // 
            listBoxCarts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCarts.DisplayMember = "Name";
            listBoxCarts.FormattingEnabled = true;
            listBoxCarts.Location = new Point(3, 59);
            listBoxCarts.Name = "listBoxCarts";
            listBoxCarts.Size = new Size(384, 94);
            listBoxCarts.TabIndex = 9;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateOrder.Location = new Point(3, 203);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(88, 38);
            buttonCreateOrder.TabIndex = 8;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoveItem.Location = new Point(208, 203);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(88, 38);
            buttonRemoveItem.TabIndex = 7;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItem_Click;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClearCart.Location = new Point(302, 203);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(88, 38);
            buttonClearCart.TabIndex = 6;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            // 
            // labelCost
            // 
            labelCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCost.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelCost.Location = new Point(3, 170);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(384, 30);
            labelCost.TabIndex = 5;
            labelCost.Text = "0";
            labelCost.TextAlign = ContentAlignment.TopRight;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAmount.Location = new Point(329, 155);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(58, 15);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "Amount :";
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Location = new Point(3, 41);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(35, 15);
            labelCart.TabIndex = 2;
            labelCart.Text = "Cart :";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCustomer.DisplayMember = "FullName";
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(76, 2);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(311, 23);
            comboBoxCustomer.TabIndex = 1;
            comboBoxCustomer.SelectedIndexChanged += comboBoxCustomer_SelectedIndexChanged;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCustomer.Location = new Point(3, 5);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(67, 15);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Customer :";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelAll);
            Name = "CartsTab";
            Size = new Size(669, 423);
            tableLayoutPanelAll.ResumeLayout(false);
            panelItems.ResumeLayout(false);
            panelItems.PerformLayout();
            panelDetails.ResumeLayout(false);
            tableLayoutPanelDetails.ResumeLayout(false);
            panelCost.ResumeLayout(false);
            panelCost.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelAll;
        private Panel panelItems;
        private Panel panelDetails;
        private Label labelItems;
        private ListBox listBoxItems;
        private Button buttonCart;
        private TableLayoutPanel tableLayoutPanelDetails;
        private Panel panelCost;
        private Label labelCustomer;
        private ComboBox comboBoxCustomer;
        private Label labelCart;
        private Label labelAmount;
        private Button buttonClearCart;
        private Label labelCost;
        private Button buttonCreateOrder;
        private Button buttonRemoveItem;
        private ListBox listBoxCarts;
    }
}
