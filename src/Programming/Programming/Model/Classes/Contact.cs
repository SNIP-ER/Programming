// Контакт в телефонной книжке
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
            if ((number.Length == 11) && (value.Substring(0, 1) == "+7"))
            {
                number = value;
            }
            else
            {

            }
        }
    }
}