using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("1 Nephi", 1, 3);
        Scripture scripture = new Scripture(reference, "And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge.");
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            Console.Clear();
            scripture.HideRandomWord();

        }
    }
}