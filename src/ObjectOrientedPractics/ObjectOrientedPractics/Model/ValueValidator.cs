public static class ValueValidator
{
    /// <summary>
    /// Проверка длины строки.
    /// </summary>
    /// <param name="value">Строка.</param>
    /// <param name="maxLength">Максимальная допустимая длина.</param>
    /// <param name="propertyName">Название свойства.</param>
    /// <returns>tru/false.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Допустим диапозон от 1 до maxLength.</exception>
    public static bool AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength || value.Length < 1)
        {
            throw new ArgumentOutOfRangeException($"{propertyName} должен быть не пустой и больше {maxLength} символов!");
        }

        return true;
    }
}