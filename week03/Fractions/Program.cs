using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(3, 4);
        Console.WriteLine(f2.GetFractionString());
    }
}