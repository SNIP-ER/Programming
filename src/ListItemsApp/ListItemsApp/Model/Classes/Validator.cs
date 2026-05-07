using System;

static class Validator
{
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
