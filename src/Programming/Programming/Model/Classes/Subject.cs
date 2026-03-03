using System;

class Subject
{
    private string credit;    // credit - зачет/незачет

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

    public string Name { get; set; }
    public int Rating { get; set; }
}