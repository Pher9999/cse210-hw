public class ListingActivity : Activity
{
    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void Run(int durationInSeconds)
    {
        Console.WriteLine("Take a moment to think about the following prompt:");
        Console.WriteLine("List as many things as you can that you are grateful for.");
        Console.WriteLine("You have 30 seconds to list your items. Start now!");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"Great job! You listed {items.Count} items that you are grateful for.");
    }
}