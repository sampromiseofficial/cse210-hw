class ReceptionEvent : Event
{
    private string RSVP;

    public ReceptionEvent(string title, string description, DateTime dateAndTime, string address, string rsvp)
        : base(title, description, dateAndTime, address)
    {
        RSVP = rsvp;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP Email: {RSVP}";
    }
}