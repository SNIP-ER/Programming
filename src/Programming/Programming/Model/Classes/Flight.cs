class Flight
{
    private string departurePoint, destination;
    private int flightTime;     // В минутах

    public string DeparturePoint
    {
        get { return departurePoint; } 
        set { departurePoint = value; }
    }
    public string Destination
    {
        get { return destination; }
        set { destination = value; }
    }
    public int FlightTime
    {
        get { return flightTime; }
        set { flightTime = value; }
    }
}