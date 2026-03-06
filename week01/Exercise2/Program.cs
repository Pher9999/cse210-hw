using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your Grade(%)?");
        string gradeInput= Console.ReadLine();

        int gradeNumber = int.Parse(gradeInput);
        string gradeLetter = "";

        string gradeSign = "";
        if (gradeNumber%10 >= 7)
        {
            gradeSign = "+";
        }else if (gradeNumber%10 < 3)
        {
            gradeSign = "-";
        }

        if (gradeNumber < 60)
        {
            gradeLetter = "F";
        }else if (gradeNumber >= 60 && gradeNumber <70)
        {
            gradeLetter = "D"+gradeSign;
        }else if (gradeNumber >= 70 && gradeNumber <80)
        {
            gradeLetter = "C"+gradeSign;
        }else if (gradeNumber >= 80 && gradeNumber <90)
        {
            gradeLetter = "B"+gradeSign;
        }else if (gradeNumber >= 90 && gradeNumber <=100)
        {
            if( gradeSign == "+")
            {
                gradeSign = "";
            }    
                gradeLetter = "A"+gradeSign;
            
        }

        Console.WriteLine("Your grade is: " + gradeLetter);
        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}