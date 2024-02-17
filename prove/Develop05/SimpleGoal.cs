public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordProgress()
    {
        // For simple goals, recording progress doesn't affect the goal state
    }

    public override string DisplayProgress()
    {
        return $"[Simple Goal] {Name} - {Description} [{Points} points]";
    }
}