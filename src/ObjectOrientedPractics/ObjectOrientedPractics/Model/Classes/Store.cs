using System.ComponentModel;

public class Store
{
    private BindingList<Item> _items = new BindingList<Item>();
    private BindingList<Customer> _customers = new BindingList<Customer>();

    /// <summary>
    /// Список товаров.
    /// </summary>
    public BindingList<Item> Items
    {
        get { return _items; }
        set { _items = value ?? new BindingList<Item>(); }
    }
    /// <summary>
    /// Список покупателей.
    /// </summary>
    public BindingList<Customer> Customers
    {
        get { return _customers; }
        set { _customers = value ?? new BindingList<Customer>(); }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Store"/>.
    /// </summary>
    public Store()
    {
        Items = new BindingList<Item>();
        Customers = new BindingList<Customer>();
    }
}