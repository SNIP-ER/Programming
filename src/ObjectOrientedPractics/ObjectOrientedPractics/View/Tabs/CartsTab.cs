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
                return;
            }

            foreach (Item item in CurrentCustomer.Cart.Items)
            {
                listBoxCarts.Items.Add(item);
            }

            labelCost.Text = CurrentCustomer?.Cart?.Amount.ToString() ?? "0";
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

            Order order = new Order(orderItems, CurrentCustomer.Address);
            CurrentCustomer.Orders.Add(order);

            CurrentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }
    }
}
