class Flight
{
    public string DeparturePoint { get; set; }
    public string Destination { get; set; }
    public int FlightTime { get; set; }     // В минутах


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