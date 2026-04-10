using System;

class Ring
{
    public Point2D Center { get; set; }
    public double Area { get; private set; }

    private float outerRadius, innerRadius;

    public float OuterRadius
    {
        get { return outerRadius; }
        set
        {
            if (outerRadius >= innerRadius)
            {
                outerRadius = Validator.AssertOnPositiveValue(value, "OuterRadius");
            }
            else
            {
                throw new ArgumentException(String.Format("Внешний радиус не может быть меньше внутреннего!"));
            }
        }
    }

    public float InnerRadius
    {
        get { return innerRadius; }
        set
        {
            if (innerRadius <= outerRadius)
            {
                innerRadius = Validator.AssertOnPositiveValue(value, "InnerRadius");
            }
            else
            {
                throw new ArgumentException(String.Format("Внутренний радиус не может быть больше внешнего!"));
            }
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Ring"/>.
    /// </summary>
    /// <param name="center">Координаты центра кольца.</param>
    /// <param name="outerRadius">Внутренний радиус кольца.</param>
    /// <param name="innerRadius">Внешний радиус кольца.</param>
    public Ring(Point2D center, float outerRadius, float innerRadius)
    {
        Center = center;
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
        Area = Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
    }
    public Ring()
    {

    }
}