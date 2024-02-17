public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordProgress()
    {
        // For eternal goals, recording progress adds points
        Points += 100; // Example: Every time an Eternal Goal is recorded, add 100 points
    }

    public override string DisplayProgress()
    {
        return $"[Eternal Goal] {Name} - {Description} [{Points} points]";
    }
}