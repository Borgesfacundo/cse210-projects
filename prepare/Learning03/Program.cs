using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new();
        
        Console.WriteLine($"{fraction.NumFraction()}");
        Console.WriteLine("");
        
        Console.WriteLine($"{fraction.NumFraction(6)}");
        Console.WriteLine("");

        Console.WriteLine($"{fraction.NumFraction(6,7)}");

    }
}