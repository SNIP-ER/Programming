public static class ValueValidator
{
    /// <summary>
    /// Проверка длины строки.
    /// </summary>
    /// <param name="value">Строка.</param>
    /// <param name="maxLength">Максимальная допустимая длина.</param>
    /// <param name="propertyName">Название свойства. Если для проверки - ввести bool.</param>
    /// <returns>true/false.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Допустим диапозон от 1 до maxLength.</exception>
    public static bool AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength || value.Length < 1)
        {
            if (propertyName == "bool")
            {
                return false;
            }

            throw new ArgumentOutOfRangeException($"{propertyName} должен быть не пустой и больше {maxLength} символов!");
        }

        return true;
    }

    /// <summary>
    /// Проверка размера числа.
    /// </summary>
    /// <param name="value">Число</param>
    /// <param name="propertyName">Название свойства. Если для проверки - ввести bool.</param>
    /// <returns>true/false.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Допустимый диапозон не меньше 0.</exception>
    public static bool AssertFloatOnSize(float value, int maxSize, string propertyName)
    {
        if (value > maxSize || value < 0)
        {
            if (propertyName == "bool")
            {
                return false;
            }

            throw new ArgumentOutOfRangeException($"{propertyName} не должен быть отрицательным и больше {maxSize} !");
        }

        return true;
    }

    /// <summary>
    /// Проверка на отрицательное число.
    /// </summary>
    /// <param name="value">Число</param>
    /// <param name="propertyName">Название свойства.</param>
    /// <returns>true/false.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Допустимый диапозон не меньше 0.</exception>
    public static bool AssertNegativeValue(float value, string propertyName)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException($"{propertyName} не должен быть отрицательным!");
        }

        return true;
    }
}