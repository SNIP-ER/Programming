using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private bool _isUpdating;
        private BindingList<Customer> _customers = new BindingList<Customer>();
        private BindingList<Order> _orders = new BindingList<Order>();
        private PriorityOrder _selectedPriorityOrder;

        /// <summary>
        /// Список покупателей, заказы которых отображаются на вкладке.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new BindingList<Customer>();
                UpdateOrders();
            }
        }

        public OrdersTab()
        {
            InitializeComponent();

            dataGridViewOrders.AutoGenerateColumns = false;
            dataGridViewOrders.DataSource = _orders;
            comboBoxStatus.DataSource = Enum.GetValues(typeof(OrderStatus));

            comboBoxPriorityOptions.FormattingEnabled = true;
            comboBoxPriorityOptions.Format += (s, e) =>
            {
                if (e.ListItem is Enum value)
                {
                    e.Value = value.GetDescription();
                }
            };

            comboBoxPriorityOptions.DataSource =
                Enum.GetValues(typeof(TimesDelivery));
        }

        /// <summary>
        /// Обновляет общий список заказов по списку покупателей
        /// и перезаполняет таблицу.
        /// </summary>
        public void UpdateOrders()
        {
            _orders.RaiseListChangedEvents = false;
            _orders.Clear();

            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    order.CustomerName = customer.FullName;
                    _orders.Add(order);
                }
            }

            _orders.RaiseListChangedEvents = true;
            _orders.ResetBindings();
        }

        /// <summary>
        /// Выбор заказа в таблице.
        /// </summary>
        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            Order order = dataGridViewOrders.CurrentRow?.DataBoundItem as Order;
            if (order == null)
            {
                return;
            }

            _isUpdating = true;

            if (order is PriorityOrder priority)
            {
                _selectedPriorityOrder = priority;
                panelPriorityOptions.Visible = true;
                comboBoxPriorityOptions.SelectedItem = priority.TimeDelivery;
            }
            else
            {
                _selectedPriorityOrder = null;
                panelPriorityOptions.Visible = false;
            }

            textBoxId.Text = order.Id.ToString();
            textBoxCreated.Text = order.Date.ToString();
            comboBoxStatus.SelectedItem = order.Status;
            addressControl.Address = order.Address;
            listBoxOrderItems.DataSource = order.Items;
            labelOrdersAmount.Text = order.Amount.ToString();
            _isUpdating = false;
        }

        /// <summary>
        /// Сохранение статуса заказа.
        /// </summary>
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            Order order = dataGridViewOrders.CurrentRow?.DataBoundItem as Order;
            if (order == null)
            {
                _selectedPriorityOrder = null;
                panelPriorityOptions.Visible = false;
                return;
            }

            order.Status = (OrderStatus)comboBoxStatus.SelectedItem;
            _orders.ResetItem(dataGridViewOrders.CurrentRow.Index);
        }

        /// <summary>
        /// Сохранение желаемого времени доставки.
        /// </summary>
        private void comboBoxPriorityOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdating || _selectedPriorityOrder == null)
            {
                return;
            }

            _selectedPriorityOrder.TimeDelivery = (TimesDelivery)comboBoxPriorityOptions.SelectedItem;
        }
    }
}
