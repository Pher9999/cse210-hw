public class Cycling : Activity
{
    private double _distance; // Distance in kilometers

    public Cycling(string name, int duration, double distance) : base(name, duration)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        throw new NotImplementedException();
    }

    public override double GetPace()
    {
        if (_distance > 0)
        {
            return _duration / _distance; // Pace in minutes per kilometer
        }
        else
        {
            return 0; // Avoid division by zero
        }
    }
}