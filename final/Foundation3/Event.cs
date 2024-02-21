class Event
{
    private string Title;
    private string Description;
    private DateTime DateAndTime;
    private Address EventAddress;

    public Event(string title, string description, DateTime dateAndTime, string address)
    {
        Title = title;
        Description = description;
        DateAndTime = dateAndTime;
        EventAddress = new Address(address);
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate and Time: {DateAndTime}\nAddress: {EventAddress}";
    }

    public string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {Title}\nDate: {DateAndTime.ToShortDateString()}";
    }
}