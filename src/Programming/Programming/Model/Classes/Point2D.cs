class Point2D
{
    public readonly float StoreX { get; private set; }
    public readonly float StoreY { get; private set; }

    // Конструктор
    public Point2D(float storeX, float storeY)
    {
        StoreX = storeX;
        StoreY = storeY;    
    }

    public Point2D()
    {

    }
}