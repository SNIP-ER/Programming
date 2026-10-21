using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class Item
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
            if (ValueValidator.AssertFloatOnSize(value, 100000, "Cost"))
            {
                _cost = value;
            }
        }
    }

    /// <summary>
    /// ID товара.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Категория товара.
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>.
    /// </summary>
    /// <param name="name">Название товара.</param>
    /// <param name="info">Информация о товаре.</param>
    /// <param name="cost">Цена товара.</param>
    /// <param name="category">Категория товара.</param>
    public Item(string name, string info, float cost, Category category)
    {
        _count++;
        _id = _count;
        Name = name;
        Info = info;
        Cost = cost;
        Category = category;
    }

    public Item()
    {
        _count++;
        _id = _count;
        Category = Category.none;
    }
}