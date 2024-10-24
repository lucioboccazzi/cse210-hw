public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return $"Goal: {_shortName}, Description: {_description}";
    }

    public abstract string GetStringRepresentation();
    public int GetPoints()
    {
        return int.TryParse(_points, out int points) ? points : 0;
    }
}