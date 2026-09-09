using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Customer
{
    private static int _count;
    private readonly int _id;
    private string _fullname;
    private string _address;

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    public string Fullname
    {
        get { return _fullname; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 200, "Fullname"))
            {
                _fullname = value;
            }
        }
    }

    /// <summary>
    /// Адрес доставки для покупателя.
    /// </summary>
    public string Address
    {
        get { return _address; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 500, "Address"))
            {
                _address = value;
            }
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="number">Номер телефона. Начинается с +.</param>
    /// <param name="name">Имя.</param>
    /// <param name="surName">Фамилия.</param>
    public Customer(string _fullname, string _address)
    {
        _count++;
        _id = _count;
        Fullname = _fullname;
        Address = _address;
    }

    public Customer()
    {

    }
}