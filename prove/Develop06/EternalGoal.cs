public class EternalGoal : Goal
{
    private int _recordCount;
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _recordCount = 0;
    }

    public override void RecordEvent()
    {
        _recordCount++;

        int pointsEarned = GetPoints();
        Console.WriteLine($"Recorded event for '{GetDetailsString()}'. You earned {pointsEarned} points!");
    }
    public override bool IsComplete()
    {
        return false; 
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points},{_recordCount}";
    }
}
