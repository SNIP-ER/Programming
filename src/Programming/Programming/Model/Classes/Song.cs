// песня в плеере
class Song
{
    public string Name { get; set; }
    public string Author { get; set; }

    private int length;     // длительность песни в сек

    public int Length
    {
        get { return length; }
        set
        {
            length = Validator.AssertOnPositiveValue(value, "Length");
        }
    }     


    // Конструктор
    public Song(string name, string author, int length)
    {
        Name = name;
        Author = author;
        Length = length;
    }

    public Song()
    {

    }
}