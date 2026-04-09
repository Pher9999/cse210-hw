public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonusPoints)
        : base(shortName, description, points)
    {
        // Initialize the checklist goal
        _amountCompleted = 0;
        _target = target;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent(string eventDescription)
    {
        // Record an event specific to a checklist goal
        _amountCompleted++; // Increment the amount completed for each event recorded
        if (IsCompleted())
        {
            _bonusPoints = 10; // Award bonus points when the checklist goal is completed
        }
    }

    public override bool IsCompleted()
    {
        // Check if the checklist goal is completed
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        // Return a string representation of the checklist goal for saving to a file
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonusPoints}";
    }
}