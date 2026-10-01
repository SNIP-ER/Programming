using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Customer
{
    private static int _count;
    private readonly int _id;
    private string _fullname;
    private Address _address;

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
    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    /// <summary>
    /// ID покупателя.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="_fullname">Фамилия.</param>
    /// <param name="_address">Адресс доставки.</param>
    public Customer(string _fullname, Address _address)
    {
        _count++;
        _id = _count;
        FullName = _fullname;
        Address = _address;
    }

    public Customer()
    {
        _count++;
        _id = _count;
    }
}