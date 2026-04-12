public abstract class Goal()
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points) : this()
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(string eventDescription);

    public abstract bool IsCompleted();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();

}