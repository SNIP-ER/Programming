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
            if (value >= 0)
            {
                length = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Длина не может быть отрицательной!"));
            }
        }
    }
    public float Width
    {
        get { return width; }
        set
        {
            if (value >= 0)
            {
                width = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Длина не может быть отрицательной!"));
            }
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
