using System;

static class RectangleFactory
{
    /// <summary>
    /// Генерирует случайный прямоугольник.
    /// </summary>
    /// <returns>Прямоугольник.</returns>
    public static Rectangle Randomize()
    {
        Random random = new Random();

        Rectangle rectangle = new Rectangle(random.Next(10, 100), random.Next(10, 100),
            new Point2D(random.Next(0, 530), random.Next(0, 390)));

        return rectangle;
    }
}