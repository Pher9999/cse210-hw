public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        // Initialize the simple goal
        _isCompleted = false;
    }

    public override void RecordEvent(string eventDescription)
    {
        // Record an event specific to a simple goal
    }

    public override bool IsCompleted()
    {
        // Check if the simple goal is completed
        return false; // Placeholder return value
    }
    public override string GetStringRepresentation()
    {
        // Return a string representation of the simple goal for saving to a file
        return $"SimpleGoal|{_shortName}|{_description}|{_points}";
    }
}