public class Store
{
    private List<Item> _items = new List<Item>();
    private List<Customer> _customers = new List<Customer>();

    /// <summary>
    /// Список товаров.
    /// </summary>
    public List<Item> Items
    {
        get { return _items; }
        set { _items = value ?? new List<Item>(); }
    }
    /// <summary>
    /// Список покупателей.
    /// </summary>
    public List<Customer> Customers
    {
        get { return _customers; }
        set { _customers = value ?? new List<Customer>(); }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Store"/>.
    /// </summary>
    public Store()
    {
        Items = new List<Item>();
        Customers = new List<Customer>();
    }
}