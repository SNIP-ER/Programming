using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private bool _isUpdating;
        private BindingList<Customer> _customers = new BindingList<Customer>();
        private BindingList<Order> _orders = new BindingList<Order>();

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
                return;
            }

            order.Status = (OrderStatus)comboBoxStatus.SelectedItem;
            _orders.ResetItem(dataGridViewOrders.CurrentRow.Index);
        }
    }
}
