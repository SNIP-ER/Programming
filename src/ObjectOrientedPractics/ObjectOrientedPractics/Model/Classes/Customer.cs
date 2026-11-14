using System.ComponentModel;

public class Customer
{
    private static int _count;
    private readonly int _id;
    private string _fullname;

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    public string FullName
    {
        get { return _fullname; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 200, "FullName"))
            {
                _fullname = value;
            }
        }
    }

    /// <summary>
    /// Адрес доставки для покупателя.
    /// </summary>
    public Address Address { get; set; }

    /// <summary>
    /// ID покупателя.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Корзина покупателя.
    /// </summary>
    public Cart Cart { get; }

    /// <summary>
    /// Список заказов покупателя.
    /// </summary>
    public BindingList<Order> Orders { get; set; }

    /// <summary>
    /// Является ли пользователь приоритетным покупателем.
    /// true - является, false - нет.
    /// </summary>
    public bool IsPriority { get; set; }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullname">Фамилия.</param>
    /// <param name="address">Адресс доставки.</param>
    public Customer(string fullname, Address address)
    {
        _count++;
        _id = _count;
        FullName = fullname;
        Address = address;
        Cart = new Cart(new BindingList<Item>());
        Orders = new BindingList<Order>();
        IsPriority = false;
    }

    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>
    public Customer()
    {
        _count++;
        _id = _count;
        Cart = new Cart(new BindingList<Item>());
        Orders = new BindingList<Order>();
        IsPriority = false;
    }
}