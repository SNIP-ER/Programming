using System;
using System.Net.NetworkInformation;

static class CollisionManager
{
    /// <summary>
    /// Проверка пересечения прямоугольников.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник.</param>
    /// <param name="rectangle2">Второй прямоугольник.</param>
    /// <returns>True - пересекаются, false - не пересекаются.</returns>
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        if ((Math.Abs(rectangle1.Center.StoreX - rectangle2.Center.StoreX) < 
            Math.Abs(rectangle1.Width - rectangle2.Width) / 2) && 
            (Math.Abs(rectangle1.Center.StoreY - rectangle2.Center.StoreY) < 
            Math.Abs(rectangle1.Height - rectangle2.Height) / 2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Проверка пересечения колец.
    /// </summary>
    /// <param name="ring1">Первое кольцо.</param>
    /// <param name="ring2">Второе кольцо.</param>
    /// <returns>True - пересекаются, false - не пересекаются.</returns>
    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        if (Hypotenuse(ring1, ring2) < ring1.OuterRadius + ring2.OuterRadius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Нахождение гипотенузы между центров двух колец.
    /// </summary>
    /// <param name="ring1">Первое кольцо.</param>
    /// <param name="ring2">Второе кольцо.</param>
    /// <returns>Гипотенузу.</returns>
    private static double Hypotenuse(Ring ring1, Ring ring2)
    {
        // растояние между центрами по X
        double distanceX = Math.Abs(ring1.Center.StoreX - ring2.Center.StoreX);
        // растояние между центрами по Y
        double distanceY = Math.Abs(ring1.Center.StoreX - ring2.Center.StoreX);

        return Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
    }
}