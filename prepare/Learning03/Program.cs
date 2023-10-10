using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new();
        
       // Console.WriteLine($"{fraction.NumFraction()}");
       // Console.WriteLine("");
        
       // Console.WriteLine($"{fraction.NumFraction(6)}");
       // Console.WriteLine("");

        //Console.WriteLine($"{fraction.NumFraction(6,7)}");

        fraction.SetTop(50);
        Console.WriteLine($"{fraction.GetTop()}");

        fraction.SetBottom(60);
        Console.WriteLine(fraction.GetBottom());


    }
}