using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private bool _isUpdating;
        private List<Customer> _customers = new List<Customer>();
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Список покупателей, заказы которых отображаются на вкладке.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateOrders();
            }
        }

        public OrdersTab()
        {
            InitializeComponent();

            comboBoxStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        /// <summary>
        /// Обновляет общий список заказов по списку покупателей
        /// и перезаполняет таблицу.
        /// </summary>
        public void UpdateOrders()
        {
            _orders = new List<Order>();
            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    _orders.Add(order);
                }
            }

            dataGridViewOrders.Rows.Clear();
            foreach (Order order in _orders)
            {
                dataGridViewOrders.Rows.Add(
                    order.Id,
                    order.Date,
                    order.Status,
                    GetCustomerName(order),
                    AddressToString(order.Address),
                    order.Amount);
            }
        }

        /// <summary>
        /// Находит ФИО покупателя, которому принадлежит заказ.
        /// </summary>
        private string GetCustomerName(Order order)
        {
            foreach (Customer customer in _customers)
            {
                if (customer.Orders.Contains(order))
                {
                    return customer.FullName;
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Преобразует адрес в одну строку.
        /// </summary>
        private string AddressToString(Address a)
        {
            if (a == null)
            {
                return string.Empty;
            }
            return $"{a.Index}, {a.Country}, {a.City}, {a.Street}, {a.Building}, {a.Apartment}";
        }

        /// <summary>
        /// Выбор заказа в таблице.
        /// </summary>
        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null)
            {
                return;
            }

            int index = dataGridViewOrders.CurrentRow.Index;

            if (index < 0 || index >= _orders.Count)
            {
                return;
            }

            Order order = _orders[index];
            _isUpdating = true;
            textBoxId.Text = order.Id.ToString();
            textBoxCreated.Text = order.Date.ToString();
            comboBoxStatus.SelectedItem = order.Status;
            addressControl.Address = order.Address;
            listBoxOrderItems.Items.Clear();
            foreach (Item item in order.Items)
            {
                listBoxOrderItems.Items.Add(item);
            }
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

            if (dataGridViewOrders.CurrentRow == null)
            {
                return;
            }

            int index = dataGridViewOrders.CurrentRow.Index;
            Order order = _orders[index];

            OrderStatus status = (OrderStatus)comboBoxStatus.SelectedItem;

            order.Status = status;
            dataGridViewOrders.CurrentRow.Cells[5].Value = status;
        }
    }
}
