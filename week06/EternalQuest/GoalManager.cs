using System.IO;

public class GoalManager
{
    protected List<string> _goals = new List<string>();
    protected int _score = 0;

    public GoalManager()
    {
        // Initialize the goal manager
    }

    public void Start()
    {        // Start the goal management system
        string menuChoice = "";

        while (menuChoice != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    Console.WriteLine("Create New Goal");
                    Console.WriteLine("The Types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("4. Return to Main Menu");
                    Console.WriteLine("Which type of goal would you like to create?");
                    string goalTypeChoice = Console.ReadLine();
                    switch (goalTypeChoice)

                    {
                        case "1":

                            Console.WriteLine("You have chosen to create a Simple Goal.");
                            Console.WriteLine("What is the name of your goal?");
                            string goalName = Console.ReadLine();
                            Console.WriteLine("What is a short description of it?");
                            string goalDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal?");
                            int goalPoints = int.Parse(Console.ReadLine());
                            SimpleGoal sGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                            _goals.Add(sGoal);
                            break;
                        case "2":
                            Console.WriteLine("You have chosen to create an Eternal Goal.");
                            Console.WriteLine("What is the name of your goal?");
                            goalName = Console.ReadLine();
                            Console.WriteLine("What is a short description of it?");
                            goalDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal?");
                            goalPoints = int.Parse(Console.ReadLine());
                            EternalGoal eGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                            _goals.Add(eGoal);
                            break;
                        case "3":
                            Console.WriteLine("You have chosen to create a Checklist Goal.");
                            Console.WriteLine("What is the name of your goal?");
                            goalName = Console.ReadLine();
                            Console.WriteLine("What is a short description of it?");
                            goalDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal?");
                            goalPoints = int.Parse(Console.ReadLine());
                            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints));
                            break;
                        case "4":
                            Console.WriteLine("Returning to Main Menu.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("List Goals");
                    break;
                case "3":
                    Console.WriteLine("Save Goals");
                    break;
                case "4":
                    Console.WriteLine("Load Goals");
                    break;
                case "5":
                    Console.WriteLine("Record Event");
                    break;
                case "6":
                    Console.WriteLine("Exiting the game. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        // Display player information such as score and current goals
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine("Current Goals:");
        foreach (string goal in _goals)
        {
            Console.WriteLine($"- {goal}");
        }
    }

    public void ListGoalNames()
    {
        // List the names of all current goals
        Console.WriteLine("Current Goals:");
        foreach (string goal in _goals)
        {
            Console.WriteLine($"- {goal}");
        }
    }

    public void ListGoalDetails()
    {
        // List detailed information about each goal
        Console.WriteLine("Goal Details:");
        foreach (string goal in _goals)
        {
            Console.WriteLine($"- {goal} (Details would go here)");
        }
    }
    public void CreateGoal(string goal)
    {


        // Add a new goal to the list
        _goals.Add(goal);
        Console.WriteLine($"Goal '{goal}' has been created.");
    }
    public void RecordEvent(string eventDescription)
    {
        // Record an event that affects the player's goals or score
        Console.WriteLine($"Event recorded: {eventDescription}");
        // Here you would typically update the goals and score based on the event
    }

    public void SaveGoals(string filename)
    {
        // Save the current goals and score to a file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("This is the first line of the file");
            outputFile.WriteLine("This is the second line of the file");
        }

    }
    public void LoadGoals(string filename)
    {
        // Load goals and score from a file
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

        }
    }
}