class Time
{
    //  hours - от 0 до 23
    //  minutes - от 0 до 60
    //  seconds - от 0 до 60
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

            }
        }
    }
    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value >= 0 && value <= 60)
            {
                minutes = value;
            }
            else
            {

            }
        }
    }
    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value >= 0 && value <= 60)
            {
                seconds = value;
            }
            else
            {

            }
        }
    }
}