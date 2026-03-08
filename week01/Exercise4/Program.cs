using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string response;
        int numberSum = 0;

        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of Numbers, Type 0 when finished. ");
        do
        {
            Console.WriteLine("Enter a number: ");
            response = Console.ReadLine();
            numbers.Add(int.Parse(response));
        } while (response != "0");
        //remove 0 from list
        numbers.RemoveAt(numbers.Count - 1);

        //sort list before getting more info.
        numbers.Sort();

        //sum list
        
        for (int i = 0; i < numbers.Count; i++)
        {
            numberSum += numbers[i];
        }
        Console.WriteLine($"The sum is: {numberSum}");

        //average list
       
        float average = ((float)numberSum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //largest number
        Console.WriteLine($"The largest number is: {numbers.Last()}");
        //smallest positive number
        foreach( int number in numbers)
        {
            if (number > 0)
            {}
        }
        Console.WriteLine($"The smallest positive number is: {numbers.First()}");

        //sorted list
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);

        }


    }
}