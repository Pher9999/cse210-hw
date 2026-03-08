using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);


    }

    //DisplayWelcome "Welcome to the Program!"
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //PromptUserName - Ask for and returns the user's name(string)
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
        
    }
    //PromptUserNumber - Ask for and return User's favorite number (int)
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }
    //SquareNumber - Accept an integer as a paramater and return square (int)
    static int SquareNumber(int number)
    {
       int squareNumber = number*number;
       return squareNumber; 
    }
    // DisplayResult - Accepts User's name and the squared number and displays them
    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}