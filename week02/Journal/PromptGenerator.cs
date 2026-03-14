public class promptGenerator
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
  
 public string GetRandomPrompt()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
}