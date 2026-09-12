namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanelIAll = new TableLayoutPanel();
            panelItems = new Panel();
            tableLayoutPanelButtons = new TableLayoutPanel();
            buttonItemsRemove = new Button();
            buttonItemsAdd = new Button();
            listBoxItems = new ListBox();
            labelItems = new Label();
            panelSelectedItem = new Panel();
            textBoxSelectedItemDescription = new TextBox();
            labelSelectedItemDescription = new Label();
            textBoxSelectedItemName = new TextBox();
            labelSelectedItemName = new Label();
            textBoxSelectedItemCost = new TextBox();
            textBoxSelectedItemId = new TextBox();
            labelSelectedItemCost = new Label();
            labelSelectedItemId = new Label();
            labelSelectedItem = new Label();
            tableLayoutPanelIAll.SuspendLayout();
            panelItems.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            panelSelectedItem.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelIAll
            // 
            tableLayoutPanelIAll.ColumnCount = 2;
            tableLayoutPanelIAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelIAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelIAll.Controls.Add(panelItems, 0, 0);
            tableLayoutPanelIAll.Controls.Add(panelSelectedItem, 1, 0);
            tableLayoutPanelIAll.Dock = DockStyle.Fill;
            tableLayoutPanelIAll.Location = new Point(0, 0);
            tableLayoutPanelIAll.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanelIAll.Name = "tableLayoutPanelIAll";
            tableLayoutPanelIAll.RowCount = 1;
            tableLayoutPanelIAll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelIAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelIAll.Size = new Size(669, 423);
            tableLayoutPanelIAll.TabIndex = 10;
            // 
            // panelItems
            // 
            panelItems.Controls.Add(tableLayoutPanelButtons);
            panelItems.Controls.Add(listBoxItems);
            panelItems.Controls.Add(labelItems);
            panelItems.Dock = DockStyle.Fill;
            panelItems.Location = new Point(3, 3);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(261, 417);
            panelItems.TabIndex = 0;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanelButtons.ColumnCount = 3;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelButtons.Controls.Add(buttonItemsRemove, 1, 0);
            tableLayoutPanelButtons.Controls.Add(buttonItemsAdd, 0, 0);
            tableLayoutPanelButtons.Location = new Point(4, 369);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(252, 40);
            tableLayoutPanelButtons.TabIndex = 4;
            // 
            // buttonItemsRemove
            // 
            buttonItemsRemove.Location = new Point(86, 1);
            buttonItemsRemove.Margin = new Padding(2, 1, 2, 1);
            buttonItemsRemove.Name = "buttonItemsRemove";
            buttonItemsRemove.Size = new Size(80, 38);
            buttonItemsRemove.TabIndex = 5;
            buttonItemsRemove.Text = "Remove";
            buttonItemsRemove.UseVisualStyleBackColor = true;
            // 
            // buttonItemsAdd
            // 
            buttonItemsAdd.Location = new Point(2, 1);
            buttonItemsAdd.Margin = new Padding(2, 1, 2, 1);
            buttonItemsAdd.Name = "buttonItemsAdd";
            buttonItemsAdd.Size = new Size(80, 38);
            buttonItemsAdd.TabIndex = 5;
            buttonItemsAdd.Text = "Add";
            buttonItemsAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxItems
            // 
            listBoxItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(2, 16);
            listBoxItems.Margin = new Padding(2, 1, 2, 1);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(254, 349);
            listBoxItems.TabIndex = 3;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelItems.Location = new Point(2, 0);
            labelItems.Margin = new Padding(2, 0, 2, 0);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(39, 15);
            labelItems.TabIndex = 2;
            labelItems.Text = "Items";
            // 
            // panelSelectedItem
            // 
            panelSelectedItem.BackColor = Color.White;
            panelSelectedItem.Controls.Add(textBoxSelectedItemDescription);
            panelSelectedItem.Controls.Add(labelSelectedItemDescription);
            panelSelectedItem.Controls.Add(textBoxSelectedItemName);
            panelSelectedItem.Controls.Add(labelSelectedItemName);
            panelSelectedItem.Controls.Add(textBoxSelectedItemCost);
            panelSelectedItem.Controls.Add(textBoxSelectedItemId);
            panelSelectedItem.Controls.Add(labelSelectedItemCost);
            panelSelectedItem.Controls.Add(labelSelectedItemId);
            panelSelectedItem.Controls.Add(labelSelectedItem);
            panelSelectedItem.Dock = DockStyle.Fill;
            panelSelectedItem.Location = new Point(270, 3);
            panelSelectedItem.Name = "panelSelectedItem";
            panelSelectedItem.Size = new Size(396, 417);
            panelSelectedItem.TabIndex = 1;
            // 
            // textBoxSelectedItemDescription
            // 
            textBoxSelectedItemDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSelectedItemDescription.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedItemDescription.Location = new Point(11, 271);
            textBoxSelectedItemDescription.Margin = new Padding(2, 1, 2, 1);
            textBoxSelectedItemDescription.Multiline = true;
            textBoxSelectedItemDescription.Name = "textBoxSelectedItemDescription";
            textBoxSelectedItemDescription.Size = new Size(380, 135);
            textBoxSelectedItemDescription.TabIndex = 11;
            // 
            // labelSelectedItemDescription
            // 
            labelSelectedItemDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedItemDescription.AutoSize = true;
            labelSelectedItemDescription.Location = new Point(11, 250);
            labelSelectedItemDescription.Margin = new Padding(2, 0, 2, 0);
            labelSelectedItemDescription.Name = "labelSelectedItemDescription";
            labelSelectedItemDescription.Size = new Size(70, 15);
            labelSelectedItemDescription.TabIndex = 10;
            labelSelectedItemDescription.Text = "Description:";
            // 
            // textBoxSelectedItemName
            // 
            textBoxSelectedItemName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSelectedItemName.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedItemName.Location = new Point(11, 142);
            textBoxSelectedItemName.Margin = new Padding(2, 1, 2, 1);
            textBoxSelectedItemName.Multiline = true;
            textBoxSelectedItemName.Name = "textBoxSelectedItemName";
            textBoxSelectedItemName.Size = new Size(380, 91);
            textBoxSelectedItemName.TabIndex = 9;
            // 
            // labelSelectedItemName
            // 
            labelSelectedItemName.AutoSize = true;
            labelSelectedItemName.Location = new Point(11, 121);
            labelSelectedItemName.Margin = new Padding(2, 0, 2, 0);
            labelSelectedItemName.Name = "labelSelectedItemName";
            labelSelectedItemName.Size = new Size(42, 15);
            labelSelectedItemName.TabIndex = 8;
            labelSelectedItemName.Text = "Name:";
            // 
            // textBoxSelectedItemCost
            // 
            textBoxSelectedItemCost.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedItemCost.Location = new Point(66, 59);
            textBoxSelectedItemCost.Margin = new Padding(2, 1, 2, 1);
            textBoxSelectedItemCost.Name = "textBoxSelectedItemCost";
            textBoxSelectedItemCost.Size = new Size(132, 23);
            textBoxSelectedItemCost.TabIndex = 7;
            // 
            // textBoxSelectedItemId
            // 
            textBoxSelectedItemId.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedItemId.Location = new Point(66, 34);
            textBoxSelectedItemId.Margin = new Padding(2, 1, 2, 1);
            textBoxSelectedItemId.Name = "textBoxSelectedItemId";
            textBoxSelectedItemId.Size = new Size(132, 23);
            textBoxSelectedItemId.TabIndex = 6;
            // 
            // labelSelectedItemCost
            // 
            labelSelectedItemCost.AutoSize = true;
            labelSelectedItemCost.Location = new Point(11, 61);
            labelSelectedItemCost.Margin = new Padding(2, 0, 2, 0);
            labelSelectedItemCost.Name = "labelSelectedItemCost";
            labelSelectedItemCost.Size = new Size(34, 15);
            labelSelectedItemCost.TabIndex = 5;
            labelSelectedItemCost.Text = "Cost:";
            // 
            // labelSelectedItemId
            // 
            labelSelectedItemId.AutoSize = true;
            labelSelectedItemId.Location = new Point(11, 36);
            labelSelectedItemId.Margin = new Padding(2, 0, 2, 0);
            labelSelectedItemId.Name = "labelSelectedItemId";
            labelSelectedItemId.Size = new Size(21, 15);
            labelSelectedItemId.TabIndex = 4;
            labelSelectedItemId.Text = "ID:";
            // 
            // labelSelectedItem
            // 
            labelSelectedItem.AutoSize = true;
            labelSelectedItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSelectedItem.Location = new Point(11, 5);
            labelSelectedItem.Margin = new Padding(2, 0, 2, 0);
            labelSelectedItem.Name = "labelSelectedItem";
            labelSelectedItem.Size = new Size(86, 15);
            labelSelectedItem.TabIndex = 3;
            labelSelectedItem.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelIAll);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ItemsTab";
            Size = new Size(669, 423);
            tableLayoutPanelIAll.ResumeLayout(false);
            panelItems.ResumeLayout(false);
            panelItems.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            panelSelectedItem.ResumeLayout(false);
            panelSelectedItem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelIAll;
        private Panel panelItems;
        private Panel panelSelectedItem;
        private Label labelItems;
        private ListBox listBoxItems;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button buttonItemsAdd;
        private Button buttonItemsRemove;
        private Label labelSelectedItemCost;
        private Label labelSelectedItemId;
        private Label labelSelectedItem;
        private TextBox textBoxSelectedItemCost;
        private TextBox textBoxSelectedItemId;
        private TextBox textBoxSelectedItemName;
        private Label labelSelectedItemName;
        private TextBox textBoxSelectedItemDescription;
        private Label labelSelectedItemDescription;
    }
}
