class Flight
{
    public string DeparturePoint { get; set; }
    public string Destination { get; set; }

    private int flightTime;     // В минутах

    public int FlightTime
    {
        get { return flightTime; }
        set
        {
            flightTime = (int)Validator.AssertOnPositiveValue((float)value, "FlightTime");
        }
    }


    // Конструктор
    public Flight(string departurePoint, string destination, int flightTime)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTime = flightTime;
    }

    public Flight()
    {

    }
}