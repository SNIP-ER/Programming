using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();

        public AddressControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value ?? new Address();

                textBoxAddressControlIndex.Text = _address.Index.ToString();
                textBoxAddressControlCountry.Text = _address.Country;
                textBoxAddressControlCity.Text = _address.City;
                textBoxAddressControlStreet.Text = _address.Street;
                textBoxAddressControlBuilding.Text = _address.Building;
                textBoxAddressControlApartment.Text = _address.Apartment;
            }
        }

        /// <summary>
        /// Сохранение почтового индекса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAddressControlIndex_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxAddressControlIndex.Text, out int index))
            {
                textBoxAddressControlIndex.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Индекс должен состоять только из цифр !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertIntOnLength(index, 6, 6, "bool"))
            {
                _address.Index = index;
                textBoxAddressControlIndex.BackColor = Color.White;
            }
            else
            {
                textBoxAddressControlIndex.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Поле должно быть 6 символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение страны/региона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAddressControlCountry_Leave(object sender, EventArgs e)
        {
            int maxLength = 50;

            if (ValueValidator.AssertStringOnLength(textBoxAddressControlCountry.Text, maxLength, "bool"))
            {
                _address.Country = textBoxAddressControlCountry.Text;
                textBoxAddressControlCountry.BackColor = Color.White;
            }
            else
            {
                textBoxAddressControlCountry.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show($"Поле не должно быть пустым и больше {maxLength} символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение города (населенного пункта).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAddressControlCity_Leave(object sender, EventArgs e)
        {
            int maxLength = 50;

            if (ValueValidator.AssertStringOnLength(textBoxAddressControlCity.Text, maxLength, "bool"))
            {
                _address.City = textBoxAddressControlCity.Text;
                textBoxAddressControlCity.BackColor = Color.White;
            }
            else
            {
                textBoxAddressControlCity.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show($"Поле не должно быть пустым и больше {maxLength} символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение улицы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAddressControlStreet_Leave(object sender, EventArgs e)
        {
            int maxLength = 100;

            if (ValueValidator.AssertStringOnLength(textBoxAddressControlStreet.Text, maxLength, "bool"))
            {
                _address.Street = textBoxAddressControlStreet.Text;
                textBoxAddressControlStreet.BackColor = Color.White;
            }
            else
            {
                textBoxAddressControlStreet.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show($"Поле не должно быть пустым и больше {maxLength} символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение номера дома.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAddressControlBuilding_Leave(object sender, EventArgs e)
        {
            int maxLength = 10;

            if (ValueValidator.AssertStringOnLength(textBoxAddressControlBuilding.Text, maxLength, "bool"))
            {
                _address.Building = textBoxAddressControlBuilding.Text;
                textBoxAddressControlBuilding.BackColor = Color.White;
            }
            else
            {
                textBoxAddressControlBuilding.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show($"Поле не должно быть пустым и больше {maxLength} символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение номера квартиры/помещения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAddressControlApartment_Leave(object sender, EventArgs e)
        {
            int maxLength = 10;

            if (ValueValidator.AssertStringOnLength(textBoxAddressControlApartment.Text, maxLength, "bool"))
            {
                _address.Apartment = textBoxAddressControlApartment.Text;
                textBoxAddressControlApartment.BackColor = Color.White;
            }
            else
            {
                textBoxAddressControlApartment.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show($"Поле не должно быть пустым и больше {maxLength} символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
