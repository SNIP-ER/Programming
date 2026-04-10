class Point2D
{
    public int StoreX { get; set; }
    public int StoreY { get; set; }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Point2D"/>.
    /// </summary>
    /// <param name="storeX">Координата центра по X.</param>
    /// <param name="storeY">Координата центра по Y.</param>
    public Point2D(int storeX, int storeY)
    {
        StoreX = storeX;
        StoreY = storeY;
    }

    public Point2D()
    {

    }
}