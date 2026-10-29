using System;
using System.ComponentModel;
using System.Reflection;

public static class EnumExtensions
{
    /// <summary>
    /// Вернуть по элементы Enum его Description.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Значение из Description.</returns>
    public static string GetDescription(this Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());

        DescriptionAttribute attribute = field?
            .GetCustomAttribute<DescriptionAttribute>(false);

        return attribute == null ? value.ToString() : attribute.Description;
    }
}
