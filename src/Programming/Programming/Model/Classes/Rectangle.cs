using System.Windows.Forms.VisualStyles;

class Rectangle
{
    private double length, width;
    private string color;

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

            }
        }
    }
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
}
