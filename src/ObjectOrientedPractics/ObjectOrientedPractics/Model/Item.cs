using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

class Item
{
    private static int _count;
    private readonly int _id;
    private string _name;
    private string _info;
    private float _cost;

    /// <summary>
    /// Название товара.
    /// </summary>
    public string Name
    {
        get { return _name; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 200, "Name"))
            {
                _name = value;
            }
        }
    }

    /// <summary>
    /// Описание товара.
    /// </summary>
    public string Info
    {
        get { return _info; }
        set
        {
            if (ValueValidator.AssertStringOnLength(value, 1000, "Info"))
            {
                _info = value;
            }
        }
    }

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    public float Cost
    {
        get { return _cost; }
        set
        {
            if (value > 100000 || value < 0)
            {
                throw new ArgumentOutOfRangeException("Можно вводить от 0 до 100000 символов!");
            }
            _cost = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>.
    /// </summary>
    /// <param name="number">Номер телефона. Начинается с +.</param>
    /// <param name="name">Имя.</param>
    /// <param name="surName">Фамилия.</param>
    public Item(string _name, string _info, float _cost)
    {
        _count++;
        _id = _count;
        Name = _name;
        Info = _info;
        Cost = _cost;
    }

    public Item()
    {

    }
}