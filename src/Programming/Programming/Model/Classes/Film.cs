using System;

class Film
{
    private string name, genre;
    private int length, year;   // length - в мин, year - от 1900 до текущего года
    private double rating;      // от 0 до 10

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }
    public int Length
    {
        get { return length; }
        set { length = value; }
    }
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
}