public class Swimming : Activity
{
    private int _laps; // Number of laps


    public Swimming(string name, int duration, int laps) : base(name, duration)
    {
        _laps = laps;
    }

    public override string GetSummary()
    {
        return $"{_name} - Duration: {_duration} minutes, Laps: {_laps}, Pace: {GetPace():0.00} min/lap";
    }

    public override double GetPace()
    {
        if (_laps > 0)
        {
            return _duration / (double)_laps; // Pace in minutes per lap
        }
        else
        {
            return 0; // Avoid division by zero
        }
    }
}