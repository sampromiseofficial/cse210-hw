public class ChecklistGoal : Goal
{
    public int TargetTimes { get; set; }
    public int BonusPoints { get; set; }
    public int TimesCompleted { get; private set; }

    public ChecklistGoal(string name, string description, int points, int targetTimes, int bonusPoints)
        : base(name, description, points)
    {
        TargetTimes = targetTimes;
        BonusPoints = bonusPoints;
    }

    public override void RecordProgress()
    {
        // For checklist goals, recording progress increments completion count and adds points
        TimesCompleted++;
        if (TimesCompleted >= TargetTimes)
        {
            Points += BonusPoints;
        }
    }

    public override string DisplayProgress()
    {
        return $"[Checklist Goal] {Name} - {Description} [Completed {TimesCompleted}/{TargetTimes} times, {Points} points]";
    }
}