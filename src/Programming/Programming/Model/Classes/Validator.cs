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
}
