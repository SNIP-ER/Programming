// песня в плеере
class Song
{
    private string name, author;
    private int length;     // длительность песни в сек

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public int Length
    {
        get { return length; }
        set { length = value; }
    }
}