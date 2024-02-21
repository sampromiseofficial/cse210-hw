class SwimmingActivity : Activity
{
    private int Laps;

    public SwimmingActivity(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (base.DurationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return base.DurationMinutes / GetDistance();
    }
}