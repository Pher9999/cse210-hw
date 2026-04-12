public class Activity
{
    protected string _name;
    protected int _duration; // Duration in minutes

    public Activity(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }


    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_name} - Duration: {_duration} minutes";
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
}