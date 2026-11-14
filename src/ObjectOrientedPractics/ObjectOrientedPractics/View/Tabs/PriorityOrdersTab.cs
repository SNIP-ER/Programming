namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _order = new PriorityOrder();
        private bool _isUpdating;

        public PriorityOrdersTab()
        {
            InitializeComponent();

            comboBoxStatusPriority.DataSource =
                Enum.GetValues(typeof(OrderStatus));

            // для отображения Description вместо элементов
            comboBoxDeliveryTimePriority.FormattingEnabled = true;
            comboBoxDeliveryTimePriority.Format += (s, e) =>
            {
                if (e.ListItem is Enum value)
                {
                    e.Value = value.GetDescription();
                }
            };

            comboBoxDeliveryTimePriority.DataSource =
                Enum.GetValues(typeof(TimesDelivery));

            UpdateData();
        }

        /// <summary>
        /// Добвление случайного товара.
        /// </summary>
        private void buttonAddItemPriority_Click(object sender, EventArgs e)
        {
            _order.Items.Add(ItemFactory.Randomize());
            labelOrdersAmountPriority.Text = _order.Amount.ToString();
        }

        /// <summary>
        /// Удаление товара
        /// </summary>
        private void buttonRemoveItemPriority_Click(object sender, EventArgs e)
        {
            int index = listBoxOrderItemsPriority.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            _order.Items.RemoveAt(index);

            if (_order.Items.Count > 0)
            {
                listBoxOrderItemsPriority.SelectedIndex =
                    Math.Min(index, _order.Items.Count - 1);
            }

            labelOrdersAmountPriority.Text = _order.Amount.ToString();
        }

        /// <summary>
        /// Очистка заказа (создается новый объект).
        /// </summary>
        private void buttonClearOrderPriority_Click(object sender, EventArgs e)
        {
            _order = new PriorityOrder();
            UpdateData();
        }

        /// <summary>
        /// Сохранение изменения статуса заказа.
        /// </summary>
        private void comboBoxStatusPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            _order.Status = (OrderStatus)comboBoxStatusPriority.SelectedItem;
        }

        /// <summary>
        /// Сохранение изменения желаемого времени заказа.
        /// </summary>
        private void comboBoxDeliveryTimePriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            _order.TimeDelivery = (TimesDelivery)comboBoxDeliveryTimePriority.SelectedItem;
        }

        /// <summary>
        /// Обновление данных заказа.
        /// </summary>
        private void UpdateData()
        {
            _isUpdating = true;

            textBoxIdPriority.Text = _order.Id.ToString();
            textBoxCreatedPriority.Text = _order.Date.ToString();
            comboBoxStatusPriority.SelectedItem = _order.Status;
            comboBoxDeliveryTimePriority.SelectedItem = _order.TimeDelivery;
            addressControlPriority.Address = _order.Address;
            listBoxOrderItemsPriority.DataSource = _order.Items;
            labelOrdersAmountPriority.Text = _order.Amount.ToString();

            _isUpdating = false;
        }
    }
}
