public class ReflectionActivity : Activity
{
    public ReflectionActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void Run(int durationInSeconds)
    {
        Console.WriteLine("Take a moment to think about the following prompt:");
        Console.WriteLine("What are three things that went well today, and why?");
        Console.WriteLine("You have 30 seconds to reflect on this. Start now!");

        ShowSpinner(durationInSeconds);

        Console.WriteLine("Great job! Take a moment to appreciate the positive aspects of your day.");
    }
}