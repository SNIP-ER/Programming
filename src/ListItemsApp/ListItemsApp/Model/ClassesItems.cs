class Items
{
    private string name, manufacturer;
    private int count;

    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int Count { get; set; }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Items"/>.
    /// </summary>
    /// <param name="name">Название товара.</param>
    /// <param name="manufacturer">Производитель товара.</param>
    /// <param name="count">Количество товара на складе. Целое число, больше 0.</param>
    public Items(string name, string manufacturer, int count)
    {
        Name = name;
        Manufacturer = manufacturer;
        Count = count;
    }

    public Items()
    {

    }
}