using System;

static class Validator
{
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
    /// Проверка на длину строки.
    /// </summary>
    /// <param name="value">Значение пользователя.</param>
    /// <param name="min">Наименьшее значение в диапазоне.</param>
    /// <param name="max">Наибольшее значение в диапазоне.</param>
    /// <param name="property">Название свойства.</param>
    /// <returns>Пользователькое значение.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static string AssertValueInRange(string value, int min, int max, string property)
    {
        int length = value.Length;

        if ((length >= min) && (length <= max))
        {
            return value;
        }
        else
        {
            throw new ArgumentException(String.Format($"Значение в свойстве {property} не попадает в диапазон!"));
        }
    }
}
