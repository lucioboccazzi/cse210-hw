public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity (string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double CalculateDistanceInMiles();
    public abstract double CalculateSpeed();
    public abstract int CalculatePace();
    public abstract string GetSummary();

}