public class ReflectionActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think od a thime when you helped someone in need.",
        "Think of a time when you did something truly selfless."

    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you apply what you learned from this experience in the future?"
    };

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