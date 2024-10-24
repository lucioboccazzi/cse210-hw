public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus; 
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int pointsEarned = GetPoints();
            Console.WriteLine($"Recorded event for '{GetDetailsString()}'. You earned {pointsEarned} points!");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You've completed the goal and earned a bonus of {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"Goal: {_shortName}, Description: {_description}, Completed: {_amountCompleted}/{_target}, Points: {GetPoints()}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_amountCompleted},{_bonus}";
    }
}