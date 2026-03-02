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

            }
        }
    }
    public int Rating
    {
        get { return rating; }
        set { rating = value; }
    }
}