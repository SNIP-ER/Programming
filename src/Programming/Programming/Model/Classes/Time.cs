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
            hours = Validator.AssertValueInRange(value, 0, 23, "Hours");
        }
    }
    public int Minutes
    {
        get { return minutes; }
        set
        {
            minutes = Validator.AssertValueInRange(value, 0, 59, "Minutes");
        }
    }
    public int Seconds
    {
        get { return seconds; }
        set
        {
            seconds = Validator.AssertValueInRange(value, 0, 59, "Seconds");
        }
    }


    /// <summary>
    /// Создаёт экземпляр класса <see cref="Time"/>.
    /// </summary>
    /// <param name="hours">Количество часов. От 0 до 23.</param>
    /// <param name="minutes">Количество минут. От 0 до 59.</param>
    /// <param name="seconds">Количество секунд. От 0 до 59.</param>
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