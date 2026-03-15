public class Entry
{

    // variable string -Date
    public string _date = "";
    // variable list -Prompt
    public string _promptText = "";
    // variable string -response
    public string _entryText = "";
    // method - write Entry


    public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");

        }
}