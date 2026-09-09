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
            panelItems = new Panel();
            panelItemsEmpty = new Panel();
            panelItemsButtons = new Panel();
            buttonItemsRemove = new Button();
            buttonItemsAdd = new Button();
            listBoxItems = new ListBox();
            labelItems = new Label();
            panelSelectedItem = new Panel();
            textBoxSelectedItemDescription = new TextBox();
            textBoxSelectedItemName = new TextBox();
            labelSelectedItemDescription = new Label();
            labelSelectedItemName = new Label();
            textBoxSelectedItemCost = new TextBox();
            textBoxSelectedItemId = new TextBox();
            labelSelectedItemCost = new Label();
            labelSelectedItemId = new Label();
            labelSelectedItem = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelItems.SuspendLayout();
            panelItemsButtons.SuspendLayout();
            panelSelectedItem.SuspendLayout();
            SuspendLayout();
            // 
            // panelItems
            // 
            panelItems.Controls.Add(panelItemsEmpty);
            panelItems.Controls.Add(panelItemsButtons);
            panelItems.Controls.Add(listBoxItems);
            panelItems.Controls.Add(labelItems);
            panelItems.Dock = DockStyle.Left;
            panelItems.Location = new Point(0, 0);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(494, 902);
            panelItems.TabIndex = 0;
            // 
            // panelItemsEmpty
            // 
            panelItemsEmpty.Location = new Point(352, 796);
            panelItemsEmpty.Name = "panelItemsEmpty";
            panelItemsEmpty.Size = new Size(142, 100);
            panelItemsEmpty.TabIndex = 3;
            // 
            // panelItemsButtons
            // 
            panelItemsButtons.Controls.Add(buttonItemsRemove);
            panelItemsButtons.Controls.Add(buttonItemsAdd);
            panelItemsButtons.Location = new Point(3, 796);
            panelItemsButtons.Name = "panelItemsButtons";
            panelItemsButtons.Size = new Size(343, 97);
            panelItemsButtons.TabIndex = 2;
            // 
            // buttonItemsRemove
            // 
            buttonItemsRemove.Location = new Point(171, 12);
            buttonItemsRemove.Name = "buttonItemsRemove";
            buttonItemsRemove.Size = new Size(154, 70);
            buttonItemsRemove.TabIndex = 3;
            buttonItemsRemove.Text = "Remove";
            buttonItemsRemove.UseVisualStyleBackColor = true;
            // 
            // buttonItemsAdd
            // 
            buttonItemsAdd.Location = new Point(11, 12);
            buttonItemsAdd.Name = "buttonItemsAdd";
            buttonItemsAdd.Size = new Size(154, 70);
            buttonItemsAdd.TabIndex = 2;
            buttonItemsAdd.Text = "Add";
            buttonItemsAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(14, 50);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(468, 740);
            listBoxItems.TabIndex = 1;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelItems.Location = new Point(14, 15);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(77, 32);
            labelItems.TabIndex = 0;
            labelItems.Text = "Items";
            // 
            // panelSelectedItem
            // 
            panelSelectedItem.BackColor = SystemColors.Window;
            panelSelectedItem.Controls.Add(tableLayoutPanel1);
            panelSelectedItem.Controls.Add(textBoxSelectedItemDescription);
            panelSelectedItem.Controls.Add(textBoxSelectedItemName);
            panelSelectedItem.Controls.Add(labelSelectedItemDescription);
            panelSelectedItem.Controls.Add(labelSelectedItemName);
            panelSelectedItem.Controls.Add(textBoxSelectedItemCost);
            panelSelectedItem.Controls.Add(textBoxSelectedItemId);
            panelSelectedItem.Controls.Add(labelSelectedItemCost);
            panelSelectedItem.Controls.Add(labelSelectedItemId);
            panelSelectedItem.Controls.Add(labelSelectedItem);
            panelSelectedItem.Dock = DockStyle.Right;
            panelSelectedItem.Location = new Point(506, 0);
            panelSelectedItem.Name = "panelSelectedItem";
            panelSelectedItem.Size = new Size(736, 902);
            panelSelectedItem.TabIndex = 1;
            // 
            // textBoxSelectedItemDescription
            // 
            textBoxSelectedItemDescription.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedItemDescription.Location = new Point(18, 545);
            textBoxSelectedItemDescription.Multiline = true;
            textBoxSelectedItemDescription.Name = "textBoxSelectedItemDescription";
            textBoxSelectedItemDescription.Size = new Size(704, 285);
            textBoxSelectedItemDescription.TabIndex = 8;
            // 
            // textBoxSelectedItemName
            // 
            textBoxSelectedItemName.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedItemName.Location = new Point(18, 277);
            textBoxSelectedItemName.Multiline = true;
            textBoxSelectedItemName.Name = "textBoxSelectedItemName";
            textBoxSelectedItemName.Size = new Size(704, 191);
            textBoxSelectedItemName.TabIndex = 7;
            // 
            // labelSelectedItemDescription
            // 
            labelSelectedItemDescription.AutoSize = true;
            labelSelectedItemDescription.Location = new Point(18, 500);
            labelSelectedItemDescription.Name = "labelSelectedItemDescription";
            labelSelectedItemDescription.Size = new Size(140, 32);
            labelSelectedItemDescription.TabIndex = 6;
            labelSelectedItemDescription.Text = "Description:";
            // 
            // labelSelectedItemName
            // 
            labelSelectedItemName.AutoSize = true;
            labelSelectedItemName.Location = new Point(18, 232);
            labelSelectedItemName.Name = "labelSelectedItemName";
            labelSelectedItemName.Size = new Size(83, 32);
            labelSelectedItemName.TabIndex = 5;
            labelSelectedItemName.Text = "Name:";
            // 
            // textBoxSelectedItemCost
            // 
            textBoxSelectedItemCost.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedItemCost.Location = new Point(138, 134);
            textBoxSelectedItemCost.Name = "textBoxSelectedItemCost";
            textBoxSelectedItemCost.Size = new Size(244, 39);
            textBoxSelectedItemCost.TabIndex = 4;
            // 
            // textBoxSelectedItemId
            // 
            textBoxSelectedItemId.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedItemId.Location = new Point(138, 80);
            textBoxSelectedItemId.Name = "textBoxSelectedItemId";
            textBoxSelectedItemId.Size = new Size(244, 39);
            textBoxSelectedItemId.TabIndex = 3;
            // 
            // labelSelectedItemCost
            // 
            labelSelectedItemCost.AutoSize = true;
            labelSelectedItemCost.Location = new Point(18, 136);
            labelSelectedItemCost.Name = "labelSelectedItemCost";
            labelSelectedItemCost.Size = new Size(66, 32);
            labelSelectedItemCost.TabIndex = 2;
            labelSelectedItemCost.Text = "Cost:";
            // 
            // labelSelectedItemId
            // 
            labelSelectedItemId.AutoSize = true;
            labelSelectedItemId.Location = new Point(18, 83);
            labelSelectedItemId.Name = "labelSelectedItemId";
            labelSelectedItemId.Size = new Size(42, 32);
            labelSelectedItemId.TabIndex = 1;
            labelSelectedItemId.Text = "ID:";
            // 
            // labelSelectedItem
            // 
            labelSelectedItem.AutoSize = true;
            labelSelectedItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSelectedItem.Location = new Point(18, 15);
            labelSelectedItem.Name = "labelSelectedItem";
            labelSelectedItem.Size = new Size(168, 32);
            labelSelectedItem.TabIndex = 0;
            labelSelectedItem.Text = "Selected Item";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(322, 232);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(400, 200);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSelectedItem);
            Controls.Add(panelItems);
            Name = "ItemsTab";
            Size = new Size(1242, 902);
            panelItems.ResumeLayout(false);
            panelItems.PerformLayout();
            panelItemsButtons.ResumeLayout(false);
            panelSelectedItem.ResumeLayout(false);
            panelSelectedItem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelItems;
        private Panel panelSelectedItem;
        private Label labelItems;
        private ListBox listBoxItems;
        private Panel panelItemsButtons;
        private Button buttonItemsAdd;
        private Button buttonItemsRemove;
        private Panel panelItemsEmpty;
        private Label labelSelectedItem;
        private Label labelSelectedItemCost;
        private Label labelSelectedItemId;
        private TextBox textBoxSelectedItemCost;
        private TextBox textBoxSelectedItemId;
        private Label labelSelectedItemName;
        private Label labelSelectedItemDescription;
        private TextBox textBoxSelectedItemName;
        private TextBox textBoxSelectedItemDescription;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
