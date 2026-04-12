public class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        // Initialize the eternal goal
        _shortName = shortName;
        _description = description;
        _points = points;

    }

    public override void RecordEvent(string eventDescription)
    {
        // Record an event specific to an eternal goal
        Console.WriteLine($"Event recorded for goal '{_shortName}': {eventDescription}");


    }

    public override bool IsCompleted()
    {
        // Check if the eternal goal is completed (eternal goals are never completed)
        return false;
    }
    public override string GetStringRepresentation()
    {
        // Return a string representation of the eternal goal for saving to a file
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
}