class Order
{
    private static int _count;
    private readonly int _id;
    private string _data;


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
    public string Data
    {
        get { return _data; }
    }

    public Order()
    {
        _count++;
        _id = _count;
    }
}