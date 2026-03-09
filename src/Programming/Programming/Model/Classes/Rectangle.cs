using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

class Rectangle
{
    private float length, width;

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

    public string Color { get; set; }
    public Point2D Center { get; set; }


    // Конструктор
    public Rectangle(float length, float width, string color, Point2D center)
    {
        Length = length;
        Width = width;
        Color = color;
        Center = center;
    }

    public Rectangle()
    {

    }
}
