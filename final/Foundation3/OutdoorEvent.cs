class OutdoorEvent : Event
{
    private string Weather;

    public OutdoorEvent(string title, string description, DateTime dateAndTime, string address, string weather)
        : base(title, description, dateAndTime, address)
    {
        Weather = weather;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nWeather: {Weather}";
    }
}