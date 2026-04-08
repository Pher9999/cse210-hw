public class Goal()
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public void RecordEvent(string eventDescription)
    {
        // Record an event related to this goal
    }

    public bool IsCompleted()
    {
        // Check if the goal is completed
        return false; // Placeholder return value
    }

    public string GetDetailsString()
    {
        // Return a string with the goal's details
        return $"{_shortName}: {_description} ({_points} points)";
    }

    public void GetStringRepresentation()
    {
        // Return a string representation of the goal for saving to a file
    }
}