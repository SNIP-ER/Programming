using System.Xml.Linq;

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
    /// Создаёт экземпляр класса <see cref="Address"/>.
    /// </summary>
    /// <param name="_index">Почтовый индекс.</param>
    /// <param name="_country">Страна/регион.</param>
    /// <param name="_city">Город (населенный пункт).</param>
    /// <param name="_street">Улица.</param>
    /// <param name="_building">Номер дома.</param>
    /// <param name="_apartment">номер квартиры/помещения.</param>
    public Address(int _index, string _country, string _city, string _street, string _building, string _apartment)
    {
        Index = _index;
        Country = _country;
        City = _city;
        Street = _street;
        Building = _building;
        Apartment = _apartment;
    }

    public Address()
    {

    }
}