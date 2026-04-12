public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        // Initialize the simple goal
        _isCompleted = false;
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public override void RecordEvent(string eventDescription)
    {
        // Record an event specific to a simple goal
        _isCompleted = true; // Mark the simple goal as completed when an event is recorded
        Console.WriteLine($"Event recorded for goal '{_shortName}': {eventDescription}");
    }

    public override bool IsCompleted()
    {
        // Check if the simple goal is completed
        if (_isCompleted == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        // Return a string representation of the simple goal for saving to a file
        return $"SimpleGoal|{_shortName}|{_description}|{_points}";
    }

    public override string GetDetailsString()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }
}