class CyclingActivity : Activity
{
    private double SpeedKph;

    public CyclingActivity(DateTime date, int durationMinutes, double speedKph)
        : base(date, durationMinutes)
    {
        SpeedKph = speedKph;
    }

    public override double GetSpeed()
    {
        return SpeedKph;
    }

    public override double GetPace()
    {
        return 60 / SpeedKph;
    }
}