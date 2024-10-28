public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming (int numberOfLaps, string date, int length) : base (date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double CalculateDistanceInMiles()
    {
        double distanceInMiles = (_numberOfLaps * 50 / 1000) * 0.62;

        return distanceInMiles;
    }

    public override double CalculateSpeed()
    {
        double distance = CalculateDistanceInMiles();

        return (int)(distance / (_length / 60.0));
    }
    public override int CalculatePace()
    {
        double distance = CalculateDistanceInMiles();

        return (int)(_length / distance);
    }

    public override string GetSummary()
    {
        return $"Swimming on {_date}: {_length} minutes, {_numberOfLaps} laps, " +
               $"{CalculateDistanceInMiles():0.00} miles, " +
               $"Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min/mile";
    }

}