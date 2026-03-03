// песня в плеере
class Song
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }     // длительность песни в сек


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