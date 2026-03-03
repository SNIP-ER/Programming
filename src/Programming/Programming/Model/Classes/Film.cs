using System;
using System.Xml.Linq;

class Film
{
    private int year;   // year - от 1900 до текущего года
    private double rating;      // от 0 до 10

    public int Year
    {
        get { return year; }
        set
        {
            if (value >= 1900)
            {
                year = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Год должен быть не меньше 1900!"));
            }
        }
    }
    public double Rating
    {
        get { return rating; }
        set
        {
            if ((value >= 0) && (value <= 10))
            {
                rating = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Рейтинг не должен быть меньше 0 и больше 10!"));
            }
        }
    }

    public string Name { get; set; }
    public string Genre { get; set; }
    public int Length { get; set; }     // length - в мин


    // Конструктор
    public Film(int year, double rating, string name, string genre, int length)
    {
        Year = year;
        Rating = rating;
        Name = name;
        Genre = genre;
        Length = length;
    }

    public Film()
    {

    }
}