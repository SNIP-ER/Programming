using System;

static class RectangleFactory
{
    /// <summary>
    /// Генерирует случайный прямоугольник
    /// </summary>
    /// <param name="canvasWidth">Ширина поля.</param>
    /// <param name="canvasHeight">Высота поля.</param>
    /// <returns>Прямоугольник.</returns>
    public static Rectangle Randomize(int canvasWidth, int canvasHeight)
    {
        Random random = new Random();

        int rectangleWidth = random.Next(10, 100);
        int rectangleHeight = random.Next(10, 100);
        int centerX = random.Next(15 + (rectangleWidth / 2), canvasWidth - 15 - (rectangleWidth / 2));
        int centerY = random.Next(15 + (rectangleHeight / 2), canvasHeight - 15 - (rectangleHeight / 2));

        Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight, new Point2D(centerX, centerY));

        return rectangle;
    }
}