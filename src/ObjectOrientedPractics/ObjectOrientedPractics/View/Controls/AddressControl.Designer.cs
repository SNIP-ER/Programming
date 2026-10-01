namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            labelAddressControl = new Label();
            labelAddressControlIndex = new Label();
            labelAddressControlCountry = new Label();
            labelAddressControlCity = new Label();
            labelAddressControlStreet = new Label();
            labelAddressControlBuilding = new Label();
            labelAddressControlApartment = new Label();
            textBoxAddressControlIndex = new TextBox();
            textBoxAddressControlCountry = new TextBox();
            textBoxAddressControlCity = new TextBox();
            textBoxAddressControlStreet = new TextBox();
            textBoxAddressControlBuilding = new TextBox();
            textBoxAddressControlApartment = new TextBox();
            SuspendLayout();
            // 
            // labelAddressControl
            // 
            labelAddressControl.AutoSize = true;
            labelAddressControl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAddressControl.Location = new Point(3, 0);
            labelAddressControl.Name = "labelAddressControl";
            labelAddressControl.Size = new Size(101, 15);
            labelAddressControl.TabIndex = 0;
            labelAddressControl.Text = "Delivery Address";
            // 
            // labelAddressControlIndex
            // 
            labelAddressControlIndex.AutoSize = true;
            labelAddressControlIndex.Location = new Point(0, 32);
            labelAddressControlIndex.Name = "labelAddressControlIndex";
            labelAddressControlIndex.Size = new Size(65, 15);
            labelAddressControlIndex.TabIndex = 1;
            labelAddressControlIndex.Text = "Post Index:";
            // 
            // labelAddressControlCountry
            // 
            labelAddressControlCountry.AutoSize = true;
            labelAddressControlCountry.Location = new Point(0, 67);
            labelAddressControlCountry.Name = "labelAddressControlCountry";
            labelAddressControlCountry.Size = new Size(53, 15);
            labelAddressControlCountry.TabIndex = 2;
            labelAddressControlCountry.Text = "Country:";
            // 
            // labelAddressControlCity
            // 
            labelAddressControlCity.AutoSize = true;
            labelAddressControlCity.Location = new Point(185, 67);
            labelAddressControlCity.Name = "labelAddressControlCity";
            labelAddressControlCity.Size = new Size(31, 15);
            labelAddressControlCity.TabIndex = 3;
            labelAddressControlCity.Text = "City:";
            // 
            // labelAddressControlStreet
            // 
            labelAddressControlStreet.AutoSize = true;
            labelAddressControlStreet.Location = new Point(0, 107);
            labelAddressControlStreet.Name = "labelAddressControlStreet";
            labelAddressControlStreet.Size = new Size(40, 15);
            labelAddressControlStreet.TabIndex = 4;
            labelAddressControlStreet.Text = "Street:";
            // 
            // labelAddressControlBuilding
            // 
            labelAddressControlBuilding.AutoSize = true;
            labelAddressControlBuilding.Location = new Point(-1, 143);
            labelAddressControlBuilding.Name = "labelAddressControlBuilding";
            labelAddressControlBuilding.Size = new Size(54, 15);
            labelAddressControlBuilding.TabIndex = 5;
            labelAddressControlBuilding.Text = "Building:";
            // 
            // labelAddressControlApartment
            // 
            labelAddressControlApartment.AutoSize = true;
            labelAddressControlApartment.Location = new Point(180, 143);
            labelAddressControlApartment.Name = "labelAddressControlApartment";
            labelAddressControlApartment.Size = new Size(67, 15);
            labelAddressControlApartment.TabIndex = 6;
            labelAddressControlApartment.Text = "Apartment:";
            // 
            // textBoxAddressControlIndex
            // 
            textBoxAddressControlIndex.Location = new Point(71, 29);
            textBoxAddressControlIndex.Name = "textBoxAddressControlIndex";
            textBoxAddressControlIndex.Size = new Size(66, 23);
            textBoxAddressControlIndex.TabIndex = 7;
            textBoxAddressControlIndex.Leave += textBoxAddressControlIndex_Leave;
            // 
            // textBoxAddressControlCountry
            // 
            textBoxAddressControlCountry.Location = new Point(59, 64);
            textBoxAddressControlCountry.Name = "textBoxAddressControlCountry";
            textBoxAddressControlCountry.Size = new Size(120, 23);
            textBoxAddressControlCountry.TabIndex = 8;
            textBoxAddressControlCountry.Leave += textBoxAddressControlCountry_Leave;
            // 
            // textBoxAddressControlCity
            // 
            textBoxAddressControlCity.Location = new Point(222, 64);
            textBoxAddressControlCity.Name = "textBoxAddressControlCity";
            textBoxAddressControlCity.Size = new Size(165, 23);
            textBoxAddressControlCity.TabIndex = 9;
            textBoxAddressControlCity.Leave += textBoxAddressControlCity_Leave;
            // 
            // textBoxAddressControlStreet
            // 
            textBoxAddressControlStreet.Location = new Point(59, 104);
            textBoxAddressControlStreet.Name = "textBoxAddressControlStreet";
            textBoxAddressControlStreet.Size = new Size(328, 23);
            textBoxAddressControlStreet.TabIndex = 10;
            textBoxAddressControlStreet.Leave += textBoxAddressControlStreet_Leave;
            // 
            // textBoxAddressControlBuilding
            // 
            textBoxAddressControlBuilding.Location = new Point(59, 140);
            textBoxAddressControlBuilding.Name = "textBoxAddressControlBuilding";
            textBoxAddressControlBuilding.Size = new Size(100, 23);
            textBoxAddressControlBuilding.TabIndex = 11;
            textBoxAddressControlBuilding.Leave += textBoxAddressControlBuilding_Leave;
            // 
            // textBoxAddressControlApartment
            // 
            textBoxAddressControlApartment.Location = new Point(253, 140);
            textBoxAddressControlApartment.Name = "textBoxAddressControlApartment";
            textBoxAddressControlApartment.Size = new Size(100, 23);
            textBoxAddressControlApartment.TabIndex = 12;
            textBoxAddressControlApartment.Leave += textBoxAddressControlApartment_Leave;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxAddressControlApartment);
            Controls.Add(textBoxAddressControlBuilding);
            Controls.Add(textBoxAddressControlStreet);
            Controls.Add(textBoxAddressControlCity);
            Controls.Add(textBoxAddressControlCountry);
            Controls.Add(textBoxAddressControlIndex);
            Controls.Add(labelAddressControlApartment);
            Controls.Add(labelAddressControlBuilding);
            Controls.Add(labelAddressControlStreet);
            Controls.Add(labelAddressControlCity);
            Controls.Add(labelAddressControlCountry);
            Controls.Add(labelAddressControlIndex);
            Controls.Add(labelAddressControl);
            Name = "AddressControl";
            Size = new Size(390, 171);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddressControl;
        private Label labelAddressControlIndex;
        private Label labelAddressControlCountry;
        private Label labelAddressControlCity;
        private Label labelAddressControlStreet;
        private Label labelAddressControlBuilding;
        private Label labelAddressControlApartment;
        private TextBox textBoxAddressControlIndex;
        private TextBox textBoxAddressControlCountry;
        private TextBox textBoxAddressControlCity;
        private TextBox textBoxAddressControlStreet;
        private TextBox textBoxAddressControlBuilding;
        private TextBox textBoxAddressControlApartment;
    }
}
