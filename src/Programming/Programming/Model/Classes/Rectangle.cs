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


    // Конструктор
    public Rectangle(float length, float width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
    }

    public Rectangle()
    {

    }
}
