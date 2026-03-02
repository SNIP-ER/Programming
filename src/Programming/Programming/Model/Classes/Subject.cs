using System;

class Subject
{
    private string name, credit;    // credit - зачет/незачет
    private int rating;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Credit
    {
        get { return credit; }
        set
        {
            if ((value == "зачёт") || (value == "зачет") || (value == "незачёт") || (value == "незачет"))
            {
                credit = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Можно писать только зачет/незачет (е/ё)!"));
            }
        }
    }
    public int Rating
    {
        get { return rating; }
        set { rating = value; }
    }
}