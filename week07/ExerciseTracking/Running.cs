public class Running : Activity
{
    private double _distance; // Distance in kilometers

    public Running(string name, int duration, double distance) : base(name, duration)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{_name} - Duration: {_duration} minutes, Distance: {_distance} km, Pace: {GetPace():0.00} min/km";
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
    public override double GetSpeed()
    {
        if (_duration > 0)
        {
            return (_distance / _duration) * 60.0; // Speed in km/h
        }
        else
        {
            return 0; // Avoid division by zero
        }
    }
}