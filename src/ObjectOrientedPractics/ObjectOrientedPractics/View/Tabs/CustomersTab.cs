using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление нового пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCustomersAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("FullName", "Address");

            _customers.Add(customer);

            listBoxCustomers.Items.Add($"{customer.FullName}");
        }

        /// <summary>
        /// Удаление выбранного пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCustomersRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxCustomers.SelectedIndex;

            if (index != -1)
            {
                _customers.RemoveAt(index);
                listBoxCustomers.Items.RemoveAt(index);
            }
        }

        /// <summary>
        /// Добавить случайного пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectedCustomerRandom_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.Randomize();

            _customers.Add(customer);

            listBoxCustomers.Items.Add($"{customer.FullName}");
        }

        /// <summary>
        /// Заполнение полей выбранного пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                _currentCustomer = _customers[listBoxCustomers.SelectedIndex];
                UpdateItemInfo(_currentCustomer);
            }
            else
            {
                ClearItemInfo();
            }
        }

        /// <summary>
        /// Обновить текст о пользователе.
        /// </summary>
        /// <param name="customer">Выбранный пользователь.</param>
        private void UpdateItemInfo(Customer customer)
        {
            textBoxSelectedCustomerId.Text = customer.Id.ToString();
            textBoxSelectedCustomerFullName.Text = customer.FullName;
            textBoxSelectedCustomerAddress.Text = customer.Address;
        }

        /// <summary>
        /// Очистить поля с информацией о пользователе.
        /// </summary>
        private void ClearItemInfo()
        {
            textBoxSelectedCustomerId.Text = "";
            textBoxSelectedCustomerFullName.Text = "";
            textBoxSelectedCustomerAddress.Text = "";
        }

        /// <summary>
        /// Сохранение изменений в строке с именем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSelectedCustomerFullName_Leave(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите пользователя!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertStringOnLength(textBoxSelectedCustomerFullName.Text, 200, "bool"))
            {
                _currentCustomer.FullName = textBoxSelectedCustomerFullName.Text;
                ReplaceLineInListBox();
                textBoxSelectedCustomerFullName.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textBoxSelectedCustomerFullName.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Поле не должно быть пустым и больше 200 символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение изменений в строке с адерсом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSelectedCustomerAddress_Leave(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите пользователя!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertStringOnLength(textBoxSelectedCustomerAddress.Text, 500, "bool"))
            {
                _currentCustomer.Address = textBoxSelectedCustomerAddress.Text;
                ReplaceLineInListBox();
                textBoxSelectedCustomerAddress.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textBoxSelectedCustomerAddress.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Поле не должно быть пустым и больше 500 символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновить название пользователя в списке.
        /// </summary>
        private void ReplaceLineInListBox()
        {
            listBoxCustomers.Items[listBoxCustomers.SelectedIndex] = $"{_currentCustomer.FullName}";
        }
    }
}
