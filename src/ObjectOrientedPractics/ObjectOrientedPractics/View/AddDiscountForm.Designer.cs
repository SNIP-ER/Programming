namespace ObjectOrientedPractics.View
{
    partial class AddDiscountForm
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
            labelPercentDiscount = new Label();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            buttonCancel = new Button();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelPercentDiscount
            // 
            labelPercentDiscount.AutoSize = true;
            labelPercentDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPercentDiscount.Location = new Point(12, 9);
            labelPercentDiscount.Name = "labelPercentDiscount";
            labelPercentDiscount.Size = new Size(106, 15);
            labelPercentDiscount.TabIndex = 0;
            labelPercentDiscount.Text = "Percent Discount:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(12, 36);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(58, 15);
            labelCategory.TabIndex = 1;
            labelCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(76, 33);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(200, 23);
            comboBoxCategory.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(185, 72);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(91, 38);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(88, 72);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(91, 38);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // AddDiscountForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(289, 121);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(labelPercentDiscount);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddDiscountForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPercentDiscount;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Button buttonCancel;
        private Button buttonOk;
    }
}