class Rectangle
{
    public Point2D Center { get; set; }

    private float width, height;
    private static int _allRectanglesCount;
    private int _id;

    public float Width
    {
        get { return width; }
        set
        {
            width = Validator.AssertOnPositiveValue(value, "Width");
        }
    }

    public float Height
    {
        get { return height; }
        set
        {
            height = Validator.AssertOnPositiveValue(value, "Height");
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

    // Консруктор
    public Rectangle(float width, float height, Point2D center)
    {
        Width = width;
        Height = height;
        Center = center;

        _allRectanglesCount++;
        _id = _allRectanglesCount;
    }
    public Rectangle()
    {
        _allRectanglesCount++;
        _id = _allRectanglesCount;
    }
}