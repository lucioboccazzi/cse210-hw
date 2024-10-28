public class Cycling : Activity
{
    private int _speed;

    public Cycling (int speed, string date, int length) : base (date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistanceInMiles()
    {
        double timeInHours = _length / 60.0; 
        return _speed * timeInHours; 
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override int CalculatePace()
    {
        double distance = CalculateDistanceInMiles();
        if (distance == 0) return 0;
        return (int)(_length / distance); 
    }

    public override string GetSummary()
    {
        return $"Cycling on {_date}: {_length} minutes, " +
               $"{CalculateDistanceInMiles():0.00} miles, " +
               $"Speed: {CalculateSpeed()} mph, " +
               $"Pace: {CalculatePace()} min/mile";
    }
}