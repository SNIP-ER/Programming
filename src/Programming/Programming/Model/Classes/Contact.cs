// Контакт в телефонной книжке
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class Contact
{
    private string number;
    private string name;
    private string surName;

    public string Number
    {
        get { return number; }
        set
        {
            if (value.Substring(0) == "+")
            {
                number = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Телефон должен начинаться с + !"));
            }
        }
    }
    public string Name
    {
        get { return name; }
        set
        {
            name = AssertStringContainsOnlyLetters(value, "Имя");
        }
    }
    public string SurName
    {
        get { return surName; }
        set
        {
            surName = AssertStringContainsOnlyLetters(value, "Фамилия");
        }
    }

    /// <summary>
    /// Проверка, что пользователь ввел в имя/фамилия только символы англ алфавита.
    /// </summary>
    /// <param name="value">Строка, которую ввел пользователь.</param>
    /// <returns>Строка, если она подходит.</returns>
    /// <exception cref="ArgumentException"></exception>
    private string AssertStringContainsOnlyLetters(string value, string type)
    {
        if (Regex.IsMatch(value, @"^[a-z]+$", RegexOptions.IgnoreCase))
        {
            return value;
        }
        else
        {
            throw new ArgumentException(String.Format($"{type} может состоять только из букв англ алфавита!"));
        }
    }

    // Конструктор
    public Contact(string number, string name, string surName)
    {
        Number = number;
        Name = name;
        SurName = surName;
    }

    public Contact()
    {

    }
}