class Activity
{
    protected DateTime Date { get; private set; }
    protected int DurationMinutes { get; private set; }

    public Activity(DateTime date, int durationMinutes)
    {
        Date = date;
        DurationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({DurationMinutes} min) - " +
               $"Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}