public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        ShowSpinner(5); // Show spinner for 3 seconds before starting the breathing exercise
        int cycles = _duration / 8; // Each cycle takes 8 seconds (4 seconds inhale, 4 seconds exhale)
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4); // Inhale for 4 seconds
            Console.Write("\b\b\b\b\b\b\b\b"); // Clear the line

            Console.Write("Breathe out... ");
            ShowCountdown(4); // Exhale for 4 seconds
            Console.Write("\b\b\b\b\b\b\b\b"); // Clear the line
        }
        Console.WriteLine("Great job! You've completed the breathing activity.");
    }

}