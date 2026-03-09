using System;
using System.Xml.Linq;

class Film
{
    private int year, duration;   // year - от 1900 до текущего года;  duration - в мин
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
    public int Duration
    {
        get { return duration; }
        set
        {
            duration = Validator.AssertOnPositiveValue(value, "Duration");
        }
    }

    public string Name { get; set; }
    public string Genre { get; set; }


    // Конструктор
    public Film(int year, double rating, string name, string genre, int duration)
    {
        Year = year;
        Rating = rating;
        Name = name;
        Genre = genre;
        Duration = duration;
    }

    public Film()
    {

    }
}