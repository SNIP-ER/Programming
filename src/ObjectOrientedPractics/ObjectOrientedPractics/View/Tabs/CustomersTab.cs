using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateItemsListBox();
            }
        }

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
            Customer customer = new Customer("FullName", new Address(111111, "None", "None", "None", "None", "None"));

            _customers.Add(customer);

            listBoxCustomers.Items.Add(customer);
        }

        /// <summary>
        /// Удаление выбранного пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCustomersRemove_Click(object sender, EventArgs e)
        {
            Customer customer = listBoxCustomers.SelectedItem as Customer;

            if (customer != null)
            {
                _customers.Remove(customer);
                listBoxCustomers.Items.Remove(customer);
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

            listBoxCustomers.Items.Add(customer);
        }

        /// <summary>
        /// Заполнение полей выбранного пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = listBoxCustomers.SelectedItem as Customer;

            if (_currentCustomer != null)
            {
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
            addressControl.Address = customer.Address;
        }

        /// <summary>
        /// Очистить поля с информацией о пользователе.
        /// </summary>
        private void ClearItemInfo()
        {
            textBoxSelectedCustomerId.Text = "";
            textBoxSelectedCustomerFullName.Text = "";
            addressControl.Address = null;
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
                textBoxSelectedCustomerFullName.BackColor = Color.White;
            }
            else
            {
                textBoxSelectedCustomerFullName.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Поле не должно быть пустым и больше 200 символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновить название пользователя в списке.
        /// </summary>
        private void ReplaceLineInListBox()
        {
            listBoxCustomers.Items[listBoxCustomers.SelectedIndex] = _currentCustomer;
        }

        /// <summary>
        /// Сихранизация того, что хранится, с тем что показывается.
        /// </summary>
        private void UpdateItemsListBox()
        {
            listBoxCustomers.Items.Clear();
            foreach (Customer customer in _customers)
            {
                listBoxCustomers.Items.Add(customer);
            }
        }
    }
}
