class LectureEvent : Event
{
    private string Speaker;
    private int Capacity;

    public LectureEvent(string title, string description, DateTime dateAndTime, string address, string speaker, int capacity)
        : base(title, description, dateAndTime, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}