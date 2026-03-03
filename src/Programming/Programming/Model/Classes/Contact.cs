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
    public string FirstName { get; set; }
    public string LastName { get; set; }
}