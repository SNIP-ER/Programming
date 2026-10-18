using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _currentItem;
        private List<Customer> _customers = new List<Customer>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new List<Item>();
                UpdateItemsListBox();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateCustomersListBox();
            }
        }

        /// <summary>
        /// Выбранный покупатель (null, если не выбран).
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполнение списка товаров.
        /// </summary>
        public void UpdateItemsListBox()
        {
            listBoxItems.Items.Clear();

            if (_items == null)
            {
                return;
            }

            foreach (Item item in _items)
            {
                listBoxItems.Items.Add(item);
            }
        }

        /// <summary>
        /// Заполнение корзины покупателя.
        /// </summary>
        public void UpdateCartListBox()
        {
            listBoxCarts.Items.Clear();

            if (CurrentCustomer == null
                || CurrentCustomer.Cart == null
                || CurrentCustomer.Cart.Items == null)
            {
                return;
            }

            foreach (Item item in CurrentCustomer.Cart.Items)
            {
                listBoxCarts.Items.Add(item);
            }

            labelCost.Text = CurrentCustomer?.Cart?.Amount.ToString() ?? "0";
        }

        /// <summary>
        /// Заполнение ComboBox покупателями.
        /// </summary>
        public void UpdateCustomersListBox()
        {
            Customer previousCustomer = CurrentCustomer;
            comboBoxCustomer.Items.Clear();

            if (_customers != null)
            {
                foreach (Customer customer in _customers)
                {
                    comboBoxCustomer.Items.Add(customer);
                }
            }

            if (previousCustomer != null && _customers != null && _customers.Contains(previousCustomer))
            {
                comboBoxCustomer.SelectedItem = previousCustomer;
            }
            else
            {
                comboBoxCustomer.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Отрисовать товары из корзины.
        /// </summary>
        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = comboBoxCustomer.SelectedItem as Customer;
            UpdateCartListBox();
        }

        /// <summary>
        /// Добавить товар в корзину.
        /// </summary>
        private void buttonCart_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Item selectedItem = listBoxItems.SelectedItem as Item;
            if (selectedItem == null)
            {
                MessageBox.Show("Выбирите товар для добавления!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CurrentCustomer.Cart.Items == null)
            {
                CurrentCustomer.Cart.Items = new List<Item>();
            }

            CurrentCustomer.Cart.Items.Add(selectedItem);
            UpdateCartListBox();
        }

        /// <summary>
        /// Удалить товар из корзины.
        /// </summary>
        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = listBoxCarts.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Выбирите товар в корзине!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrentCustomer.Cart.Items.RemoveAt(index);
            UpdateCartListBox();
        }
    }
}
