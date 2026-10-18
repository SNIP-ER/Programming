public class Order
{
    private static int _count;
    private readonly int _id;
    private readonly DateTime _date;

    /// <summary>
    /// ID заказа.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Дата создания заказа.
    /// </summary>
    public DateTime Date
    {
        get { return _date; }
    }

    /// <summary>
    /// Адрес доставки.
    /// </summary>
    public Address Address { get; set; }

    /// <summary>
    /// Список товаров заказа.
    /// </summary>
    public List<Item> Items { get; set; }

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
    /// Создаёт экземпляр класса <see cref="Order"/>.
    /// </summary>
    /// <param name="items">Список товаров покупателя.</param>
    /// <param name="address">Адрес доставки.</param>
    public Order(List<Item> items, Address address)
    {
        _count++;
        _id = _count;
        _date = DateTime.Now;
        Items = items;
        Address = address;
        Status = OrderStatus.New;
    }
}