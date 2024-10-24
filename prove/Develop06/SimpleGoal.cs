public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false; 
    }
    public override void RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal is already complete.");
            return;
        }

        _isComplete = true;

        Console.WriteLine($"Goal '{GetDetailsString()}' marked as complete! You earned {GetPoints()} points.");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
    }

    public static SimpleGoal LoadFromString(string goalString)
    {
        var parts = goalString.Split(',');
        if (parts.Length != 5 || parts[0] != "SimpleGoal")
            throw new FormatException("Invalid goal string format");

        string name = parts[1];
        string description = parts[2];
        string points = parts[3];
        bool isComplete = bool.Parse(parts[4]);

        var goal = new SimpleGoal(name, description, points);
        if (isComplete)
        {
            goal.MarkAsComplete(); 
        }

        return goal;
    }
    public void MarkAsComplete()
    {
        _isComplete = true;
    }
}
