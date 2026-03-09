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
            if (Regex.IsMatch(value, @"^[a-z]+$", RegexOptions.IgnoreCase))
            {
                name = value;
            }
        }
    }
    public string SurName
    {
        get { return surName; }
        set
        {
            if (Regex.IsMatch(value, @"^[a-z]+$", RegexOptions.IgnoreCase))
            {
                surName = value;
            }
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