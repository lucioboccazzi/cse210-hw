public class Running : Activity
{
    private double _distance;

    public Running (int distance, string date, int length) : base (date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistanceInMiles()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / _length * 60; 
    }

    public override int CalculatePace()
    {
        return (int)(_length / _distance);
    }

    public override string GetSummary()
    {
        return $"Running on {_date}: {_length} minutes," +
               $"{_distance} miles," +
               $"Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min/mile";
    }
}