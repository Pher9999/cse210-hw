using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string userChoice;

        Console.WriteLine("Hello World! This is the Journal Project.");

        //testing prompt code
        //promptGenerator prompt = new promptGenerator();
        //Console.WriteLine($"Prompt: {prompt.GetRandomPrompt()}");

        Journal journal = new Journal();

        do
        {
            userChoice = DisplayMenu();
            if (userChoice == "1")
            {
                // Write a new Entry
                 Entry entry = new Entry();

                 Console.WriteLine("What is the date? ");
                entry._date = Console.ReadLine();

                promptGenerator _entryPrompt = new promptGenerator();
                entry._promptText = _entryPrompt.GetRandomPrompt();

                Console.WriteLine($"{entry._promptText}");
                Console.WriteLine("Entry:");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);


            }else if(userChoice == "2")
            {
                // Display Journal
                journal.DisplayAll();
                
            }else if(userChoice == "3")
            {
                //Load Journal from file
                Console.WriteLine("Enter a filename to load Journal:");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                
            }else if(userChoice == "4")
            {
                //Save Journal to file
                Console.WriteLine("Enter a filename to save Journal:");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
                
            }else if(userChoice == "5")
            {
               Console.WriteLine("Have a nice day!"); 
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }
        } while (userChoice != "5");
    }

    static string DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Load Journal from file");
        Console.WriteLine("4. Save Journal to file");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");

        string menuChoice = Console.ReadLine();
        return menuChoice;
    }
}