class Items
{
    private string name, manufacturer;
    private int count, index;


    public string Name
    {
        get { return name; }
        set
        {
            name = Validator.AssertValueInRange(value, 0, 100, "Name");
        }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set
        {
            manufacturer = Validator.AssertValueInRange(value, 0, 100, "Manufacturer");
        }
    }

    public int Count { get; set; }
    public int Index { get; set; }


    /// <summary>
    /// Создаёт экземпляр класса <see cref="Items"/>.
    /// </summary>
    /// <param name="name">Название товара.</param>
    /// <param name="manufacturer">Производитель товара.</param>
    /// <param name="count">Количество товара на складе. Целое число, больше 0.</param>
    public Items(string name, string manufacturer, int count, int index)
    {
        Name = name;
        Manufacturer = manufacturer;
        Count = count;
        Index = index;
    }

    public Items()
    {

    }
}