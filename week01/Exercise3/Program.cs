using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        //Console.WriteLine("What is the magic Number? ");
        //string magicNumberInput = Console.ReadLine();

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        //int magicNumber = int.Parse(magicNumberInput);
        int guess = 0;
        int numOfGuesses = 0;
        string play = "Yes";


        do
        {           
            Console.WriteLine("What is your guess? ");
            string guessInput = Console.ReadLine();
            numOfGuesses++;
            guess = int.Parse(guessInput); 
            if (magicNumber > guess)
            {Console.WriteLine("Higher");}
            else if(magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

        }while (magicNumber != guess && play == "Yes");

        if (magicNumber == guess);
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine("It took you " + numOfGuesses+ " tries.");

            //Console.WriteLine("Do you wish to play again? ");
            //play = Console.ReadLine();
        }
    }
}