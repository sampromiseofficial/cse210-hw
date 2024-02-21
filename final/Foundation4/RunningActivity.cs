class RunningActivity : Activity
{
    private double DistanceMiles;

    public RunningActivity(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        DistanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return DistanceMiles;
    }

    public override double GetSpeed()
    {
        return DistanceMiles / (base.DurationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return base.DurationMinutes / DistanceMiles;
    }
}