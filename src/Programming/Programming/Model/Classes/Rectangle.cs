using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

class Rectangle
{
    private double length, width;

    public double Length
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
    public double Width
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
}
