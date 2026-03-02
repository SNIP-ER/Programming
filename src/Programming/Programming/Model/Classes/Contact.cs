// Контакт в телефонной книжке
using System;
using System.Runtime.InteropServices;

class Contact
{
    private string firstName, lastName, number;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
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
}