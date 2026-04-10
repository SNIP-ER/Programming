using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

class RectangleClasses
{
    private float length, width;
    private static int _allRectanglesCount;     // подсчет всех существующих объектов прямоуг.
    private int _id;

    public float Length
    {
        get { return length; }
        set
        {
            length = Validator.AssertOnPositiveValue(value, "Length");
        }
    }
    public float Width
    {
        get { return width; }
        set
        {
            width = Validator.AssertOnPositiveValue(value, "Width");
        }
    }
    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }
    public int Id
    {
        get { return _id; }
    }

    public string Color { get; set; }
    public Point2D Center { get; set; }


    /// <summary>
    /// Создаёт экземпляр класса <see cref="RectangleClasses"/>.
    /// </summary>
    /// <param name="length">Длина прямоугольника.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="color">Цвет прямоугольника.</param>
    /// <param name="center">Координаты центра прямоугольника.</param>
    public RectangleClasses(float length, float width, string color, Point2D center)
    {
        Length = length;
        Width = width;
        Color = color;
        Center = center;

        _allRectanglesCount++;
        _id = _allRectanglesCount;
    }

    public RectangleClasses()
    {
        _id = _allRectanglesCount;
        _allRectanglesCount++;
    }
}
