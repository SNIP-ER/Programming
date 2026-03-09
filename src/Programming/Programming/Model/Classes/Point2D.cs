class Point2D
{
    public float StoreX { get; private set; }
    public float StoreY { get; private set; }

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