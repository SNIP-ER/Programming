using System;

class Time
{
    //  hours - от 0 до 23
    //  minutes - от 0 до 59
    //  seconds - от 0 до 59
    private int hours, minutes, seconds;

    public int Hours
    {
        get { return hours; }
        set
        {
            if (value >= 0 && value <= 23)
            {
                hours = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Часов может быть не меньше 0 и не больше 23!"));
            }
        }
    }
    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value >= 0 && value <= 59)
            {
                minutes = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Минут может быть не меньше 0 и не больше 59!"));
            }
        }
    }
    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value >= 0 && value <= 59)
            {
                seconds = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Секунд может быть не меньше 0 и не больше 59!"));
            }
        }
    }


    // Конструктор
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Time()
    {

    }
}