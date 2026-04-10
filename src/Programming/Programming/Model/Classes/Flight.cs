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
            flightTime = Validator.AssertOnPositiveValue(value, "FlightTime");
        }
    }


    /// <summary>
    /// Создаёт экземпляр класса <see cref="Flight"/>.
    /// </summary>
    /// <param name="departurePoint">Место отправления.</param>
    /// <param name="destination">Место назначения.</param>
    /// <param name="flightTime">Время полета.</param>
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