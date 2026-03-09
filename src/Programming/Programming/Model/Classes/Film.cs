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
            year = Validator.AssertValueInRange(value, 1900, 2026, "Year");
        }
    }
    public double Rating
    {
        get { return rating; }
        set
        {
            rating = Validator.AssertValueInRange(value, 0, 10, "Rating");
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