using System.ComponentModel;

public class Order
{
    private protected static int _count;

    /// <summary>
    /// ID заказа.
    /// </summary>
    public int Id { get; protected set; }

    /// <summary>
    /// Дата создания заказа.
    /// </summary>
    public DateTime Date { get; protected set; }

    /// <summary>
    /// Адрес доставки.
    /// </summary>
    public Address Address { get; set; }

    /// <summary>
    /// Список товаров заказа.
    /// </summary>
    public BindingList<Item> Items { get; set; }

    /// <summary>
    /// Общая стоимость заказа.
    /// </summary>
    public double Amount
    {
        get
        {
            if (Items == null || Items.Count == 0)
            {
                return 0.0;
            }

            double sum = 0.0;
            foreach (Item item in Items)
            {
                sum += item.Cost;
            }

            return sum;
        }
    }

    /// <summary>
    /// Статус заказа.
    /// </summary>
    public OrderStatus Status { get; set; }

    /// <summary>
    /// ФИО покупателя (для отображения в таблице заказов).
    /// </summary>
    public string CustomerName { get; set; }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Order"/>.
    /// </summary>
    /// <param name="items">Список товаров покупателя.</param>
    /// <param name="address">Адрес доставки.</param>
    public Order(BindingList<Item> items, Address address)
    {
        _count++;
        Id = _count;
        Date = DateTime.Now;
        Items = items;
        Address = address;
        Status = OrderStatus.New;
    }
}