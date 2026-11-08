public class Address
{
    private int _index;
    private string _country;
    private string _city;
    private string _street;
    private string _building;
    private string _apartment;

    /// <summary>
    /// Почтовый индекс.
    /// </summary>
    public int Index
    {
        get { return _index; }
        set
        {
            if (ValueValidator.AssertIntOnLength(value, 6, 6, "Index"))
            {
                _index = value;
            }
        }
    }

    /// <summary>
    /// Страна/регион.
    /// </summary>
    public string Country
    {
        get { return _country; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 50, "Country"))
            {
                _country = value;
            }
        }
    }

    /// <summary>
    /// Город (населенный пункт).
    /// </summary>
    public string City
    {
        get { return _city; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 50, "City"))
            {
                _city = value;
            }
        }
    }

    /// <summary>
    /// Улица.
    /// </summary>
    public string Street
    {
        get { return _street; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 100, "Street"))
            {
                _street = value;
            }
        }
    }

    /// <summary>
    /// Номер дома.
    /// </summary>
    public string Building
    {
        get { return _building; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 10, "Building"))
            {
                _building = value;
            }
        }
    }

    /// <summary>
    /// Номер квартиры/помещения.
    /// </summary>
    public string Apartment
    {
        get { return _apartment; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 10, "Apartment"))
            {
                _apartment = value;
            }
        }
    }

    /// <summary>
    /// Показ адреса одной строкой.
    /// </summary>
    /// <returns>Строка с полным адресом.</returns>
    public override string ToString()
    {
        return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Address"/>.
    /// </summary>
    /// <param name="index">Почтовый индекс.</param>
    /// <param name="country">Страна/регион.</param>
    /// <param name="city">Город (населенный пункт).</param>
    /// <param name="street">Улица.</param>
    /// <param name="building">Номер дома.</param>
    /// <param name="apartment">номер квартиры/помещения.</param>
    public Address(int index, string country, string city, string street, string building, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }

    public Address()
    {

    }
}