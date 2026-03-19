class Rectangle
{
    public Point2D Center { get; set; }

    private int width, height, _id;
    private static int _allRectanglesCount;

    public int Width
    {
        get { return width; }
        set
        {
            width = Validator.AssertOnPositiveValue(value, "Width");
        }
    }

    public int Height
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
    public Rectangle(int width, int height, Point2D center)
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