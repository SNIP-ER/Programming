// Контакт в телефонной книжке
using System;
using System.Runtime.InteropServices;

class Contact
{
    private string number;

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
    public string Name { get; set; }
    public string SurName { get; set; }


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