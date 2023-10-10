using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new();
        
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalFraction());
       

        Fraction f2 = new(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalFraction());


        Fraction f3 = new(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalFraction());


        Fraction f4 = new(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalFraction());

    }
}