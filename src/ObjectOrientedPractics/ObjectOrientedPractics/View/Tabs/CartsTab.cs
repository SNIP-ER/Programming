using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private BindingList<Item> _items = new BindingList<Item>();
        private BindingList<Customer> _customers = new BindingList<Customer>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new BindingList<Item>();
                listBoxItems.DataSource = _items;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new BindingList<Customer>();
                comboBoxCustomer.DataSource = _customers;
                // чтоюы сразу не выберался первый
                comboBoxCustomer.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Выбранный покупатель (null, если не выбран).
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        public CartsTab()
        {
            InitializeComponent();

            listBoxItems.DataSource = _items;
            comboBoxCustomer.DataSource = _customers;
            comboBoxCustomer.SelectedIndex = -1;
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
                labelCost.Text = "0";
                UpdateDiscountAmount();
                return;
            }

            foreach (Item item in CurrentCustomer.Cart.Items)
            {
                listBoxCarts.Items.Add(item);
            }

            labelCost.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateDiscountAmount();
        }

        /// <summary>
        /// Заполняет список скидок выбранного покупателя, все галочки включены.
        /// </summary>
        private void UpdateDiscountsList()
        {
            checkedListBoxDiscounts.Items.Clear();

            if (CurrentCustomer == null)
            {
                return;
            }

            foreach (IDiscount discount in CurrentCustomer.Discounts)
            {
                checkedListBoxDiscounts.Items.Add(discount.Info, true);
            }

            UpdateDiscountAmount();
        }

        /// <summary>
        /// Пересчитывает размер скидки и итоговую стоимость по отмеченным скидкам.
        /// </summary>
        private void UpdateDiscountAmount()
        {
            if (CurrentCustomer == null)
            {
                labelDiscountAmountCost.Text = "0";
                labelTotalCost.Text = "0";
                return;
            }

            BindingList<Item> items = new BindingList<Item>(CurrentCustomer.Cart.Items);
            double discountAmount = 0;

            foreach (int index in checkedListBoxDiscounts.CheckedIndices)
            {
                discountAmount += CurrentCustomer.Discounts[index].Calculate(items);
            }

            labelDiscountAmountCost.Text = discountAmount.ToString();
            labelTotalCost.Text = (CurrentCustomer.Cart.Amount - discountAmount).ToString();
        }

        /// <summary>
        /// Отрисовать товары из корзины.
        /// </summary>
        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = comboBoxCustomer.SelectedItem as Customer;
            UpdateDiscountsList();
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
                CurrentCustomer.Cart.Items = new BindingList<Item>();
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

        /// <summary>
        /// Создание заказа.
        /// </summary>
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Выбирите покупателя!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CurrentCustomer.Cart.Items == null || CurrentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BindingList<Item> orderItems = new BindingList<Item>(new List<Item>(CurrentCustomer.Cart.Items));
            Order order;

            BindingList<Item> items = new BindingList<Item>(CurrentCustomer.Cart.Items);
            double discountAmount = 0;
            foreach (int index in checkedListBoxDiscounts.CheckedIndices)
            {
                discountAmount += CurrentCustomer.Discounts[index].Apply(items);
            }

            foreach (IDiscount discount in CurrentCustomer.Discounts)
            {
                discount.Update(items);
            }

            // Обновление баллов на вкладке Customers
            CurrentCustomer.Discounts.ResetBindings();

            if (CurrentCustomer.IsPriority == false)
            {
                order = new Order(orderItems, CurrentCustomer.Address);
            }
            else
            {
                order = new PriorityOrder(orderItems, CurrentCustomer.Address);
            }

            order.DiscountAmount = discountAmount;

            CurrentCustomer.Orders.Add(order);
            CurrentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
            UpdateDiscountsList();
        }

        /// <summary>
        /// Регистрация галочек.
        /// </summary>
        private void checkedListBoxDiscounts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)UpdateDiscountAmount);
        }
    }
}
