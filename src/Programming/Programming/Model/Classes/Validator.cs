using System;

static class Validator
{
    /// <summary>
    /// Проверка, что вещественное значение не является отрицательным.
    /// </summary>
    /// <param name="value">То, что ввел пользователь.</param>
    /// <param name="property">Название свойства.</param>
    /// <returns>То, что ввел пользователь.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static float AssertOnPositiveValue(float value, string property)
    {
        if (value >= 0)
        {
            return value;
        }
        else
        {
            throw new ArgumentException(String.Format($"Свойство {property} не может быть отрицательным!"));
        }
    }

    /// <summary>
    /// Проверка, что целое значение не является отрицательным.
    /// </summary>
    /// <param name="value">То, что ввел пользователь.</param>
    /// <param name="property">Название свойства.</param>
    /// <returns>То, что ввел пользователь.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static int AssertOnPositiveValue(int value, string property)
    {
        if (value >= 0)
        {
            return value;
        }
        else
        {
            throw new ArgumentException(String.Format($"Свойство {property} не может быть отрицательным!"));
        }
    }

    /// <summary>
    /// Проверка на попадания в диапазон целых значений.
    /// </summary>
    /// <param name="value">Значение пользователя.</param>
    /// <param name="min">Наименьшее значение в диапазоне.</param>
    /// <param name="max">Наибольшее значение в диапазоне.</param>
    /// <param name="property">Название свойства.</param>
    /// <returns>Пользователькое значение.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static int AssertValueInRange(int value, int min, int max, string property)
    {
        if ((value >= min) && (value <= max))
        {
            return value;
        }
        else
        {
            throw new ArgumentException(String.Format($"Значение в свойстве {property} не попадает в диапазон!"));
        }
    }

    /// <summary>
    /// Проверка на попадания в диапазон вещественных значений.
    /// </summary>
    /// <param name="value">Значение пользователя.</param>
    /// <param name="min">Наименьшее значение в диапазоне.</param>
    /// <param name="max">Наибольшее значение в диапазоне.</param>
    /// <param name="property">Название свойства.</param>
    /// <returns>Пользователькое значение.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static double AssertValueInRange(double value, int min, int max, string property)
    {
        if ((value >= min) && (value <= max))
        {
            return value;
        }
        else
        {
            throw new ArgumentException(String.Format($"Значение в свойстве {property} не попадает в диапазон!"));
        }
    }

    /// <summary>
    /// Проверка на попадание прямоугольника в диапазон панели.
    /// </summary>
    /// <param name="value">Координата центра прямоугольника.</param>
    /// <param name="max">Наибольшее возможное значение.</param>
    /// <returns>True или False.</returns>
    public static bool AssertValueInRangePanel(int value, int max)
    {
        if ((value >= 0) && (value <= max))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
